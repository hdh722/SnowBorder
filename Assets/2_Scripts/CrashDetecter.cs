using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetecter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("�浹");
            SceneManager.LoadScene(0);
        }
    }
}
