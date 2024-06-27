using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearProducto : MonoBehaviour
{
    public GameObject[] objetos;
    private int objetosIndex;
    void Start()
    {
        objetosIndex = Random.Range(1, 4);
        Debug.Log("Índice aleatorio: " + objetosIndex);

        foreach (GameObject g in objetos)
        {
            g.SetActive(false);
        }

        objetos[objetosIndex].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
