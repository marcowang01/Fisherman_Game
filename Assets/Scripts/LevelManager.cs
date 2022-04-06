using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 2f;
    [SerializeField] bool spaceIsPressed = false;
    ScoreKeeper scoreKeeper;
    
    void Update() {
        if (Input.GetKey("space")) {
            spaceIsPressed = true;
        }

        if (spaceIsPressed) {
            LoadGame();
        }
    }

    public void LoadGame()
    {
            SceneManager.LoadScene(1);
            scoreKeeper = FindObjectOfType<ScoreKeeper>();
        
        
    }

    public void LoadMainMenu()
    {
        scoreKeeper.ResetScore();
        SceneManager.LoadScene(0);
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad((0), sceneLoadDelay));
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    IEnumerator WaitAndLoad(int sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

}
