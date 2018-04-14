using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    #region Level Select Methods
    public void Level_1()
    {
        SceneManager.LoadScene("Level_01", LoadSceneMode.Single);
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Level_02", LoadSceneMode.Single);
    }

    public void Level_3()
    {
        Debug.Log("Show 3");
    }

    public void Level_4()
    {
        Debug.Log("Show 4");
    }

    public void Level_5()
    {
        Debug.Log("Show 5");
    }

    public void Level_6()
    {
        Debug.Log("Show 6");
    }

    public void Level_7()
    {
        Debug.Log("Show 7");
    }

    public void Level_8()
    {
        Debug.Log("Show 8");
    }

    public void Level_9()
    {
        Debug.Log("Show 9");
    }

    public void Level_10()
    {
        Debug.Log("Show 10");
    }

    public void Level_11()
    {
        Debug.Log("Show 11");
    }

    public void Level_12()
    {
        Debug.Log("Show 12");
    }

    public void Level_13()
    {
        Debug.Log("Show 13");
    }

    public void Level_14()
    {
        Debug.Log("Show 14");
    }

    public void Level_15()
    {
        Debug.Log("Show 15");
    }

    public void Level_16()
    {
        Debug.Log("Show 16");
    }

    public void Level_17()
    {
        Debug.Log("Show 17");
    }

    public void Level_18()
    {
        Debug.Log("Show 18");
    }

    public void Level_19()
    {
        Debug.Log("Show 19");
    }

    public void Level_20()
    {
        Debug.Log("Show 20");
    }

    public void Level_21()
    {
        Debug.Log("Show 21");
    }

    public void Level_22()
    {
        Debug.Log("Show 22");
    }

    public void Level_23()
    {
        Debug.Log("Show 23");
    }

    public void Level_24()
    {
        Debug.Log("Show 24");
    }

    public void Level_25()
    {
        Debug.Log("Show 25");
    }

    public void Level_26()
    {
        Debug.Log("Show 26");
    }
    #endregion

    public void Cancel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
