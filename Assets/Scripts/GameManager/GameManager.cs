using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    void Update()
    {
        
    }

    public void addScore(int point)
    {
        score += point;
        scoreText.text = "Your Score: " + score.ToString();
    }
}
