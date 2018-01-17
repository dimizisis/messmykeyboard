using UnityEngine;

public class TabooDictionary : MonoBehaviour {

    public static string[] sentenses;
	public static string[] words;

    public static void Initialization()
    {

        sentenses = new string[] {
        "MOUSE, KEYBOARD, MONITOR",
        "JAVA, C++, PYTHON",
        "RAM, ROM, CACHE",
        "USB, HDMI, PS/2"
        };

        words = new string[] {
        "HARDWARE",
        "CODING",
        "MEMORY",
        "PORTS",
        };

    }
}