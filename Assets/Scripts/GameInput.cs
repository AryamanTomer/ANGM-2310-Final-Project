using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameInput : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        // When we press Backspace, reload the level
        if(Input.GetKeyDown(KeyCode.Backspace)){
            // reload level
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentLevelIndex);
        }
        // When we press Escape, exit the game
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit the game");
            //exit the game
            Application.Quit();
        }
    }
}
