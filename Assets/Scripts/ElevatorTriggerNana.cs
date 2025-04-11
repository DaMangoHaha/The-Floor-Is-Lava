using UnityEngine;

public class ElevatorTriggerNana : MonoBehaviour
{
    public ElevatorControllerNana elevator; // Reference to Nana's ElevatorController script script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nana"))
        {
            elevator.StartElevator(); // Tells the elevator to move
        }
    }
}
