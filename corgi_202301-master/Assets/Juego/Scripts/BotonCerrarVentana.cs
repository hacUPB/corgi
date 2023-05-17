using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class BotonCerrarVentana : MonoBehaviour, MMEventListener<MMDamageTakenEvent>
{
    [SerializeField]
    private GameObject ventana;
    private int tiempo;
    public int Tiempo { get => tiempo; set => tiempo = value; }

    public void OnCerrarVentana()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();
        Tiempo = 65;

    }
    public virtual void OnMMEvent(MMDamageTakenEvent easyevent)
    {
        // here we start a coroutine that will display our achievement
        if (Tiempo==65)
        {
            MMEventManager.TriggerEvent(new MMGameEvent("facil"));
            Tiempo = 65;
        }

    }
    void OnEnable()
    {
        this.MMEventStartListening<MMDamageTakenEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMDamageTakenEvent>();
    }

}
