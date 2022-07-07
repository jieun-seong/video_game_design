using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    //inventory
    [SerializeField] private InventoryPanel playerInventory;

    private GameObject character;
    private Animator anim;
    private CharacterController controller;
    private Rigidbody rb;
    public Transform playerCamera = null;
    public Transform cameraRoot = null;
    //private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 10.0f;
    //private float jumpHeight = 1.0f;
    private Vector3 offset;
    public float cameraSpeedH = 2.0f;
    public float cameraSpeedV = 2.0f;
    private float speedMultiplier = 2.0f;
    public float walkSpeed = 1.0f;
    private float currSpeed = 0.0f;
    Vector3 targetDirection;

    //health bar stuff
    private float attackTime = 0f;
    private float deathTime = 0f;
    private int maxHealth = 100;
    private int currentHealth;
    public GameObject healthBar;
    private HealthBarScript hbs;
    private bool dead;

    //gravity
    private bool isGrounded;
    public Transform groundCheck;
    private float groundDistance = 1.5f;
    public LayerMask groundMask;
    private float gravity = -98f;
    private Vector3 velocity;
    //

    //spell
    public ParticleSystem ps;

    //dialogue stuff
    //private DialogueUI dialogueui;
    //public Canvas dialogueCanvas;
    //[SerializeField] private DialogueObject pressEDialogue;
    //public GameObject waypointForDialogue;

    // Audio
    //public AudioClip SmallPlantClip;
    //[Range(0, 1)] public float SmallPlantVolume = 0.5f;

    //public AudioClip ChoppingWoodClip;
    //public AudioClip[] ChoppingWoodClips;
    //[Range(0, 1)] public float ChoppingWoodVolume = 0.5f;

    public AudioClip PickUpBagClip;
    [Range(0, 1)] public float PickUpBagVolume = 0.1f;

    private void Awake() {
        gameStatus.playerDead = false;
        hbs = healthBar.GetComponent<HealthBarScript>();
    }
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        character = transform.GetChild(0).gameObject;
        controller = GetComponent<CharacterController>();
        anim = character.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        offset = playerCamera.transform.position - transform.position;
        currentHealth = maxHealth;
        hbs.SetMaxHealth(maxHealth);
        //dialogueui = dialogueCanvas.GetComponent<DialogueUI>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        CheckDamage();
        // player dying if no health
        if (currentHealth <= 0 && !anim.GetBool("Dead")) {
            anim.SetBool("Dead", true);
            deathTime = Time.time;
            dead = true;
        }
        if (anim.GetBool("Dead") && Time.time > deathTime + 2) {
            //Destroy(this.gameObject); // destroy after playing death animation
            gameStatus.playerDead = true;
        }

        //dialogue box if close to interaction
        //if (!Input.GetKeyUp(KeyCode.E) && Vector3.Distance(transform.position, waypointForDialogue.transform.position) < 5) {
        //dialogueui.ShowDialogue(pressEDialogue);
        //}

        groundedPlayer = controller.isGrounded;
        anim.SetBool("Grounded", groundedPlayer);
        //playerVelocity.y = 0.0f;

        if (Input.GetKey("space") && groundedPlayer && !dead)
        {
            anim.SetBool("Jump", true);
            //rb.AddForce(Vector3.up * 40f);
            //playerVelocity.y = Mathf.Sqrt(jumpHeight * -5.0f * gravityValue);
        }
        else
        {
            anim.SetBool("Jump", false);
            //playerVelocity.y = gravityValue * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speedMultiplier = 2.6f;
        }
        else
        {
            speedMultiplier = 1.0f;
        }

        if (Input.GetKey(KeyCode.Q) && !dead)
        {
            anim.SetBool("Punch", true);
        }
        else
        {
            anim.SetBool("Punch", false);
        }

        if (Input.GetKey(KeyCode.V) && !dead)
        {
            anim.SetBool("Spell", true);
            ps.Play();
        }
        else
        {
            anim.SetBool("Spell", false);
        }

        if ((Input.GetAxis("Horizontal") != 0.0f || Input.GetAxis("Vertical") != 0.0f) && !dead)// && isGrounded)
        {
            targetDirection = playerCamera.transform.right * Input.GetAxis("Horizontal")/10.0f + playerCamera.transform.forward * Input.GetAxis("Vertical");
            targetDirection.y = 0.0f;
            controller.Move(targetDirection.normalized * playerSpeed * speedMultiplier * Time.deltaTime);
            currSpeed = (targetDirection.normalized * playerSpeed * speedMultiplier).magnitude;
        }
        else
        {
            targetDirection = transform.forward;
            currSpeed = 0.0f;
        }

        transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
        anim.SetFloat("Speed", currSpeed);
        updateY();

    }

    private void updateY()
    {
        groundedPlayer = controller.isGrounded;
        velocity.y = gravity * Time.deltaTime;
        controller.Move(velocity);
        //anim.SetBool("Grounded", groundedPlayer);
        //playerVelocity.y = 0.0f;
        //if (Input.GetKey("space") && groundedPlayer)
        //{
        //    anim.SetBool("Jump", true);
        //    playerVelocity.y = Mathf.Sqrt(jumpHeight * gravityValue);
        //}
        //else
        //{
        //    anim.SetBool("Jump", false);
        //    playerVelocity.y = gravityValue * Time.deltaTime;
        //}

        //controller.Move(playerVelocity);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.gameObject.CompareTag("inventory"))
        {
            playerInventory.AddItem(other.transform.root.gameObject);
            other.transform.root.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(PickUpBagClip, transform.TransformPoint(controller.center), PickUpBagVolume);
        }

        //    if (other.gameObject.CompareTag("Collectible"))
        //    {
        //        other.gameObject.SetActive(false);
        //        AudioSource.PlayClipAtPoint(SmallPlantClip, transform.TransformPoint(controller.center), SmallPlantVolume);
        //        //anim.SetBool(_animIDPickUp, true);
        //    }
        //    if (other.gameObject.CompareTag("Weapon"))
        //    {
        //        other.gameObject.SetActive(false);
        //        AudioSource.PlayClipAtPoint(PickUpBagClip, transform.TransformPoint(controller.center), PickUpBagVolume);
        //    }
        //    if (other.gameObject.CompareTag("Tree"))
        //    {
        //        other.gameObject.SetActive(false);
        //        AudioSource.PlayClipAtPoint(ChoppingWoodClip, transform.TransformPoint(controller.center), ChoppingWoodVolume);
        //    }
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