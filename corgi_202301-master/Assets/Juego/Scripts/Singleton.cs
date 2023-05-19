using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private int tiempos;
    private int limitetiempos;
    
     private void Start(){
        tiempos= Tiempo.Instancia.tiempo;
        limitetiempos=Tiempo.Instancia.limitetiempo;

    }
    private void OnDistroy(){
        Tiempo.Instancia.tiempo = tiempos;
        Tiempo.Instancia.limitetiempo = limitetiempos;
    }
}
