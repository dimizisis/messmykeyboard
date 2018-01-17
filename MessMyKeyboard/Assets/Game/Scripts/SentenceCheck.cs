using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class SentenceCheck : MonoBehaviour
{

    public Text sentence;
    public Text answer;
    public Text error;
    string randomSentence;
    public static bool isAcceptable;
    public static int answerLength;
    private List<int> selectNums = new List<int>();

    public void SelectWord()
    {
        int num = UnityEngine.Random.Range(0, SentenceDictionary.sentences.Length);
        if (selectNums.Count == SentenceDictionary.sentences.Length) selectNums.Clear();
        while (selectNums.Contains(num))
        {
            num = UnityEngine.Random.Range(0, SentenceDictionary.sentences.Length);
        }
        selectNums.Add(num);
        randomSentence = SentenceDictionary.sentences[num];
        sentence.text = randomSentence.ToUpper();

    }

    // Use this for initialization
    void Start()
    {
        isAcceptable = false;

    }

    public void OnClickA()
    {
        isAcceptable = false;
        error.text = "";

        if (answer.text.Equals(sentence.text))
            {
            isAcceptable = true;
            answerLength = answer.text.Length;
            Timer.timeLeft += 3 * answerLength/2;

            }
            else
            {
                error.text = "Wrong typed sentence. Please try again.";
            }
        answer.text = "";
    }
        
    }