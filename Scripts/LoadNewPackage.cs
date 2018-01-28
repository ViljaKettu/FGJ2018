using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewPackage : MonoBehaviour
{
    public GameObject package = null;
    DestroyOnLoad image;

    private void Start()
    {
        GameObject clone = (GameObject)Instantiate(package, transform.position, Quaternion.identity);
        Destroy(clone, 3.0f);
    }
}
