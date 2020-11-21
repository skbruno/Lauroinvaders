using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempo : MonoBehaviour
{


    public float timestar = 60;
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timestar.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        timestar -= Time.deltaTime;
        textbox.text = Mathf.Round(timestar).ToString ();

        if (timestar < 0)
        {
            timestar =0;
            gamecontroller.instance.Gameoverr();
            
            
        }
    }
}
