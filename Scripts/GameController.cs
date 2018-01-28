using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private static GameController gc;
    public Vector2 lastLoc = new Vector2(0,0);
    public GameObject player;

    void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);

        if(gc == null)
        {
            gc = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
	}

    public void SetReturnLocation(Vector2 newLoc)
    {
        lastLoc = newLoc;
    }

	public Vector2 SetPlayerLocation()
    {
        return lastLoc;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
