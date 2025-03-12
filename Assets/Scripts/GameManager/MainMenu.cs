using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MenuGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void playGame()
    {
        SceneManager.LoadScene("Game");
    }
}
