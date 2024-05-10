
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesYFunciones : MonoBehaviour
{
    int municiones = 5;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(municiones);

    }

    int Multiplicador(int number)
    { int resultado;
        resultado = number * 2;
        return resultado;

    }
       
     
}