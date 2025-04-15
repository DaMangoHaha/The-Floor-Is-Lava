using UnityEngine;

public class PopoShuffle : MonoBehaviour
{
    [Header("Shuffle Sound")]
    public AudioSource shuffleSource;
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        shuffleSource = sources[2];
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Popo"))
            if (shuffleSource != null && !shuffleSource.isPlaying)
            {
                shuffleSource.Play();
            }
        }
    }

