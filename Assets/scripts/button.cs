using UnityEngine;

public class button : MonoBehaviour
{
    public AudioSource audioSource;
    static bool isoff = false;
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        if (isoff == false)
        {
            
            audioSource.UnPause();
            isoff = true;
        }
        else if (isoff == true)
        {
            audioSource.Pause();
            isoff = false;
        }

    }
    
}
