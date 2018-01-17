using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomWordGenerate : MonoBehaviour {

    public Text word;
    public Text title;
    public List<int> indexes = new List<int>();
    public static string randomWord;
    private int rnd;
    private int rnd2;

    // Use this for initialization
    void Start () {

        rnd = Random.Range(0, WordDictionary.words.Length - 1);

        randomWord = WordDictionary.words[rnd];
        word.text = randomWord;
        indexes.Add(rnd);

        title.text = "Type a word beggining with " + word.text[word.text.Length-1] + ":";
    }

    public void Generate()
    {
        string randomWord = WordDictionary.words[Random.Range(0, WordDictionary.words.Length-1)];

        if (WordCheck.isAcceptable == true)
        {
            if (indexes.Count == WordDictionary.words.Length)
            {

                indexes.Clear();

                while (rnd == rnd2)
                    rnd = Random.Range(0, WordDictionary.words.Length - 1);

            }

            else if (indexes.Count == WordDictionary.words.Length - 1)
            {
                rnd = Random.Range(0, WordDictionary.words.Length - 1);
                rnd2 = rnd;
            }
            else
            {

                while (indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, WordDictionary.words.Length - 1);
                }

            }

            indexes.Add(rnd);
            randomWord = WordDictionary.words[rnd];
            word.text = randomWord;
            title.text = "Type a word beggining with " + word.text[word.text.Length - 1] + ":";
        }

    }
	
}