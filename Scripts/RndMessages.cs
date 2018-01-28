using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public class RndMessages : MonoBehaviour
{
    string[] texts = new string[] {"Kissa syö kalaa", "Koira syö lihaa", "Marsu syö kurkkua" };
    string[] texts2 = new string[] { ", joka on siitä hyvää. ", ", joka on siitä pahaa. ", ", joka on siitä älyttömän hyvää. " };
    string[] texts3 = new string[] { " Se tykkää silityksistä.", " Se ei tykkää silityksistä.", " Se rakastaa silityksiä." };
    string[] seperators = { ",", ".", "!", "?", ";", ":", " " };
    string[] textSplit;
    List<string> words;

    string message;
    string encryptedMessage;

    string currentText;
    string currentText2;
    string currentText3;
    
    public Text writeOut;

    private void Start()
    {

        currentText = texts[UnityEngine.Random.Range(0, texts.Length)];
        currentText2 = texts2[UnityEngine.Random.Range(0, texts.Length)];
        currentText3 = texts3[UnityEngine.Random.Range(0, texts.Length)];

        message = currentText + currentText2 + currentText3;

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
