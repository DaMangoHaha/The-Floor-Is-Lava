using UnityEngine;

public class PlayCheeringSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Gets the AudioSource attached to this object
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Checks if the object Popo collided with Nana
        if (collision.gameObject.CompareTag("Popo"))
        {
            // Play the cheering sound
            audioSource.Play();
        }
    }
}

