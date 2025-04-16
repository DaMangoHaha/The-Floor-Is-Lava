using UnityEngine;
using TMPro;
using System.Collections;

public class WingdingMessage : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public string wingdingMessage = "ENTRY_NUMBER_1\n\n" +
        "IS THIS THING ON? I CAN'T TELL." +
        "\n\nPOPO HAS BEEN SEPERATED FROM NANA." +
        "\n\nWE NEED TO KEEP IT THIS WAY."; // Replace with your actual message
    public float delay = 0.2f;
    public AudioSource audioSource;
    public AudioClip[] typeSounds; // Drag your 7 sounds here

    void Start()
    {
        StartCoroutine(RevealMessage());
    }

    IEnumerator RevealMessage()
    {
        messageText.text = "";

        foreach (char c in wingdingMessage)
        {
            messageText.text += c;

            // Play a random sound from the array
            if (typeSounds.Length > 0)
            {
                AudioClip clip = typeSounds[Random.Range(0, typeSounds.Length)];
                audioSource.PlayOneShot(clip);
            }

            yield return new WaitForSeconds(delay);
        }

        yield return new WaitForSeconds(1.5f);

        // Simulate game crash
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
