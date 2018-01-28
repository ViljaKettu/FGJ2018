using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoController : MonoBehaviour
{
    public bool inUse = false, memoVisible;
    public GameObject memo, note;
    public InputField inputField;
    public PlayerMovement playerMovement;

    private static MemoController mc;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (mc == null)
        {
            mc = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

    void Start ()
    {
        inputField.ActivateInputField();
        memo.SetActive(false);
        note.SetActive(false);
        SetNoteText("TESTI! TOIMIIKO?");
    }

    void Update ()
    {
        if (inputField.isFocused)
        {
            if (inUse == false)
            {
                inputField.MoveTextEnd(true);
            }
            inUse = true;
        }
        else if (!inputField.isFocused)
        {
            inUse = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            inputField.ActivateInputField();
            inputField.MoveTextEnd(true);

            if (memoVisible == false)
            {
                note.SetActive(true);
                memo.SetActive(true);
                memoVisible = true;

                if (playerMovement != null)
                {
                    playerMovement.canMove = false;
                }
            }
            else if (memoVisible == true)
            {
                note.SetActive(false);
                memo.SetActive(false);
                memoVisible = false;

                if (playerMovement != null)
                {
                    playerMovement.canMove = true;
                }
            }
        }
    }

    public void SetNoteText(string txt)
    {
        note.GetComponentInChildren<Text>().text = txt;
    }

    public void FindPlayer()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        }
    }
}
