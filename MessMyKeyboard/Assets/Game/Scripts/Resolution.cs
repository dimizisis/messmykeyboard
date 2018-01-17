using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour {

        void Start()
        {
            // Switch to 640 x 480 fullscreen
            Screen.SetResolution(1224, 517, true);
        }
}