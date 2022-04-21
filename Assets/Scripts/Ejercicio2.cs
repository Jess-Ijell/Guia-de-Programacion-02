//Realizar un programa que muestre los números del 1 al 100 usando la instrucción while.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    int counter = 0;
    int counterMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log(counter);
            counterMax++;
        }

        Debug.Log("Terminó el while");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
