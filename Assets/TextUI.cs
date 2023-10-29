using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    public Text textUI;
    void Start()
    {
        textUI.text = Constant.COINNUM.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
