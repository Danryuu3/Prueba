using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Salida : MonoBehaviour
{
    //int numero = 2;
    //float decima = 3.2;
    //string cadena = "holo";
    //bool verdadero = true;
    public TextMeshProUGUI output;
    public TextMeshProUGUI input;
    public GameObject imagen;

   //public void MiFuncion()
    //{
    //    print(numero + " " + decima);
     //   output.text = numero + " " + decima;
   // }
   public void MiFuncion()
    {
        imagen.SetActive(false);
        input.text = output.text;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
