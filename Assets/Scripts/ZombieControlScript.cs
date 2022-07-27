using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieControlScript : MonoBehaviour
{
    private Animator anim;
    public AIDirector dir;
    public GameObject character;
    public GameObject zombie;
    Rigidbody rb;
    public GameObject healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    private HealthBarScript hbs;
    private float attackTime = 0f;
    private float deathTime = 0f;
    private float zombieAttackTime = 0f;
    private float despawnTime = -2f;
    public float speed = 1f;
    public LootTable dropTable;
    private GameObject child;
    private CharacterController controller;
    private PlayerController2 playerScript;
    public bool spawned;
    public bool billy;
    public bool original;

    //gravity
    private bool isGrounded;
    public Transform groundCheck;
    private float groundDistance = 1.5f;
    public LayerMask groundMask;
    private float gravity;
    private Vector3 velocity;
    private bool groundedPlayer;
    //

    //particle effects
    public ParticleSystem ps_death;
    public ParticleSystem ps_blood;
    //

    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody>();
        hbs = healthBar.GetComponent<HealthBarScript>();
        groundDistance = 1.5f;
        gravity = -98;
    }
    void Start()
    {
        child = transform.GetChild(0).gameObject;
        controller = GetComponent<CharacterController>();
        anim = child.GetComponent<Animator>();
        anim.SetFloat("Blend", 0f);
        transform.LookAt(character.transform);
        currentHealth = maxHealth;
        hbs.SetMaxHealth(maxHealth);
        playerScript = character.GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        if(original) return;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        healthBar.transform.position = transform.position + new Vector3(0f,6f,0f);
        float distance = Vector3.Distance(character.transform.position, transform.position);

        if(distance > 180 && despawnTime > -1) {
            if(despawnTime <= 0) {
                Despawn();
            } else {
                despawnTime -= Time.deltaTime;
            }
        }
        if (currentHealth == 0 && !anim.GetBool("Dead")) {
            anim.SetBool("Dead", true);
            deathTime = Time.time;
            //Destroy(zombie);
            if(billy) dir.Enabled = true;
            ps_death.Play();
        }
        if (anim.GetBool("Dead") && Time.time > deathTime + 6.5) {
            dir.zombsTotal--;
            dir.zombKills++;
            Destroy(zombie); // destroy after playing death animation
            spawnDrops(); // drop items after the death animation 
        }
        if (!anim.GetBool("Dead")) {
            Vector3 targetDirection = character.transform.position - transform.position;
            if (distance < 7) { //fight player
                //transform.LookAt(character);
                anim.SetBool("Attacking", true);
                if (zombieAttackTime <= 0f) { //first zombie attack, wait slightly for animation
                    zombieAttackTime = Time.time;
                }
                if (zombieAttackTime + 2.5 < Time.time) {
                    zombieAttackTime = Time.time;
                    playerScript.TakeDamage();// player take damage
                }
                if (Input.GetKeyDown(KeyCode.Q) && Time.time > attackTime + 1.0f) { //player punch
                    attackTime = Time.time;
                    TakeDamage(15);
                }
            } else if (distance < 15) { //magic attack
                if (Input.GetKeyDown(KeyCode.V) && Time.time > attackTime) {
                    attackTime = Time.time;
                    TakeDamage(30);
                }
                zombieAttackTime = 0f;
                anim.SetBool("Attacking", false);
                //transform.position = Vector3.MoveTowards(transform.position, character.position, 2.0f * Time.deltaTime);
                controller.Move(targetDirection.normalized * 4 * Time.deltaTime * speed);
                transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
                //transform.LookAt(character.position);
                anim.SetFloat("Blend", 1f);
            } else if (distance < 30 || spawned) { // make zombie go towards player fast
                anim.SetBool("Attacking", false);
                //transform.position = Vector3.MoveTowards(transform.position, character.position, 2.0f * Time.deltaTime);
                controller.Move(targetDirection.normalized * 4 * Time.deltaTime * speed);
                transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
                //transform.LookAt(character.position);
                anim.SetFloat("Blend", 1f);
            } else if (distance < 50 && !spawned) { // make zombie go towards player slowly
                distance = distance - 30;
                distance = 1.0f - (distance / 20.0f);
                //transform.position = Vector3.MoveTowards(transform.position, character.position, (distance*2.0f) * Time.deltaTime);
                //transform.LookAt(character.position);
                controller.Move(targetDirection.normalized * 2 * Time.deltaTime * speed);
                transform.forward = Vector3.Slerp(transform.forward, new Vector3(targetDirection.x, 0.0f, targetDirection.z), 0.03f);
                anim.SetFloat("Blend", distance);
                zombieAttackTime = 0f;
            } else { // zombie stand still
                anim.SetFloat("Blend", 0f);
                transform.LookAt(character.transform);
                zombieAttackTime = 0f;
            }
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
    // void FixedUpdate()
    // {
    //     if (!anim.GetBool("Dead")) {
    //         float distance = Vector3.Distance(character.position, transform.position);
    //         if (distance < 5) { //fight player
    //             //transform.LookAt(character);
    //             anim.SetBool("Attacking", true);
    //             // if (Input.GetKeyDown(KeyCode.Q)) {
    //             //     TakeDamage(20);
    //             // }
    //         } else if (distance < 30) { // make zombie go towards player fast
    //             anim.SetBool("Attacking", false);
    //             transform.position = Vector3.MoveTowards(transform.position, character.position, 2.0f * Time.deltaTime);
    //             transform.LookAt(character.position);
    //             anim.SetFloat("Blend", 1f);
    //         } else if (distance < 50) { // make zombie go towards player slowly
    //             distance = distance - 30;
    //             distance = 1.0f - (distance / 20.0f);
    //             transform.position = Vector3.MoveTowards(transform.position, character.position, (distance*2.0f) * Time.deltaTime);
    //             transform.LookAt(character.position);
    //             anim.SetFloat("Blend", distance);
    //         } else { // zombie stand still
    //             anim.SetFloat("Blend", 0f);
    //             transform.LookAt(character);
    //         }
    //     }
    //     //if (character) {
    //         //transform.LookAt(character);
    //         //Vector3 dir = (character.position - transform.position).normalized;
    //         //float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
    //         //transform.Rotate(0, angle, 0);
    //         //transform.Translate(Vector3.forward*-1*Time.deltaTime);
    //     //}
    // }

    void TakeDamage(int damage) {
        if (currentHealth - damage >= 0) {
            currentHealth -= damage;
        } else {
            currentHealth = 0;
        }
        hbs.SetHealth(currentHealth);
        ps_blood.Play();
    }

    public void setHealth(int health) {
        maxHealth = health;
        currentHealth = health;
    }

    void spawnDrops()
    {
        if (dropTable != null)
        {
            ArrayList dropList = dropTable.getLoot();

            //for (int i = 0; i < dropList.Count; i++)
            foreach (Loot l in dropList)
            { // iterate through the items in the dropList
                int spawnCount = l.count;

                for (int j = 0; j < spawnCount; j++)
                { // spawn item for each count of each item in dropList
                    Instantiate(l.drop, transform.position, Quaternion.identity);
                }
            }
        }
    }

    void Despawn() {
        dir.zombsTotal--;
        Destroy(zombie);
    }

    public void setDespawn(float des) {
        despawnTime = des;
    }

    public void setSpeed(float sp) {
        speed = sp;
    }
}
