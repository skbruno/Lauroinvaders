using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public float velTiro;
    public float tempoVida;

    
   void OnEnable()
    {
        Invoke("Desligar", tempoVida);
    }

    void Desligar()
    {
        gameObject.SetActive(false);
    }

    void OnDisabled()
    {
        CancelInvoke();
    }

    void Update()
    {
        transform.position += new Vector3(0, -velTiro, 0) * Time.deltaTime;
    }

    void OnTriggerEnter2D (Collider2D objetoDeColisao) 
    {
        if(objetoDeColisao.tag == "vaca")
        {
            gamecontroller.instance.Pontuacao();
            Destroy(objetoDeColisao.gameObject);
            
        }
    }

    
}
