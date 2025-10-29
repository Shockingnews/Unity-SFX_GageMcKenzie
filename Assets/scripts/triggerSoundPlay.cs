using UnityEngine;

public class triggerSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        audioSource.UnPause();
    }
    
}
