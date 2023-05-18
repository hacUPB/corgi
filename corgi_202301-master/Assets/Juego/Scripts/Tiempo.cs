using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class Tiempo : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private TMP_Text txt_tiempo;
    private int tiempo;
    private int limitetiempo;
    private int minutos, segundos;



    public virtual void OnMMEvent(MMGameEvent easyevent)
    {
        // here we start a coroutine that will display our achievement
        if (easyevent.EventName == "facil")
        {
            limitetiempo = 180;
            Debug.Log(limitetiempo);
            StartCoroutine(Incrementartiempo());
        }
        if (easyevent.EventName == "medio")
        {
            limitetiempo = 120;
            Debug.Log(limitetiempo);
            StartCoroutine(Incrementartiempo());
        }
        if (easyevent.EventName == "dificil")
        {
            limitetiempo = 60;
            Debug.Log(limitetiempo);
            StartCoroutine(Incrementartiempo());
        }
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
            MMSceneLoadingManager.LoadScene("jugar");
            Debug.Log("Se terminó el tiempo");
        }
    }
    public void ActualizarValorUI()
    {
        txt_tiempo.text = string.Format("{0:00}:{1:00}",minutos,segundos);
    }
    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
}
