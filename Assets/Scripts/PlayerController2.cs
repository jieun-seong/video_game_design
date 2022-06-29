using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    public Transform playerCamera = null;
    public Transform cameraRoot = null;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private Vector3 offset;
    private Vector3 offsetAngle;
    public float cameraSpeedH = 2.0f;
    public float cameraSpeedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float speedMultiplier = 1.0f;
    public float walkSpeed = 2.0f;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;
    float moveSmoothTime = 0.01f;
    float mouseSmoothTime = 0.03f;

    //health bar stuff
    private float attackTime = 0f;
    private int maxHealth = 100;
    private int currentHealth;
    public GameObject healthBar;
    private HealthBarScript hbs;
    //

    // Audio
    public AudioClip[] FootstepAudioClips;
    [Range(0, 1)] public float FootstepAudioVolume = 0.5f;

    public AudioClip SmallPlantClip;
    [Range(0, 1)] public float SmallPlantVolume = 0.5f;

    public AudioClip ChoppingWoodClip;
    public AudioClip[] ChoppingWoodClips;
    [Range(0, 1)] public float ChoppingWoodVolume = 0.5f;

    public AudioClip PickUpBagClip;
    [Range(0, 1)] public float PickUpBagVolume = 0.1f;

    private void Awake() {
        hbs = healthBar.GetComponent<HealthBarScript>();
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        offset = playerCamera.transform.position - transform.position;
        currentHealth = maxHealth;
        hbs.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        CheckDamage();
        groundedPlayer = controller.isGrounded;
        anim.SetBool("Grounded", groundedPlayer);

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0.0f;
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speedMultiplier = 2.0f;
        }
        else
        {
            speedMultiplier = 1.0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed * speedMultiplier);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (Input.GetKey("space") && groundedPlayer)
        {
            anim.SetBool("Jump", true);
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }

        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed * speedMultiplier + Vector3.up * playerVelocity.y;
        controller.Move(velocity * Time.deltaTime);

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        anim.SetFloat("Speed", (new Vector3(velocity.x, 0f, velocity.z)).magnitude);
    }

    void LateUpdate()
    {
        float rotationSpeed = 2.5f;
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = -Input.GetAxis("Mouse Y");

        playerCamera.transform.RotateAround(cameraRoot.position, Vector3.up, rotateHorizontal * rotationSpeed);
        playerCamera.transform.RotateAround(cameraRoot.position, playerCamera.right, rotateVertical * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(SmallPlantClip, transform.TransformPoint(controller.center), SmallPlantVolume);
            //anim.SetBool(_animIDPickUp, true);
        }
        if (other.gameObject.CompareTag("Weapon"))
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(PickUpBagClip, transform.TransformPoint(controller.center), PickUpBagVolume);
        }
        if (other.gameObject.CompareTag("Tree"))
        {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(ChoppingWoodClip, transform.TransformPoint(controller.center), ChoppingWoodVolume);
        }

    }

    private void OnFootstep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            if (FootstepAudioClips.Length > 0)
            {
                var index = Random.Range(0, FootstepAudioClips.Length);
                AudioSource.PlayClipAtPoint(FootstepAudioClips[index], transform.TransformPoint(controller.center), FootstepAudioVolume);
            }
        }
    }

    void CheckDamage() {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject z in zombies) {
            float distance = Vector3.Distance(transform.position, z.transform.position);
            if (distance < 5 && Time.time > attackTime + 2.5) {
                attackTime = Time.time; //give enough time for zombie fighting anim to play
                if (currentHealth - 10 >= 0) { //10 is preset damage
                    currentHealth -= 10; //change damage amount later when zombies have levels
                } else {
                    currentHealth = 0;
                }
                hbs.SetHealth(currentHealth);
            }
        }
    }
}