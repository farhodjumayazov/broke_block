using UnityEngine;
using UnityEngine.InputSystem; // yangi tizim

public class PlatformController : MonoBehaviour
{
    public float speed = 10f;
    private float moveInput;

    void Update()
    {
        moveInput = Keyboard.current.leftArrowKey.isPressed ? -1 :
                    Keyboard.current.rightArrowKey.isPressed ? 1 : 0;

        transform.Translate(Vector2.right * moveInput * speed * Time.deltaTime);
    }
}
