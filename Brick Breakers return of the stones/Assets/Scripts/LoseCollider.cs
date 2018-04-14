using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    public Game_Manager game_Manager;
    private LevelManager level;

	void OnTriggerEnter2D (Collider2D trigger)
    {
        if (GetComponent<Collider2D>().tag == "Loser")
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }

    void SimulateLose()
    {
        SceneManager.LoadScene("Lose");
    }
}
