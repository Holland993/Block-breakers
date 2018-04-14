using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
    public int maxHits;
    private int timesHit;

    // Use this for initialization
    void Start()
    {
        timesHit = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        timesHit++;
        if (timesHit == maxHits)
        {
            Destroy(gameObject);
        }
    }

    void SimulateWin()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
