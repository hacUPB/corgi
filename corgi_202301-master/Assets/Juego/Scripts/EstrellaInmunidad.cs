using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class EstrellaInmunidad : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    void Start()
    {
        
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log(this.gameObject.tag);
        if(this.gameObject.tag=="Inmunidad")
        {
            MMEventManager.TriggerEvent(new MMGameEvent("EstrellaEvent"));
        }
        //MMEventManager.TriggerEvent(new MMGameEvent("EstrellaEvent"));
    }

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
}
