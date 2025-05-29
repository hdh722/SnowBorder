using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float delay = 2f;
    [SerializeField]
    private ParticleSystem finishEffect;
    private AudioSource audioSource;
    private bool isFinished = false;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isFinished)
        {
            Debug.Log("player øœ¡÷");
            isFinished = true;
            finishEffect.Play();
            audioSource.Play();
            Invoke(nameof(ClearReloadScene), delay);
        }
    }
    void ClearReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
