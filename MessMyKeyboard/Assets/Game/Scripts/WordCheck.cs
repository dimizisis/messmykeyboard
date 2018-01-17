using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class WordCheck : MonoBehaviour {

    public Text word;
    public Text answer;
    public Text error;
    string randomWord;
    public static bool startsWithLetter;
    public static bool isAcceptable;
    public static int answerLength;
    public HashSet<string> enteredWords = new HashSet<string>();

    public void SelectWord()
        {
            randomWord = WordDictionary.words[UnityEngine.Random.Range(0, WordDictionary.words.Length)];
			word.text = randomWord.ToUpper();

        }

        // Use this for initialization
        void Start () {
        startsWithLetter = false;
        isAcceptable = false;

    }

    public void OnClickA()
    {
        startsWithLetter = false;
        isAcceptable = false;
        if (answer.text.ToUpper().StartsWith(word.text.ToUpper()[word.text.Length - 1].ToString()))
        {
            answerLength = answer.text.Length;
            error.GetComponent<Text>();
			error.text = "";
            startsWithLetter = true;

            int positionOfAnswer = Array.IndexOf(WordDictionary.words, answer.text);
            if (positionOfAnswer > -1 && answer.text != word.text && !enteredWords.Contains(answer.text.ToString()))
            {
                isAcceptable = true;
                Timer.timeLeft += 3*answerLength;
                enteredWords.Add(answer.text.ToString());

            }
            else if (enteredWords.Contains(answer.text.ToString())) error.text = "Already entered word!";
            else
            {
                error.text = "Not acceptable word. Please try another.";
            }
        }

        else
        {
            error.GetComponent<Text>();
            error.text = "Please enter a word beggining with " + word.text[word.text.Length - 1] + "!";
        }
        answer.text = "";
    }
}