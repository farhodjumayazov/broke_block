using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonHandler : MonoBehaviour
{
    // Bu funksiya Button -> OnClick() ga ulanganda sahnani yuklaydi
    public void OnRestartButtonPressed()
    {
        Debug.Log("RestartButtonHandler: OnRestartButtonPressed called");
        // Agar Time.timeScale 0 bo'lsa, uni 1 ga qaytaramiz
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
