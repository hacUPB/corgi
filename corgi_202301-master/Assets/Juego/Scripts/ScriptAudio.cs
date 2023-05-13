using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAudio : MonoBehaviour
{
    public static ScriptAudio Ins;
    void Awake()
    {
        if (ScriptAudio.Ins == null)
        {
            ScriptAudio.Ins = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

