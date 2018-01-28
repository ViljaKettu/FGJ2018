using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    private static GameObject gc;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (gc == null)
        {
            gc = transform.gameObject;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
}
