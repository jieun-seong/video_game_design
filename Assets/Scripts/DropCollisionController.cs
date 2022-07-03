using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollisionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            // play collecting sound
        }
        else
        {
            // other normal behavior (ex. play sound for bouncing)
        }
    }
}