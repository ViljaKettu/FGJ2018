using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewPackage : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Lose(3.0f));
    }

    IEnumerator Lose(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MenuScreen");
    }
}
