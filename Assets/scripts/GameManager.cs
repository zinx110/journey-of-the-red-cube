
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;



    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }



    public void Endgame()
    {
        if(gameEnded==false)
        {

            gameEnded = true;
            if (!completeLevelUI.active)
            {
                gameOverUI.SetActive(true);
                Invoke("Restart", restartDelay);    

            }
          
        }
    }

    void Restart()
    {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
