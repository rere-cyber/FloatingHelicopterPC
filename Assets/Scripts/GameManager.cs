using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LaunchGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void LaunchMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
