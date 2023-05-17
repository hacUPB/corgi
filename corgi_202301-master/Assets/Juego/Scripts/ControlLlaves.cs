using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlLlaves : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_llaves;
    private int contador_llaves;

    public void Start()
    {
    }

    public int CantidadLlavesRecolectadas()
    {
        return contador_llaves;
    }

    public void ActualizarPuntaje(int valor)
    {
        ControlPuntaje.Instance.SumarPuntos(valor);
        contador_llaves += valor;
        ActualizarValorUI();
    }
    public void ActualizarValorUI()
    {
        txt_contador_llaves.text ="" + contador_llaves;
    }
}
