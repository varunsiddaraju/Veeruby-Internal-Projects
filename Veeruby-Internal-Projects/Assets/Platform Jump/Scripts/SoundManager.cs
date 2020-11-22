using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager  instance;

    public AudioSource SoundFX;

    [SerializeField]
    AudioClip landClip, deathClip, breakClip, gameOverClip;

    void Awake()
    {
        if (instance == null)
            instance = this;
        
    }

   public void LandClip()
    {
        SoundFX.clip = landClip;
        SoundFX.Play();
    }

    public void DeathClip()
    {
        SoundFX.clip = deathClip;
        SoundFX.Play();
    }

    public void BreakClip()
    {
        SoundFX.clip = breakClip;
        SoundFX.Play();
    }

    public void GameOverClip()
    {
        SoundFX.clip = gameOverClip;
        SoundFX.Play();
    }


}
