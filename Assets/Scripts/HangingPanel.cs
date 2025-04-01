using UnityEngine;

public class HangingPanel : MonoBehaviour
{
    private Rigidbody rb;
    public float swingForce = 10f; // Increase if needed
    public Color newColor = Color.red;

    private Renderer panelRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody
        panelRenderer = GetComponent<Renderer>(); // Get Renderer
    }

    private void OnTriggerEnter(Collider other) // Use OnTriggerEnter for trigger-based detection
    {
        if (other.CompareTag("Popo")) // Ensure Sphere has the correct tag
        {
            panelRenderer.material.color = newColor; // Change panel color
            rb.AddTorque(Vector3.forward * swingForce, ForceMode.Impulse); // Apply rotational force
            Debug.Log("Panel triggered! Changing color.");
        }
    }
}
