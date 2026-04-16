using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float numero1;
    public float numero2;
    float resultadosuma;
    float resultadoresta;
    float resultadomultiplicacion;
    float resultadodivision;

    // Start is called before the first frame update
    void Start()
    {
        resultadosuma = numero1 + numero2;
        resultadoresta = numero1 - numero2;
        resultadomultiplicacion = numero1 * numero2;
        resultadodivision = numero1 / numero2;
        Debug.Log("El resultado de la suma es " + resultadosuma +", de la resta " + resultadoresta + ", de la multiplicación " + resultadomultiplicacion + " y de la division es " + resultadodivision + ". Entre el " + numero1 + " y " + numero2);
    }

}
