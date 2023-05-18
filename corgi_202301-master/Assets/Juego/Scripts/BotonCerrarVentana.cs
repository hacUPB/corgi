using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class BotonCerrarVentana : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;
    

    public void OnFacil()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();
        MMEventManager.TriggerEvent(new MMGameEvent("facil"));
      

    }

    public void OnMedio()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();
        MMEventManager.TriggerEvent(new MMGameEvent("medio"));
    }
    public void OnDificil()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();
        MMEventManager.TriggerEvent(new MMGameEvent("dificil"));
    }

}
