using UnityEngine;

public class PlayNanaCheer : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Popo"))
        {
            if (cheerSource != null && !cheerSource.isPlaying)
            {
                cheerSource.Play();
            }
        }
    }
}
