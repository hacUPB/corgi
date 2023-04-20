using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAleatorio : MonoBehaviour
{
    [SerializeField]
    private List<Llave> coins;
    private int[] indices = { 0, 1, 2, 3, 4, 5, 6 };

    public void Start()
    {
        Shuffle();
        OcultarMonedas();
        MostrarMonedas(3);
    }

    public void MostrarMonedas(int total)
    {
        int indice_moneda;
        if (total >= 0 && total < coins.Count)
        {
            for (int i = 0; i < total; i++)
            {
                indice_moneda = indices[i];
                coins[indice_moneda].Mostrar();
            }
        }
    }
    public void OcultarMonedas()
    {
        for(int i = 0; i < coins.Count; i++)
        {
            coins[i].Ocultar();
        }
    }
    public void Shuffle()
    {
        for (int t = 0; t < indices.Length; t++)
        {
            int tmp = indices[t];
            int r = Random.Range(t, indices.Length);
            indices[t] = indices[r];
            indices[r] = tmp;
        }
    }
}
