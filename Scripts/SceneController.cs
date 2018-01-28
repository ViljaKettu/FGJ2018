using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public GameObject[] people;
    public Vector3[] locs;
    public string[] names;
    SoundManager sound;

    public GameObject convBox;
    public string activePerson;
    public Text txt;
    public bool inConversation = false;

    void Start ()
    {
        people = GameObject.FindGameObjectsWithTag("People");
        convBox = GameObject.FindGameObjectWithTag("ConvBox");

        for (int i = 0; i < people.Length; i++)
        {
            locs[i] = people[i].transform.position;
        }

        txt = convBox.GetComponentInChildren<Text>();
        convBox.SetActive(false);
    }

    public void ActivateConversation(GameObject go, string line, string n)
    {
        inConversation = true;
        convBox.SetActive(true);
        activePerson = n;

        foreach(GameObject gm in people)
        {
            if(gm != go)
            {
                gm.SetActive(false);
            }
        }

        go.transform.position = new Vector3(-3.5f, -5f, 90f);
        go.transform.localScale = new Vector2(2, 2);
        txt.text = line;
    }

    public void CheckPerson()
    {
        if(activePerson == names[0])
        {
            txt.text = "CORRECT!!";
            sound.PlayCorrect();
            StartCoroutine(Wait(3.0f));
        }
        else
        {
            txt.text = "ERROR!!";
            sound.PlayWrong();
        }
    }

    public void ExitConversation()
    {
        inConversation = false;
        convBox.SetActive(false);

        for (int i = 0; i < people.Length; i++)
        {
            people[i].SetActive(true);
            people[i].transform.position = locs[i];
            people[i].transform.localScale = new Vector2(1, 1);
        }
    }

    IEnumerator Wait(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("SoundTEST");
    }
}
