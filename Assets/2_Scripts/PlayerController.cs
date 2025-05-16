using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 3f;
    private enum InputKey
    {
        None, Left, Right
    }
    private InputKey currentKey = InputKey.None;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        currentKey = Input.GetKey(KeyCode.LeftArrow) ?
            InputKey.Left :
            Input.GetKey(KeyCode.RightArrow) ? InputKey.Right : InputKey.None;
            ;
    }
    private void FixedUpdate()
    {
        switch(currentKey)
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
    }
}
