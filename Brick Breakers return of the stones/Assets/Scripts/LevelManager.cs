using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Start_Game()
    {
        SceneManager.LoadScene("Level_01");
    }

    public void Level_sel()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
}
