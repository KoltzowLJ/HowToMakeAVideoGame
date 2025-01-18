using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void GameOver () {

        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            // Restart();
            Invoke(nameof(Restart), restartDelay);
        }
    }

    void Restart () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() {
        // Debug.Log("Level Won!");
        completeLevelUI.SetActive(true);
    }
}
