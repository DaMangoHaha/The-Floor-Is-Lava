using UnityEngine;

public class LaunchSphere : MonoBehaviour
{
    public float launchForce = 10f; // Adjust force for desired strength
    public float angle = 45f; // Launch angle in degrees

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        // Convert the angle to radians and calculate the direction
        float radians = angle * Mathf.Deg2Rad;
        Vector3 launchDirection = new Vector3(Mathf.Cos(radians), Mathf.Sin(radians), 0);

        // Apply force to launch the sphere in an arc
        rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
    }
}
