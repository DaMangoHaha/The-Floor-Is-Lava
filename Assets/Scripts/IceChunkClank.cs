using UnityEngine;

public class IceChunkClank : MonoBehaviour
{
    [Header("Clank Sound")]
    public AudioSource clankSource;
    void Start()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        clankSource = sources[0];
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Domino"))
        {
            if (clankSource != null && !clankSource.isPlaying)
            {
                clankSource.Play();
            }
        }
    }
}