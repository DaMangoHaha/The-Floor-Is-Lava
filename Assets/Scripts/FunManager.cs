using UnityEngine;
using UnityEngine.SceneManagement;

public class FunManager : MonoBehaviour
{
    public static int FUN { get; private set; }

    void Awake()
    {
        FUN = Random.Range(1, 6); // 1 to 5 inclusive

        Debug.Log("FUN Value: " + FUN);

        if (FUN == 3)
        {
            SceneManager.LoadScene("DarkRoom"); // Make sure this scene is added to Build Settings
        }
    }
}

