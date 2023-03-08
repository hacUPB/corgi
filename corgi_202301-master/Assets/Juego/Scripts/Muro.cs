using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;
    private ControlLlaves control_llaves;

    public void Start()
    {
        //Debug.Log(this.transform.parent.GetComponent<ControlLlaves>();
        control_llaves = this.transform.parent.GetComponent<ControlLlaves>();
        //Debug.Log(control_llaves);

    } 

    public void Update()
    {
        if(control_llaves.CantidadLlavesRecolectadas() == 3)
        {
            CambiarEstado(false);
        }

    }
    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}
