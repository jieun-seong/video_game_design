using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private GameObject character;
    private Animator anim;
    private CharacterController controller;
    private Rigidbody rb;
    public Transform playerCamera = null;
    public Transform cameraRoot = null;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 1.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private Vector3 offset;
    public float cameraSpeedH = 2.0f;
    public float cameraSpeedV = 2.0f;
    private float speedMultiplier = 2.0f;
    public float walkSpeed = 1.0f;

    //health bar stuff
    private float attackTime = 0f;
    private float deathTime = 0f;
    private int maxHealth = 100;
    private int currentHealth;
    public GameObject healthBar;
    private HealthBarScript hbs;
    //

    // Audio
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
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        character = transform.GetChild(0).gameObject;
        controller = GetComponent<CharacterController>();
        anim = character.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        offset = playerCamera.transform.position - transform.position;
        currentHealth = maxHealth;
        hbs.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        CheckDamage();
        // player dying if no health
        if (currentHealth == 0 && !anim.GetBool("Dead")) {
            anim.SetBool("Dead", true);
            deathTime = Time.time;
        }
        if (anim.GetBool("Dead") && Time.time > deathTime + 2) {
            Destroy(this.gameObject); // destroy after playing death animation
        }

        groundedPlayer = controller.isGrounded;
        anim.SetBool("Grounded", groundedPlayer);

        if (groundedPlayer && playerVelocity.y < 0.0f)
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

        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        Vector3 camDirection = playerCamera.transform.rotation * dir;
        Vector3 targetDirection = new Vector3(camDirection.x, 0, camDirection.z);
        character.transform.forward = targetDirection;
        controller.Move(targetDirection.normalized * playerSpeed * speedMultiplier);
        anim.SetFloat("Speed", (targetDirection.normalized * playerSpeed * speedMultiplier).magnitude);
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