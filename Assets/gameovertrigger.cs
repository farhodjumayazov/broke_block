using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public GameObject gameOverText;   // Hierarchy'dagi GameOverText (TMP)
    public GameObject restartButton;  // agar restart tugma bo'lsa (optional)

    void Start()
    {
        // O'yin boshlanganda aniq game over yozuvi yashiringan bo'lsin
        if (gameOverText != null)
            gameOverText.SetActive(false);

        if (restartButton != null)
            restartButton.SetActive(false);

        // Vaqt normal bo'lsin (agar oldingi sahifa 0 qilib qoldirilgan bo'lsa)
        Time.timeScale = 1f;
    }

    // Agar siz colliders bilan "Is Trigger" o'rnatgan bo'lsangiz foydalaning:
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BottomWall"))
            TriggerGameOver();
    }

    // Agar siz oddiy collision (Is Trigger o'chirilgan) ishlatgan bo'lsangiz foydalaning:
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BottomWall"))
            TriggerGameOver();
    }

    void TriggerGameOver()
    {
        // O'yinni to'xtatish
        Time.timeScale = 0f;

        // Matn va tugmani ko'rsatish
        if (gameOverText != null)
            gameOverText.SetActive(true);

        if (restartButton != null)
            restartButton.SetActive(true);
    }

    // Restart tugmasi uchun public funksiya
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
