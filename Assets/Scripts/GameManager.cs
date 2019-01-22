using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gameOver = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;


    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
            
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   public void Win()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Won Level");
        EndGame();
    }
}
