using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    public LaunchSphere sphereScript; // Reference to Popo's Launch script

    private void OnCollisionEnter(Collision collision)
    {
        // Check if Popo has collided with the platform
        if (collision.gameObject.CompareTag("Popo"))
        {
            // Trigger the launch when Popo collides with the platform
            sphereScript.Launch();
        }
    }
}

