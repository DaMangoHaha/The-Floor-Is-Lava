using UnityEngine;

public class PlaySoundClank : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Popo")) // Check if Popo hits the domino
        {
            audioSource.Play(); // Plays sound when Popo knocks into the domino
        }
    }
}

