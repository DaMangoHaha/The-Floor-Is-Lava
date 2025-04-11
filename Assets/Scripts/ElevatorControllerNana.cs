using UnityEngine;

public class ElevatorControllerNana : MonoBehaviour
{
    [Header("Elevator Settings (Nana)")]
    public Transform bottomPoint;      // The destination (bottom floor)
    public float speed = 2f;           // Move speed
    private bool moveDown = false;

    private void Update()
    {
        if (moveDown)
        {
            // Smoothly move toward the bottom point
            transform.position = Vector3.MoveTowards(transform.position, bottomPoint.position, speed * Time.deltaTime);
        }
    }

    public void StartElevator()
    {
        moveDown = true;
    }
}