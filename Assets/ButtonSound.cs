using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;  
    public AudioClip sound;

    public void PlaySound()
    {
        if (audioSource != null && sound != null)
        {
            audioSource.PlayOneShot(sound);
        }
        else
        {
            Debug.LogWarning("AudioSource o AudioClip no están asignados");
        }
    }
}
