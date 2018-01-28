using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Map");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
