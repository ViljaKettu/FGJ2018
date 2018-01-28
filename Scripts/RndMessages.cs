using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public class RndMessages : MonoBehaviour
{
    string[] texts = new string[] { "Prom king<b>and his queen; In the shadow of<b>a bonsai tree;<b>Arigatou gozaimasu ",
        "Deliver me<b>to the garden<b>surrounded by angels; You might<b>get lucky, but nothing<b>is free; Take me<b>down where<b>the grass is green ",
        "Nature calls, pants fall; They won't<b>let me<b>to the mall; Ask her, I have<b>barely drunk<b>at all ", "Don't you<b>know who<b>I am? Odds are<b>you do " };
    string[] persons = new string[] {"pastori", "weeb", "puliukko", "puliakka", "poliisi", "guido", "seurapiirijulkkis", "perusmuija" };
    string[] seperators = { ",", ".", "!", "?", ";", ":", "<b>" };
    string[] textSplit;
    List<string> words;

    public string person;

    string message;
    string encryptedMessage;

    string currentText;
    string currentText2;
    string currentText3;
    
    public Text writeOut;

    private void Start()
    {
        message = texts[UnityEngine.Random.Range(0, texts.Length)];

        if(message == texts[0])
        {
            person = persons[1];
        }

        else if (message == texts[1])
        {
            person = persons[0];
        }

        else if (message == texts[2])
        {
            person = persons[2];
        }
        else if (message == texts[3])
        {
            person = persons[6];
        }

        EncryptMessage();

        writeOut.text = message;
        writeOut.text = encryptedMessage;
    }

    void EncryptMessage()
    {
        textSplit = message.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        Debug.Log(message);
        words = textSplit.ToList();

        for (int i = 0; i < words.Count; i++)
        {
            string temp = words[i];
            int randomIndex = UnityEngine.Random.Range(i, words.Count);
            words[i] = words[randomIndex];
            words[randomIndex] = temp;
            encryptedMessage += words[i] + " ";
        }

        //for (int i = 0; i < textSplit.Length; i++)
        //{
        //    Debug.Log(textSplit[i]);

        //}
        //Debug.Log(textSplit[UnityEngine.Random.Range(0, textSplit.Length)]);

        //foreach (string i in textSplit)
        //{     
        //    encryptedMessage += textSplit[UnityEngine.Random.Range(0, textSplit.Length)] + " ";
        //}
    }
}
