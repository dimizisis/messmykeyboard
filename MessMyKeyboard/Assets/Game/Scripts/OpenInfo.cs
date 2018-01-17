using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenInfo : MonoBehaviour {

    public Button Sentence;
    public Button Word;
    public Button Sentense;
    public Button Image;
    public Button Taboo;

    void Start()
    {
        Button btnSentence = Sentence.GetComponent<Button>();
        btnSentence.onClick.AddListener(SentenceInfo);
        Button btnWord = Word.GetComponent<Button>();
        btnWord.onClick.AddListener(WordInfo);
        Button btnSentense = Sentense.GetComponent<Button>();
        btnSentense.onClick.AddListener(SentenseInfo);
        Button btnImage = Image.GetComponent<Button>();
        btnImage.onClick.AddListener(ImageInfo);
        Button btnTaboo = Taboo.GetComponent<Button>();
        btnTaboo.onClick.AddListener(TabooInfo);
       
    }

     void SentenceInfo()
    {
        SceneManager.LoadScene("Info");
        EditInfo.txtStatic = "A sentence appears on screen and the player has to type it as quick as he can with randomized keyboardin an amount of time. Timer is initialized with 100 seconds and extends (3 times the length of the word typed divided with 2) every time the player gives the right answer. Keyboard randomizes each time the player gives the right answer. All sentences have to do with IT (Information Technology)!";
    }

    void WordInfo()
    {
        EditInfo.txtStatic = "A word appears on screen and the player has to think of a word, which begins with the last letter of the word on the screen, and type it with randomized keyboardin an amount of time. Timer is initialized with 100 seconds and extends (3 times the length of the word typed) every time the player gives the right answer. Keyboard randomizes each time the player gives the right answer. All words have to do with IT (Information Technology)!";
        SceneManager.LoadScene("Info");
    }

    void SentenseInfo()
    {
        EditInfo.txtStatic = "A phrase with a gap appears on screen and the player has to guess the gap and type it with randomized keyboard in an amount of time. Timer is initialized with 100 seconds and extends (3 times the length of the word typed) every time the player gives the right answer. Keyboard randomizes each time the player gives the right answer. All phrases have to do with IT (Information Technology)!";
        SceneManager.LoadScene("Info");
    }

    void ImageInfo()
    {
        EditInfo.txtStatic = "Player has to think of the name of the logo that is shown and type it with randomized keyboard in an amount of time. Timer is initialized with 100 seconds and extends (3 times the length of the word typed) every time the player gives the right answer. Keyboard randomizes each time the player gives the right answer. All logos have to do with IT (Information Technology)!";
        SceneManager.LoadScene("Info");
    }

    void TabooInfo()
    {
        EditInfo.txtStatic = "A word described with 3 or 4 keywords and the player has to guess and enter the word with randomized keyboard in an amount of time. Timer is initialized with 100 seconds and extends (3 times the length of the word typed) every time the player gives the right answer. Keyboard randomizes each time the player gives the right answer. All words have to do with IT (Information Technology)!";
        SceneManager.LoadScene("Info");
    }

}
