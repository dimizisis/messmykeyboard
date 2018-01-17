using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highscore;
    public Text score;
    private string high;

    void Start()
    {
        if (highscore.text.CompareTo(score.text) < 0)
        {
            high = score.text;
        }
    }

    void Update()
    {
        if (highscore.text.CompareTo(score.text) < 0)
        {
            
            highscore.text = score.text;
            high = score.text;

        }
    }
}
