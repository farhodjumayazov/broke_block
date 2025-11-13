using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public GameObject gameOverUI; // <-- Qo‘shildi

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(1f, 1f).normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
            ScoreManager.instance.AddScore(1);
        }

        if (collision.gameObject.CompareTag("Bottom"))
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true); // <-- O‘sha joy o‘zgardi
        }
    }
}
