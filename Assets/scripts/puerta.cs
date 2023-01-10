using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{


    public GameObject nokey;
    public GameObject key;
    public GameObject btnPuerta;


    public Animator animPuerta;
    


    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);   
        nokey.SetActive(false);
        btnPuerta.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("key"))
        {
            abrirpuerta.llaves += 1;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag.Equals("door")&&abrirpuerta.llaves==0)
        {
            nokey.SetActive(true);

        }

        if (collision.tag.Equals("door") && abrirpuerta.llaves == 1)
        {
            key.SetActive(true);
            btnPuerta.SetActive(true);

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag.Equals("door") && abrirpuerta.llaves == 0)
        {
            nokey.SetActive(false);

        }

        if (collision.tag.Equals("door") && abrirpuerta.llaves == 1)
        {
            key.SetActive(false);
            btnPuerta.SetActive(false);

        }

    }

    public void botonPuerta()
    {
        animPuerta.SetTrigger("abrir");
    }

}
