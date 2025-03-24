using UnityEngine;

public class HammerSwing : MonoBehaviour
{
    public float swingForce = 500f;
    private bool hasSwung = false;  // Makes sure the hammer swings ONCE

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the hammer hits Popo
        if (collision.gameObject.CompareTag("Popo") && !hasSwung)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddTorque(Vector3.forward * swingForce, ForceMode.Impulse);
                hasSwung = true; // Prevents multiple swings
            }
        }
    }
}

