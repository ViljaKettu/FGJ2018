using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnLoad : MonoBehaviour
{

    private void Awake()
    {
        DestroyObjectDelayed();
    }

    public void DestroyObjectDelayed()
    {
        Destroy(gameObject, 3);
    }

}
