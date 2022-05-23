using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip playerHitSound, jumpSound, enemyDeathSound, itemPickSound;
    static AudioSource audioSrc;

    public static AudioManager Instance { get; set; }
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip> ("hit");
        jumpSound = Resources.Load<AudioClip> ("jump");
        enemyDeathSound = Resources.Load<AudioClip> ("enemyDeath");
        itemPickSound = Resources.Load<AudioClip> ("itemPick");
    }

    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;
            case "itemPick":
                audioSrc.PlayOneShot(itemPickSound);
                break;

        }
    }
}
