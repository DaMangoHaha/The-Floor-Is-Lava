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
        if (collision.gameObject.CompareTag("Ice Chunk")) // Check if the ice hits the domino
        {
            audioSource.Play(); // Plays sound when the ice knocks into the domino
        }
    }
}

