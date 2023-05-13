using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class BotonCerrarVentana : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;

    public void OnCerrarVentana()
    {
        ventana.SetActive(false);
        GameManager.Instance.UnPause();

    }
}
