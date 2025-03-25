using UnityEngine;

public class LaunchPopoArc : MonoBehaviour
{
    public float launchForce = 10f; // Strength Popo flings at
    public float angle = 45f; // Angle Popo flings at

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        float radians = angle * Mathf.Deg2Rad;
        Vector3 launchDirection = new Vector3(Mathf.Cos(radians), Mathf.Sin(radians), 0);

        rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform")) // Make sure Platform is tagged properly
        {
            Launch(); // Launches Popo when hitting the platform
        }
    }
}

