using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnimScript : MonoBehaviour
{
    public AudioClip DamageClip;
    [Range(0, 1)] public float DamageVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAttack(AnimationEvent animationEvent)
    {
        AudioSource.PlayClipAtPoint(DamageClip, transform.position, DamageVolume);
    }
}
