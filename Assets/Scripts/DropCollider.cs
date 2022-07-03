using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCollider : MonoBehaviour
{
    [SerializeField]
    public AudioSource[] sounds; // list of AudioSources to play sound from (optional -- polish)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision c) {
        if (c.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            if (sounds != null)
            {
                AudioSource collectSound = sounds[0];
                collectSoundprop.Play();
            }
        }
        else {
            if (sounds != null) {
                AudioSource collideSound = sounds[1];
                collideSound.Play();
            }
        }
    }
}
