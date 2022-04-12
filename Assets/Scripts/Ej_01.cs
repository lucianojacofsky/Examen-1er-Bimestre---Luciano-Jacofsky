using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_01 : MonoBehaviour

{
    public int dias;
    public int diaslluvia;
    public int taxis;
    // Start is called before the first frame update
    void Start()
    {
        int diastotales = dias + diaslluvia;
        if (diastotales < 5)
        {
            Debug.Log("Error");
            
        } else if (diaslluvia > diastotales)
        {
            Debug.Log("Error");
        }
        else if (diaslluvia < 0)
        {
            Debug.Log("Error");
        }
        else
        {
            int kmdia = taxis * 90;
            int kmdialluvia = taxis * 110;
            int combusdia = taxis * 6 * 130 * dias;
            int combusdialluvia = taxis * 8 * 130 * diaslluvia;
            int costototal = combusdia + combusdialluvia;

            Debug.Log("Una flota de " + taxis + " taxis trabajando durante " + diastotales + " dias implicará un gasto de " + costototal + " pesos en concepto de combustible.");

        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
