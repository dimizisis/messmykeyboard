using UnityEngine;

public class MainGameMute : MonoBehaviour {

    public AudioSource audioC;

	// Use this for initialization
	void Start () {

        if (StartMenuMute.isMuted == true)
        {
            audioC = GetComponent<AudioSource>();
            audioC.mute = true;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
