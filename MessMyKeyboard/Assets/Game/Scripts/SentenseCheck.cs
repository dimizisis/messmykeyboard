using UnityEngine;
using UnityEngine.UI;

public class SentenseCheck : MonoBehaviour {

	public Text sentense;
    public Text answer;
    public Text error;
    public static string randomWord;
    public static bool startsWithLetter;
    public static bool isAcceptable;
    public static int answerLength;

    public void SelectSentense() 
        {
			//int randomIndex = UnityEngine.Random.Range(0, SentenseDictionary.words.Length);
            //randomWord = SentenseDictionary.words[randomIndex];
			//randomSentense = SentenseDictionary.sentenses[randomIndex];
			//sentense.text = randomSentense.ToUpper();

        }

        // Use this for initialization
        void Start () {

        startsWithLetter = false;
        isAcceptable = false;

        }

    public void OnClickEnter()
    {
        isAcceptable = false;
        error.text = "";

        if (answer.text.Equals(RandomSentenseGenerate.randomWord))
        {
            isAcceptable = true;
            answerLength = answer.text.Length;
            Timer.timeLeft += 3 * answerLength;

        }
        else
        {
            error.text = "You guessed wrong! Please try another word.";
        }

        answer.text = "";

    }
}