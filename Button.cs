using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Exit._nextLevelIndex = 0;

    }
    public void Return() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Exit._nextLevelIndex = 0;
    }
}