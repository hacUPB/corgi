using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlInstrucciones : MonoBehaviour
{
    public void OnPressMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void OnPressAnterior()
    {
        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }
    public void OnPressSiguiente()
    {
        SceneManager.LoadScene("Instrucciones2", LoadSceneMode.Single);
    }
}
