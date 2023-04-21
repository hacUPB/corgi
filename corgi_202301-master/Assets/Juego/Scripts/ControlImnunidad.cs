using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class ControlImnunidad : MonoBehaviour, MMEventListener<MMGameEvent>
{
    private Health health;
    void Start()
    {
        health = this.GetComponent<Health>();
    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
        Debug.Log(e.EventName);

        if(e.EventName == "EstrellaEvent")
        {
            health.DamageDisabled();
        }

    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }

}
