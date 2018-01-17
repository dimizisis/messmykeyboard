using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSentenseGenerate : MonoBehaviour {

    public Text sentense;
	//public Text word;

    public Text answer;
    private int rnd;
    private int rnd2;
    public static string randomWord;
    private string randomSentense;
    public List<int> indexes = new List<int>();

    // Use this for initialization
    void Start ()
    {
        SentenseDictionary.Initialization();
        rnd = Random.Range(0, SentenseDictionary.sentenses.Length); //assigned to a variable gia na andistixei i protasi me tin dikia tis leksi pou lipei
        indexes.Add(rnd);
        randomSentense = SentenseDictionary.sentenses[rnd];
        randomWord = SentenseDictionary.words[rnd]; //assigned se static metavliti gia na ginei elenxos stin SentenseCheck
        sentense.text = randomSentense;   //emfanizete stin othoni i protasi  
    }

    public void Generate()
    {
        SentenseDictionary.Initialization();
        if (SentenseCheck.isAcceptable == true)
        {
            if (indexes.Count == SentenseDictionary.sentenses.Length)
            {

                indexes.Clear();

                rnd = Random.Range(0, SentenseDictionary.sentenses.Length);

                while (rnd == rnd2)
                    rnd = Random.Range(0, SentenseDictionary.sentenses.Length);

            }

            else if (indexes.Count == SentenseDictionary.sentenses.Length - 1)
            {
                while (indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, SentenseDictionary.sentenses.Length);
                }
                rnd2 = rnd;
            }
            else
            {

                while (indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, SentenseDictionary.sentenses.Length);
                }

            }

            indexes.Add(rnd);
            randomSentense = SentenseDictionary.sentenses[rnd];
            randomWord = SentenseDictionary.words[rnd];
            sentense.text = randomSentense;
        }

    }

}
