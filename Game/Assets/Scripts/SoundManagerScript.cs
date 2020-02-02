using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound, hitSound, pickupSound, winSound;
    static AudioSource audioSrc;

    void Awake()
    {
        hitSound = Resources.Load<AudioClip>("hit");
        jumpSound = Resources.Load<AudioClip>("jump");
        pickupSound = Resources.Load<AudioClip>("Pickup_Coin2");
        winSound = Resources.Load<AudioClip>("win");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "Pickup_Coin2":
                audioSrc.PlayOneShot(pickupSound);
                break;
            case "win":
                audioSrc.PlayOneShot(winSound);
                break;
        }
    }
}
