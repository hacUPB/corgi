using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlPuntaje : MonoBehaviour
{

    public static ControlPuntaje Instance { get; private set; }
    [SerializeField]
    private int cantidad;

    private void Awake()
    {
        if (ControlPuntaje.Instance == null)
        {
            ControlPuntaje.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SumarPuntos(int valorllave)
    {
        cantidad += valorllave;
    }
       

}
