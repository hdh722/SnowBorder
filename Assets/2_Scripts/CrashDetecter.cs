using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetecter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Ãæµ¹");
            SceneManager.LoadScene(0);
        }
    }
}
