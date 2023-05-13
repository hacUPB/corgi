using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlVentana : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private GameObject ventana;

    public void OnMMEvent(MMGameEvent eventType)
    {
        if (eventType.EventName == "AbrirVentanaEvent")
        {
            ventana.SetActive(true);
            GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
            StartCoroutine(CerrarVentana());
        }
    }

    IEnumerator CerrarVentana()
    {
        Debug.Log("Cerrar Ventana");
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("la Ventana se cerro");
        GameManager.Instance.UnPause();
        ventana.SetActive(false);
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
