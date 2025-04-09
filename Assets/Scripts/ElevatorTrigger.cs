using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    public ElevatorController elevator; // Reference to the ElevatorController script

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Popo"))
        {
            elevator.StartElevator(); // Tells the elevator to move
        }
    }
}
