using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControlScript : MonoBehaviour
{
    private Animator anim;
    public Transform character;
    public Transform zombie;
    //Vector3 move;
    Rigidbody rb;

    // Start is called before the first frame update
    private void Awake() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        anim.SetFloat("Blend", 0f);
        transform.LookAt(character);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(character.position, transform.position);
        print(distance);
        if (distance < 7) { //fight player
            transform.LookAt(character);
            anim.SetBool("Attacking", true);
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
        //if (character) {
            //transform.LookAt(character);
            //Vector3 dir = (character.position - transform.position).normalized;
            //float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            //transform.Rotate(0, angle, 0);
            //transform.Translate(Vector3.forward*-1*Time.deltaTime);
        //}
    }

}
