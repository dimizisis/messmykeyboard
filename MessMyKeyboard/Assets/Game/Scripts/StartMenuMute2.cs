using UnityEngine;
using UnityEngine.UI;

public class StartMenuMute2 : MonoBehaviour
{

    public Sprite MuteOff;
    public Sprite MuteOn;
    public Button but;

    void Start()
    {
        if (StartMenuMute.isMuted == false)
        {
            StartMenuMute.source2.mute = false;
        }
        else
        {
            but.image.sprite = MuteOn;
            StartMenuMute.source2.mute = true;

        }
    }

    public void ChangeImage()
    {
        if (but.image.sprite == MuteOff)
        {
            StartMenuMute.isMuted = true;
            but.image.sprite = MuteOn;
            StartMenuMute.source2.mute = true;
        }

        else
        {
            StartMenuMute.isMuted = false;
            but.image.sprite = MuteOff;
            StartMenuMute.source2.mute = false;

        }
    }

}
