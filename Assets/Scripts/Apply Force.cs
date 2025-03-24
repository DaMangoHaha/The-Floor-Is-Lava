using UnityEngine;

public class LaunchSphere : MonoBehaviour
{
    public float launchForce = 10f; // How strong the launch force is

    private void OnCollisionEnter(Collision collision)
    {
        // Checks if Popo has a Rigidbody
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply an upward force to Popo, sending him up
            rb.linearVelocity = Vector3.zero; // Resets Popo's velocity before applying force
            rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
        }
    }
}