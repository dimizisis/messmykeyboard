using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTabooGenerate : MonoBehaviour
{

    public Text sentense;
    private string randomSentense;
    public List<int> indexes = new List<int>();
    private int rnd;
    private int rnd2;

    // Use this for initialization
    void Start()
    {
        TabooDictionary.Initialization();
        for (int i=0; i < TabooDictionary.sentenses.Length; i++)
            indexes.Add(i);

        Debug.Log(indexes.Count);

        rnd = Random.Range(0, TabooDictionary.sentenses.Length);
        randomSentense = TabooDictionary.sentenses[rnd];
        indexes.Remove(rnd);
        sentense.text = randomSentense;
    }

    public void Generate()
    {

        Debug.Log(indexes.Count);

        if (TabooCheck.isAcceptable == true) {

            if (indexes.Count == 0)
            {
                for (int i = 0; i < TabooDictionary.sentenses.Length; i++)
                    indexes.Add(i);

                while (rnd == rnd2)
                {
                    rnd = Random.Range(0, TabooDictionary.sentenses.Length);
                }
            }

            else if (indexes.Count == 1)
            {
                while (!indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, TabooDictionary.sentenses.Length);
                }
                rnd2 = rnd;
            }
            else
            {
                while (!indexes.Contains(rnd))
                {
                    rnd = Random.Range(0, TabooDictionary.sentenses.Length);
                }
            }

            indexes.Remove(rnd);
            randomSentense = TabooDictionary.sentenses[rnd];
            sentense.text = randomSentense;

        }

    }

}