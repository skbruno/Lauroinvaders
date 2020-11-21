using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour
{
    public float mov;
    
    public float tiroInicial;
    public float tiroContinuo;
    public GameObject tiros;
      
    public int numeroTiros;
    List<GameObject> listaTiros;
    // Start is called before the first frame update
    void Start()
    {
        listaTiros = new List<GameObject>();

        for (int i = 0; i < numeroTiros; i++)
        {
            GameObject obj = (GameObject)Instantiate(tiros);
            obj.SetActive(false);
            listaTiros.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();


        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Atirar", tiroInicial, tiroContinuo);
        } else if (Input.GetKeyUp(KeyCode.Space)){
            CancelInvoke("Atirar");
        }
        
    }


    void Move()
    {
        float posX = transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * mov;

        transform.position = new Vector3(Mathf.Clamp(posX, -7, 7), 3.30f, 0);
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "vaca")
        {
            gamecontroller.instance.Gameoverr();
            Destroy(gameObject);
        }


    }


     void Atirar()
    {
        for (int i = 0; i < listaTiros.Count; i++)
        {
            if (!listaTiros[i].activeInHierarchy)
            {
                 GetComponent<AudioSource>(). Play();
                listaTiros[i].transform.position = transform.position;
                listaTiros[i].transform.rotation = transform.rotation;
                listaTiros[i].SetActive(true);
                break;
            }
        }
    }
}
