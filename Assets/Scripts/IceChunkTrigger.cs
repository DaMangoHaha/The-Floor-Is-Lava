using UnityEngine;

public class IceChunkTrigger : MonoBehaviour
{
    public Rigidbody iceRigidbody;
    public Vector3 slideDirection = new Vector3(-1, 0, 0);
    public float slideForce = 5f;

    void Start()
    {
        iceRigidbody.isKinematic = true; // Keeps ice chunk frozen at start
    }

    public void SlideIce()
    {
        iceRigidbody.isKinematic = false; // Enables physics which lets the ice chunk move
        iceRigidbody.AddForce(slideDirection * slideForce, ForceMode.Impulse);
    }
}
