using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeKeyTabooGame : MonoBehaviour

{
    private HashSet<Button> usedButtons = new HashSet<Button>();

    private string letter;
    public Text answer;

    private int randomNumB;

    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button button16;
    public Button button17;
    public Button button18;
    public Button button19;
    public Button button20;
    public Button button21;
    public Button button22;
    public Button button23;
    public Button button24;
    public Button button25;

    private List<Button> buttons = new List<Button>();

    private UnityEngine.UI.Button randomButton;

    // Use this for initialization
    void Start()
    {
        buttons.Add(button0);
        buttons.Add(button1);
        buttons.Add(button2);
        buttons.Add(button3);
        buttons.Add(button4);
        buttons.Add(button5);
        buttons.Add(button6);
        buttons.Add(button7);
        buttons.Add(button8);
        buttons.Add(button9);
        buttons.Add(button10);
        buttons.Add(button11);
        buttons.Add(button12);
        buttons.Add(button13);
        buttons.Add(button14);
        buttons.Add(button15);
        buttons.Add(button16);
        buttons.Add(button17);
        buttons.Add(button18);
        buttons.Add(button19);
        buttons.Add(button20);
        buttons.Add(button21);
        buttons.Add(button22);
        buttons.Add(button23);
        buttons.Add(button24);
        buttons.Add(button25);

    }

    public void OnClickB()
    {

        if (TabooCheck.isAcceptable == true)
        {

            usedButtons.Clear();

            for (int i = 0; i < 26; i++)
            {
                do
                {

                    randomNumB = Random.Range(0, buttons.Count);

                } while (usedButtons.Contains(buttons[randomNumB]));

                usedButtons.Add(buttons[randomNumB]);

                randomButton = buttons[randomNumB];

                randomButton.GetComponentInChildren<Text>().text = getLetter(i);

            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static string getLetter(int index)
    {   // Λίστα με γράμματα

        switch (index)
        {
            case 0: return "A";
            case 1: return "B";
            case 2: return "C";
            case 3: return "D";
            case 4: return "E";
            case 5: return "F";
            case 6: return "G";
            case 7: return "H";
            case 8: return "I";
            case 9: return "J";
            case 10: return "K";
            case 11: return "L";
            case 12: return "M";
            case 13: return "N";
            case 14: return "O";
            case 15: return "P";
            case 16: return "Q";
            case 17: return "R";
            case 18: return "S";
            case 19: return "T";
            case 20: return "U";
            case 21: return "V";
            case 22: return "W";
            case 23: return "X";
            case 24: return "Y";
            case 25: return "Z";
        }
        return "";
    }


}