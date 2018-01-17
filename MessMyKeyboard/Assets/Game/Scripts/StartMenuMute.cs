using UnityEngine;
using UnityEngine.UI;

public class StartMenuMute : MonoBehaviour {

    public Sprite MuteOff;
    public Sprite MuteOn;
    public Button but;
    public AudioSource source;
    public static AudioSource source2;
    public static bool isMuted = false;

    void Start()
    {
            source2 = source;        
    }

    public void ChangeImage()
    {
        if (but.image.sprite == MuteOff)
        {
            isMuted = true;
            but.image.sprite = MuteOn;
            source2.mute = true;
            source2 = source;
        }

        else
        {
            isMuted = false;
            but.image.sprite = MuteOff;
            source2.mute = false;
            source2 = source;
        }
    }

    void Awake()
    {
        source2 = source;

    }

}