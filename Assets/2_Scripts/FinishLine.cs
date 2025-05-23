using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float delay = 2f;
    private ParticleSystem finishEffect;
    void Awake()
    {
        // 하위 오브젝트에서 FinishEffect 파티클 시스템을 찾음
        Transform effectTransform = transform.Find("FinishEffect");
        if (effectTransform != null)
        {
            finishEffect = effectTransform.GetComponent<ParticleSystem>();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player 완주");
            if (finishEffect != null)
            {
                finishEffect.Play();
            }
            Invoke(nameof(ClearReloadScene), delay);
        }
    }
    void ClearReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
