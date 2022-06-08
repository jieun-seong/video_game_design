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

    }

    // Update is called once per frame
    void Update()
    {
        if (character) {
            transform.LookAt(character);
            Vector3 dir = (character.position - transform.position).normalized;
            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            transform.Rotate(0, angle, 0);
            transform.Translate(Vector3.forward*-1*Time.deltaTime);
        }
    }

}
