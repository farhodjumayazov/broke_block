using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // majburan UI elementni faollashtirish va ko'rsatish
        if (scoreText != null)
        {
            scoreText.gameObject.SetActive(true);
            scoreText.canvasRenderer.SetAlpha(1f);
            scoreText.color = Color.white;
            scoreText.fontSize = 10;
            // UI elementni Canvas ichida oxirgi qilib qo'yamiz (eng ustda bo'ladi)
            scoreText.transform.SetAsLastSibling();
        }
        UpdateScoreText();
        Debug.Log("ScoreManager ishga tushdi, Score: " + score);
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
        else
            Debug.LogWarning("ScoreText null!");
    }

    public int GetScore() { return score; }
}
