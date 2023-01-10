using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLineal : MonoBehaviour
{

    public List<Transform> Puntos;
    int puntoActual;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Puntos[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Puntos[puntoActual].position)<0.1f)
        {
            puntoActual++;
            if(puntoActual>=Puntos.Count)
            {
                puntoActual= 0;
            }
        }
        transform.position=Vector3.MoveTowards(transform.position, Puntos[puntoActual].position, speed*Time.deltaTime);
    }
}
