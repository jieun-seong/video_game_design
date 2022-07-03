using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieControlScript : MonoBehaviour
{
    private Animator anim;
    public Transform character;
    public GameObject zombie;
    Rigidbody rb;
    public GameObject healthBar;
    private int maxHealth = 100;
    private int currentHealth;
    private HealthBarScript hbs;
    private float attackTime = 0f;
    private float deathTime = 0f;
    public LootTable dropTable;

    // Start is called before the first frame update
    private void Awake() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        hbs = healthBar.GetComponent<HealthBarScript>();
    }
    void Start()
    {
        anim.SetFloat("Blend", 0f);
        transform.LookAt(character);
        currentHealth = maxHealth;
        hbs.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update() {
        healthBar.transform.position = transform.position + new Vector3(0f,9f,0f);
        float distance = Vector3.Distance(character.position, transform.position);
        if (currentHealth == 0 && !anim.GetBool("Dead")) {
            anim.SetBool("Dead", true);
            deathTime = Time.time;
            //Destroy(zombie);
        }
        if (anim.GetBool("Dead") && Time.time > deathTime + 6.5) {
            Destroy(zombie); // destroy after playing death animation
            spawnDrops(); // drop items after the death animation and 
        } else if (distance < 5) { //fight player
            if (Input.GetKeyDown(KeyCode.Q) && Time.time > attackTime + 2.0) {
                attackTime = Time.time;
                TakeDamage(20);
            }
        }
    }
    void FixedUpdate()
    {
        if (!anim.GetBool("Dead")) {
            float distance = Vector3.Distance(character.position, transform.position);
            if (distance < 5) { //fight player
                //transform.LookAt(character);
                anim.SetBool("Attacking", true);
                // if (Input.GetKeyDown(KeyCode.Q)) {
                //     TakeDamage(20);
                // }
            } else if (distance < 30) { // make zombie go towards player fast
                anim.SetBool("Attacking", false);
                transform.position = Vector3.MoveTowards(transform.position, character.position, 2.0f * Time.deltaTime);
                transform.LookAt(character.position);
                anim.SetFloat("Blend", 1f);
            } else if (distance < 50) { // make zombie go towards player slowly
                distance = distance - 30;
                distance = 1.0f - (distance / 20.0f);
                transform.position = Vector3.MoveTowards(transform.position, character.position, (distance*2.0f) * Time.deltaTime);
                transform.LookAt(character.position);
                anim.SetFloat("Blend", distance);
            } else { // zombie stand still
                anim.SetFloat("Blend", 0f);
                transform.LookAt(character);
            }
        }
        //if (character) {
            //transform.LookAt(character);
            //Vector3 dir = (character.position - transform.position).normalized;
            //float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            //transform.Rotate(0, angle, 0);
            //transform.Translate(Vector3.forward*-1*Time.deltaTime);
        //}
    }

    void TakeDamage(int damage) {
        if (currentHealth - damage >= 0) {
            currentHealth -= damage;
        } else {
            currentHealth = 0;
        }
        hbs.SetHealth(currentHealth);
    }

    void spawnDrops() {
        if (dropTable != null) {
            ArrayList dropList = dropTable.getLoot();

            for (int i = 0; i < dropList.Count; i++) { // iterate through the items in the dropList
                int spawnCount = dropList[i].Count;

                for (int j = 0; j < spawnCount; j++) { // spawn item for each count of each item in dropList
                    Instantiate(dropList[i].drop, transform.position, Quaternion.identity);
                }
            }
        }
    }

}
