using UnityEngine;

public class HangingPanel : MonoBehaviour
{
    private Rigidbody rb;
    public float swingForce = 10f;
    public Color newColor = Color.red;

    private Renderer panelRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        panelRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Popo"))
        {
            panelRenderer.material.color = newColor;

            Vector3 forceDirection = transform.right * swingForce;
            rb.AddTorque(forceDirection, ForceMode.Impulse);

            Debug.Log("Panel triggered! Changing color & swinging.");
        }
    }
}
