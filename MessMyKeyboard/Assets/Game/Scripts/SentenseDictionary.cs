using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenseDictionary : MonoBehaviour {

    public static string[] sentenses;
	public static string[] words;

    public static void Initialization()
    {

        sentenses = new string[] {
        "RANDOM _ _ _ _ _ _ MEMORY",
        "DATABASE _ _ _ _ _ _ _ _ _ _ _ _ SYSTEM",
        "WORLD _ _ _ _ WEB",
        "CENTRAL _ _ _ _ _ _ _ _ _ _ UNIT",
        "BLUE _ _ _ _ _ _ OF DEATH"
        };

        words = new string[] {
        "ACCESS",
        "MANAGEMENT",
        "WIDE",
        "PROCESSING",
        "SCREEN"
        };

    }
}