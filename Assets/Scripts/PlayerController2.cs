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
    public Transform playerCamera = null;
    public Transform cameraRoot = null;
    //private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 10.0f;
    public float cameraSpeedH = 2.0f;
    public float cameraSpeedV = 2.0f;
    private float speedMultiplier = 1.7f;
    public float walkSpeed = 1.0f;
    private float currSpeed = 0.0f;
    Vector3 targetDirection;

    //health & mana bar stuff
    private float attackTime = 0f;
    private float deathTime = 0f;
    private float manaTime = 0f;
    private int maxHealth = 100;
    private int maxMana = 100;
    private int currentHealth;
    private int currentMana;
    public GameObject healthBar;
    public GameObject manaBar;
    private HealthBarScript hbs;
    private ManaBarScript mbs;
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
    public ParticleSystem ps_spell;
    public ParticleSystem ps_healing;
    public ParticleSystem ps_death;
    public ParticleSystem ps_blood;

    //dialogue stuff
    //private DialogueUI dialogueui;
    //public Canvas dialogueCanvas;
    //[SerializeField] private DialogueObject pressEDialogue;
    //public GameObject waypointForDialogue;

    // Audio
    public AudioClip SpellClip;
    [Range(0, 1)] public float SpellVolume = 1f;

    

    public AudioClip PickUpBagClip;
    [Range(0, 1)] public float PickUpBagVolume = 1f;

    //public AudioClip SmallPlantClip;
    //[Range(0, 1)] public float SmallPlantVolume = 0.5f;

    //public AudioClip ChoppingWoodClip;
    //public AudioClip[] ChoppingWoodClips;
    //[Range(0, 1)] public float ChoppingWoodVolume = 0.5f;


    private void Awake() {
        gameStatus.playerDead = false;
        hbs = healthBar.GetComponent<HealthBarScript>();
        mbs = manaBar.GetComponent<ManaBarScript>();
    }

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        character = transform.GetChild(0).gameObject;
        controller = GetComponent<CharacterController>();
        anim = character.GetComponent<Animator>();
        currentHealth = maxHealth;
        currentMana = maxMana;
        hbs.SetMaxHealth(maxHealth);
        mbs.SetMaxMana(maxMana);
        //Debug.Log("Mana set to: " + currentMana);
        //dialogueui = dialogueCanvas.GetComponent<DialogueUI>();
    }

    void Update()
    {
        //if health or mana potion used since last update, status applied - ed209uardo
        if (gameStatus.itemUsed)
        {
            if (gameStatus.healthAdded > 0)
            {
                currentHealth += gameStatus.healthAdded;
                if (currentHealth > maxHealth)
                {
                    currentHealth = maxHealth;
                }
                hbs.SetHealth(currentHealth);
                gameStatus.healthAdded = 0;

                // play the healing animation
                ps_healing.Play();
            }
            if (gameStatus.manaAdded > 0)
            {
                currentMana += gameStatus.manaAdded;
                if (currentMana > maxMana)
                {
                    currentMana = maxMana;
                }
                mbs.SetMana(currentMana);
                gameStatus.manaAdded = 0;

                // play the healing animation
                ps_healing.Play();
            }
            gameStatus.itemUsed = false;
        }

        //CheckDamage();
        // player dying if no health
        if (currentHealth <= 0 && !anim.GetBool("Dead")) {
            anim.SetBool("Dead", true);
            deathTime = Time.time;
            dead = true;
            ps_death.Play();
        }
        if (anim.GetBool("Dead") && Time.time > deathTime + 2) {
            //Destroy(this.gameObject); // destroy after playing death animation
            gameStatus.playerDead = true;
        }

        //dialogue box if close to interaction
        //if (!Input.GetKeyUp(KeyCode.E) && Vector3.Distance(transform.position, waypointForDialogue.transform.position) < 5) {
        //dialogueui.ShowDialogue(pressEDialogue);
        //}

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        groundedPlayer = controller.isGrounded;
        anim.SetBool("Grounded", groundedPlayer);

        if (Input.GetKeyDown("space") && groundedPlayer && !dead)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speedMultiplier = 2.6f;
        }
        else
        {
            speedMultiplier = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.Q) && !dead)
        {
            anim.SetBool("Punch", true);
        }
        else
        {
            anim.SetBool("Punch", false);
        }

        if (Input.GetKeyDown(KeyCode.V) && (currentMana - 30) >= 0 && !dead) //30 is preset mana cost
        {
            anim.SetBool("Spell", true);

            //mana consumed when casting spell - ed209uardo
            currentMana -= 30;
            mbs.SetMana(currentMana);
            //Debug.Log("Mana now: " + currentMana);
            manaTime = Time.time;
            ps_spell.Play();
            AudioSource.PlayClipAtPoint(SpellClip, transform.TransformPoint(controller.center), SpellVolume);
        }
        else
        {
            anim.SetBool("Spell", false);
        }

        float hdir = Input.GetAxis("Horizontal");
        float vdir = Input.GetAxis("Vertical");
        if (vdir > 0.0f && !dead)
        {
            targetDirection = transform.right * hdir * 0.3f + transform.forward * vdir;
            targetDirection.y = 0.0f;
            controller.Move(targetDirection.normalized * playerSpeed * speedMultiplier * Time.deltaTime);
            currSpeed = (targetDirection.normalized * playerSpeed * speedMultiplier).magnitude;

            transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
        }
        else if (vdir < 0.0f && !dead)
        {
            targetDirection = transform.right * hdir * -0.1f + transform.forward * vdir;
            targetDirection.y = 0.0f;
            controller.Move(targetDirection.normalized * playerSpeed * speedMultiplier * Time.deltaTime);
            currSpeed = playerSpeed;
        }
        else if (hdir != 0.0f && !dead)
        {
            targetDirection = transform.right * hdir * Time.deltaTime * 0.01f;
            currSpeed = playerSpeed;
            transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
        }
        else
        {
            targetDirection = transform.forward;
            currSpeed = 0.0f;
            transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
        }

        
        anim.SetFloat("Speed", currSpeed);

        //mana replenishes over time - ed209uardo
        if (currentMana < maxMana && Time.time - manaTime >= 1f)
        {
            currentMana += Mathf.RoundToInt((maxMana / 100));
            mbs.SetMana(currentMana);
            manaTime = Time.time;
        }

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
    }

    public void TakeDamage() {
        if (currentHealth - 10 >= 0) { //10 is preset damage
            currentHealth -= 10; //change damage amount later when zombies have levels
        } else {
            currentHealth = 0;
        }
        hbs.SetHealth(currentHealth);
        ps_blood.Play();
    }
    // void CheckDamage() {
    //     GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
    //     foreach (GameObject z in zombies) {
    //         float distance = Vector3.Distance(transform.position, z.transform.position);
    //         if (distance < 5 && Time.time > attackTime + 2.5) {
    //             attackTime = Time.time; //give enough time for zombie fighting anim to play
    //             if (currentHealth - 10 >= 0) { // 10 is preset damage
    //                 currentHealth -= 10; //change damage amount later when zombies have levels
    //             } else {
    //                 currentHealth = 0;
    //             }
    //             hbs.SetHealth(currentHealth);
    //             ps_blood.Play();
    //         }
    //     }
    // }
}