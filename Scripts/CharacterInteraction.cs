using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterInteraction : MonoBehaviour
{
    public SpriteRenderer charSprite;
    public SceneController sceneCtrl;
    public string[] lines;
    public Sprite[] sprites;
    public string myName;

    //TESTI
    public bool mouseOver, clicked;

    void Start ()
    {
        sceneCtrl = GameObject.FindGameObjectWithTag("SceneCtrl").GetComponent<SceneController>();
        myName = transform.name;
	}

    private void OnMouseEnter()
    {
        if (sceneCtrl.inConversation == false)
        {
            charSprite.sprite = sprites[1];
        }
    }

    private void OnMouseExit()
    {
        if (sceneCtrl.inConversation == false)
        {
            charSprite.sprite = sprites[0];
        }
    }

    private void OnMouseUp()
    {
        if (sceneCtrl.inConversation == false)
        {
            clicked = true;
            charSprite.sprite = sprites[0];

            sceneCtrl.ActivateConversation(transform.gameObject, lines[UnityEngine.Random.Range(0, lines.Length)], myName);
        }
    }
}
