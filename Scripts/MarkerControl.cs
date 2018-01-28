using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MarkerControl : MonoBehaviour
{
    public SpriteRenderer locName, sr;
    public bool mouseOn = false;
    public bool player = false;

	void Start ()
    {
        locName.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player = true;
            sr.color = new Color(1f, 1f, 1f, 0.5f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sr.color = new Color(1f, 1f, 1f, 1f);
            player = false;
        }
    }

    void OnMouseEnter()
    {
        locName.enabled = true;
        mouseOn = true;
    }

    void OnMouseExit()
    {
        locName.enabled = false;
        mouseOn = false;
    }
}
