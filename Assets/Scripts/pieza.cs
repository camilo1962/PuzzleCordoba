using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieza : MonoBehaviour
{
    private Vector3 PosicionCorrecta;
    public bool Encajada;
    public bool Seleccionada;

    void Start()
    {
        PosicionCorrecta = transform.position;
        transform.position = new Vector3(Random.Range(5f,14f), Random.Range(3f,-8f));
    }
    
    void Update()
    {
        if (Vector3.Distance(transform.position, PosicionCorrecta) < 0.5f)
        {
            if (!Seleccionada)
            {
                if (Encajada == false)
                {
                    transform.position = PosicionCorrecta;
                    Encajada = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<juego>().PiezasEncajadas++;
                }
            }
        }
    }
}
