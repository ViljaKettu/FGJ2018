using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset, minCameraPos, maxCameraPos;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update ()
    {
        transform.position = player.transform.position;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
            Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
            Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
	}
}
