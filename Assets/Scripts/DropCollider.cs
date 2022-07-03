using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollider : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision c) {
        if (c.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        // else some other actions
    }
}
