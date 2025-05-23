using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetecter : MonoBehaviour
{
    [SerializeField] private float delay = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Ãæµ¹");
            Invoke(nameof(ReloadScene), delay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}