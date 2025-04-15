using UnityEngine;

public class PlayCheeringSound : MonoBehaviour
{
    [Header("Cheering Sound")]
    public AudioSource cheerSource;
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        cheerSource = sources[1];
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Nana"))
        {
            if (cheerSource != null && !cheerSource.isPlaying)
            {
                cheerSource.Play();
            }
        }
    }
}

