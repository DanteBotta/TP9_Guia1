using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{

    int Numero = 7;
    float Decimales = 6.7f;
    string Texto = "Bienvenido";
    bool Booleano = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La Variable de tipo int dice: " + Numero);
        Debug.Log("La Variable de tipo float dice: " + Decimales);
        Debug.Log("La Variable de tipo string dice: " + Texto);
        Debug.Log("La Variable de tipo bool dice: " + Booleano);
    }
}
