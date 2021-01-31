using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class AudioController
{
    public enum Sound
    {

        Playerwalk,
        Attack,
        Jump,
        shoot,
        finishlvl,
        tragaperras,

    }

    public static void PlaySound(Sound sound)
    {

        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));

    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (audioManager.SoundAudioClip soundAudioClip in audioManager.i.soundAudioArray)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioC;

            }
        }
        Debug.LogError("Sound" + sound + "not found");
        return null;


    }
}*/
