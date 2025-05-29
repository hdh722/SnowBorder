using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetecter : MonoBehaviour
{
    [SerializeField] private float delay = 1f;
    [SerializeField] private ParticleSystem crashEffect;
    [SerializeField] private AudioClip crashSound;
    private AudioSource audioSource;
    private PlayerController playerController;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playerController = GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Ãæµ¹");
            crashEffect.Play();
            audioSource.PlayOneShot(crashSound);
            Invoke(nameof(ReloadScene), delay);
            playerController.GameOver();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}