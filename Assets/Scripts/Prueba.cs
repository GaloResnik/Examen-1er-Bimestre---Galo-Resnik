//El supermercado TicMarket nos pide que realicemos un programa para que sus clientes puedan calcular el costo de 
//algunos productos que se encuentran en promoción

//Se pide que se ingrese por inspector:
//. Los nombre de tres productos
//.Los precios de cada producto
//.La cantidad de unidades deseada de cada producto

//El programa debe cumplir los siguientes requerimientos:

//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son
//menores a 1.

//El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total
//sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public string nombreprod1, nombreprod2, nombreprod3;
    public float precioprod1, precioprod2, precioprod3;
    public int cantidadprod1, cantidadprod2, cantidadprod3;
    
    // Start is called before the first frame update
    void Start()
    {
        float preciodesc1, preciodesc2, preciodesc3;
        if (cantidadprod1 > 3)
        {
            preciodesc1 = (precioprod1 / 5) * 4;
        }
        else
        {
            preciodesc1 = precioprod1;
        }
        if (cantidadprod2 > 3)
        {
            preciodesc2 = (precioprod2 / 5) * 4;
        }
        else
        {
            preciodesc2 = precioprod1;
        }
        if (cantidadprod3 > 3)
        {
            preciodesc3 = (precioprod2 / 5) * 4;
        }
        else
        {
            preciodesc3 = precioprod3;
        }
        float montodesc = (precioprod1 * cantidadprod1 + precioprod2 * cantidadprod2 + precioprod3 * cantidadprod3) - (preciodesc1 * cantidadprod1 + preciodesc2 * cantidadprod2 + preciodesc3 * cantidadprod3);

        //El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total
        //sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.
        if (precioprod1 > 0 && precioprod2 > 0 && precioprod3 > 0 && cantidadprod1 > 0 && cantidadprod2 > 0 && cantidadprod3 > 0)
        {
            Debug.Log("El monto total sin descuentos es: " + (precioprod1 * cantidadprod1 + precioprod2 * cantidadprod2 + precioprod3 * cantidadprod3) + ". El monto descontado es: " + montodesc + ". El monto total con los descuentos es: " + (preciodesc1 * cantidadprod1 + preciodesc2 * cantidadprod2 + preciodesc3 * cantidadprod3) + ".");
        }
        if (precioprod1 < 1)
        {
            Debug.Log("Error: El precio del " + nombreprod1 + " es 0");
        }
        if (precioprod2 < 1)
        {
            Debug.Log("Error: El precio del " + nombreprod2 + " es 0");
        }
        if (precioprod3 < 1)
        {
            Debug.Log("Error: El precio del " + nombreprod3 + " es 0");
        }
        if (cantidadprod1 < 1)
        {
            Debug.Log("Error: La cantidad deseada del " + nombreprod1 + " es 0");
        }
        if (cantidadprod2 < 1)
        {
            Debug.Log("Error: La cantidad deseada del " + nombreprod2 + " es 0");
        }
        if (cantidadprod3 < 1)
        {
            Debug.Log("Error: La cantidad deseada del " + nombreprod3 + " es 0");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
