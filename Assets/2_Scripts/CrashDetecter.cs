using UnityEngine;
public class CrashDetecter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Ãæµ¹");
        }
    }
}
