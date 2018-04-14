using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;
   

    void Awake()
    {
        if (instance != null)
        {
            Destroy (gameObject);
            Debug.Log("Dups destroyed");
        }

        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}