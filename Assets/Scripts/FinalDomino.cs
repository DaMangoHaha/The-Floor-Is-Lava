using UnityEngine;

public class FinalDomino : MonoBehaviour
{
    public Rigidbody sphereToLaunch;
    public float launchForce = 10f;
    public Vector3 launchDirection = new Vector3(1, 1, 0);
    public AudioSource launchSound;

    private bool hasLaunched = false; // Prevent multiple launches

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Domino") && !hasLaunched)
        {
            LaunchSphere();
            hasLaunched = true;
        }
    }

    private void LaunchSphere()
    {
        if (sphereToLaunch != null)
        {
            sphereToLaunch.isKinematic = false; // Enables physics
            sphereToLaunch.AddForce(launchDirection.normalized * launchForce, ForceMode.Impulse);

            // Play launch sound
            if (launchSound != null)
            {
                launchSound.Play();
            }
            Debug.Log("Nana's blasting off again!");
        }
    }
}

