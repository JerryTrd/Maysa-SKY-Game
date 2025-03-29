using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ShowCursor();
            SceneManager.LoadScene(2); 
        }
    }

    public void RestartGame()
    {
        ShowCursor();
        SceneManager.LoadScene(1); 
    }

    public void MainMenu()
    {
        ShowCursor();
        SceneManager.LoadScene(0); 
    }

    private void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

