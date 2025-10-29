using UnityEngine;
using UnityEngine.Audio;

public class TriggerSoundPause : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Pause();
    }
}
