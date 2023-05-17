using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_tiempo;
    private int tiempo;
    private int limitetiempo;
    private int minutos, segundos;
    

    void Start()
    {
        limitetiempo = 65;
        StartCoroutine(Incrementartiempo());

    }

    
    IEnumerator Incrementartiempo()
    {        
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("Aumenta el tiempo");
        tiempo = tiempo+1;
        Debug.Log(tiempo);
        minutos = (int)(tiempo / 60f);
        segundos = (int)(tiempo - minutos * 60f);
        Debug.Log(minutos);
        if (tiempo < limitetiempo)
        {
            StartCoroutine(Incrementartiempo());
            ActualizarValorUI();
        }
        else
        {
            Debug.Log("Se terminó el tiempo");
        }
    }
    public void ActualizarValorUI()
    {
        txt_tiempo.text = string.Format("{0:00}:{1:00}",minutos,segundos);
    }
}
