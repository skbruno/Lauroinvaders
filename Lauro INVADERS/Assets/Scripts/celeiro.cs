using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celeiro : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D objetoDeColisao) 
    {
        if(objetoDeColisao.tag == "vaca")
        {
        
            Destroy(objetoDeColisao.gameObject);
            
        }
    }
}
