using UnityEngine;

public class DebugScoreDisplay : MonoBehaviour
{
    void OnGUI()
    {
        if (ScoreManager.instance != null)
        {
            int s = ScoreManager.instance.GetScore();
            GUIStyle style = new GUIStyle();
            style.fontSize = 16;
            style.normal.textColor = Color.white;
            GUI.Label(new Rect(10, 10, 300, 50), "Score (GUI): " + s, style);
        }
    }
}

