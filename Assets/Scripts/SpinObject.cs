using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.forward; // Rotate around Z-axis by default
    public float rotationSpeed = 100f; // Degrees per second

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}

