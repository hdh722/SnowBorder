using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]
    private float delay = 2f;
    private ParticleSystem finishEffect;
    void Awake()
    {
        // ���� ������Ʈ���� FinishEffect ��ƼŬ �ý����� ã��
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
            Debug.Log("player ����");
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
