using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketSounds : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("Audio Clips")]
    public AudioClip enterSound;
    public AudioClip exitSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayEnterSound()
    {
        audioSource.PlayOneShot(enterSound);
    }

    public void PlayExitSound()
    {
        audioSource.PlayOneShot(exitSound);
    }
}
