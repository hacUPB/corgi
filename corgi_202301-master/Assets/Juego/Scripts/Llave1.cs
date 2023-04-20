using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Llave1 : PickableItem
{
    [SerializeField]
    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_llave;
    private ControlLlaves control_llaves;

    public void Start()
    {
        //PickableItem.Start();
        control_llaves = ui_puntaje.GetComponent<ControlLlaves>();
    }
    protected override void Pick(GameObject picker)
    {

        //Debug.Log("Recolección");
        control_llaves.ActualizarPuntaje(valor_llave);
    }
}