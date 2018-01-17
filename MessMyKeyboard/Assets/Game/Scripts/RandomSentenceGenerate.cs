using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSentenceGenerate : MonoBehaviour
{

    public Text sentence;
    public List<int> indexes = new List<int>();
    public Text answer;
    private int rnd;
    private int rnd2;
    public static string randomSentence;

    // Use this for initialization
    void Start()
    {
        SentenceDictionary.GenerateSent();
        rnd = Random.Range(0, SentenceDictionary.sentences.Length);
        randomSentence = SentenceDictionary.sentences[rnd];
        indexes.Add(rnd);

        sentence.text = randomSentence;

    }

    public void Generate()
    {
        SentenceDictionary.GenerateSent();

        string randomSentence = SentenceDictionary.sentences[Random.Range(0, SentenceDictionary.sentences.Length)];

        if (SentenceCheck.isAcceptable == true)
        {
                if (indexes.Count == SentenceDictionary.sentences.Length)
                {

                indexes.Clear();

                while(rnd == rnd2)
                    rnd = Random.Range(0, SentenceDictionary.sentences.Length);

                }

                else if (indexes.Count == SentenceDictionary.sentences.Length - 1) {
                while (indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, SentenceDictionary.sentences.Length);
                }
                rnd2 = rnd;
            }
            else {

                while (indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, SentenceDictionary.sentences.Length);
                }

            }

            indexes.Add(rnd);
            randomSentence = SentenceDictionary.sentences[rnd];
            sentence.text = randomSentence;

        }

    }
}