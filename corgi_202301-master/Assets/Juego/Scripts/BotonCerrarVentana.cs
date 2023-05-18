using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class BotonCerrarVentana : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;
    

    public void OnCerrarVentana()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();
        MMEventManager.TriggerEvent(new MMGameEvent("facil"));
      

    }

}
