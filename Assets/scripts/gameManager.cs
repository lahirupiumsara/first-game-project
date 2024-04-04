 
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public void GameOver()
    {
        if (gameHasEnded == false)
        { 
        gameHasEnded = true;
        Debug.Log("Game Over");
            Invoke("Restart",1f);
         }
    }

    void Restart ()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }
}
