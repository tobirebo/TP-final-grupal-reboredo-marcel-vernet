  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texoscript : MonoBehaviour
{
    public Text operacion;
    public int valortotal;
    // Start is called before the first frame update
    void Start()
    {
        valortotal = Random.Range(1, 21);
        Debug.Log("Valor total: " + valortotal);

        operacion.text = "+  ?  =  " + valortotal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
