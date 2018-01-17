using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditInfo : MonoBehaviour {

    public Text txt;
    public static string txtStatic = "";

    void Start()
    {
     //   txt.text = txtStatic.ToString();
    }

    void Update()
    {
        txt.text = txtStatic.ToString();
    }

}