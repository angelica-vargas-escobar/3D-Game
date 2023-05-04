using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;

    bool gameHasEnded = false;  // flag that says whether the game has ended

    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
    //        Invoke("Restart", 2f);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteGame() {
        gameHasEnded = true;
        levelCompleteUI.SetActive(true);
        Debug.Log("LEVEL COMPLETE");
//        Invoke("LoadNextLevel", 2f);
    }

  /*  void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
*/
}
