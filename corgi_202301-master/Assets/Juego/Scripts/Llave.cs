using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Llave : PickableItem
{
    protected override void Pick(GameObject picker)
    {

        Debug.Log("Recolección");
    }
}
