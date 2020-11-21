using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gamecontroller : MonoBehaviour
{
    public GameObject gameover;
    
    public static gamecontroller instance;

    public int pontos = 0;
    public Text textoPontos;
    public Text Pontuacaofinal;
    



    
    
    
    // Start is called before the first frame update
    void Start()
    {
       textoPontos.text = "Pontuação: " + pontos.ToString();
       instance = this; 

    }

    // Update is called once per frame
    void Update()
    {
         textoPontos.text = "Pontuação: " + pontos.ToString();
         Pontuacaofinal.text = "Pontuação Final: " + pontos.ToString();
    }



    public void Gameoverr()
    {
        gameover.SetActive(true);
    }

    public void Restartgame(string lvlname)
    {
        SceneManager.LoadScene(lvlname);


    }

    public void Pontuacao ()

    {
        pontos++;
        textoPontos.text = "Pontuação: " + pontos.ToString();
       
    }

    

}
