using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimScript : MonoBehaviour
{
    public AudioClip[] FootstepAudioClips;
    [Range(0, 1)] public float FootstepAudioVolume = 1f;

    public AudioClip DamageClip;
    [Range(0, 1)] public float DamageVolume = 1f;

    public AudioClip DaggerClip;
    [Range(0, 1)] public float DaggerVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnFootstep(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > 0.5f)
        {
            if (FootstepAudioClips.Length > 0)
            {
                var index = Random.Range(0, FootstepAudioClips.Length);
                AudioSource.PlayClipAtPoint(FootstepAudioClips[index], transform.position, FootstepAudioVolume);
            }
        }
    }

    private void OnPunch(AnimationEvent animationEvent)
    {
        AudioSource.PlayClipAtPoint(DamageClip, transform.position, DamageVolume);
    }

    private void OnSwing(AnimationEvent animationEvent)
    {
        AudioSource.PlayClipAtPoint(DaggerClip, transform.position, DaggerVolume);
    }
}
