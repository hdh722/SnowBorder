using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 3f;
    Rigidbody2D rb2d;
    private SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float basespeed = 20f;
    [SerializeField] float boostspeed = 30f;
    private bool isBoosting = false;
    private bool isRunning = true;

    private enum InputKey
    {
        None, Left, Right
    }
    private InputKey currentKey = InputKey.None;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
    }
    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;
        
        isBoosting = Input.GetKey(KeyCode.UpArrow);
    }
    public void GameOver()
    {
        isRunning = false;
    }
    private void FixedUpdate()
    {
        if (!isRunning) return;
        switch (currentKey)
        {
            case InputKey.Left:
                rb2d.AddTorque(torqueAmount);
                break;
            case InputKey.Right:
                rb2d.AddTorque(-torqueAmount);
                break;
            default:
                //do nothing
                break;
        }
        surfaceEffector2D.speed = isBoosting ? boostspeed : basespeed;
    }
}
