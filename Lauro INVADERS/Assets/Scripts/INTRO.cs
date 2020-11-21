using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class INTRO : MonoBehaviour
{
    
    public Text textwriter;
    public float delaywriter = 0.2f;
    public string escrever;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("mostrar", escrever);
    }

    
    IEnumerator mostrar (string textType)
    {
        textwriter.text = "";
        for (int letter = 0; letter < textType.Length; letter++)
        {
            textwriter.text = textwriter.text + textType[letter];
            yield return new WaitForSeconds (delaywriter);


        }


    }

    public void next ( string lvlname  )
    {
        SceneManager.LoadScene("lvl1");


    }
}
