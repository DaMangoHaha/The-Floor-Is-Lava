using UnityEngine;

public class PhysicalButton : MonoBehaviour
{
    public IceChunkTrigger iceChunkScript; // Reference to the ice chunk script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Popo"))
        {
            Debug.Log("Popo used neutral special!");
            iceChunkScript.SlideIce();
        }
    }
}

