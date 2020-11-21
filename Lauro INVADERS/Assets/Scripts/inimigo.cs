using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public GameObject vaca;
    
     public Vector3 moveSpeed;
    public float spawnTime = 2f;
    public float spawnDelay = 2f;
 
    // Use this for initialization
    void Start()
    {
        moveSpeed = Vector3.left * Time.deltaTime;
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
    }
 
    void ChangeSpeed()
    {
        moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.05f;
    }
     
    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D outro)
    {

        if (outro.gameObject.tag == "bala")
        {
            Destroy(gameObject);
           
        }

        


    }
}
