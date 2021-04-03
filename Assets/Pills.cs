using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : InventoryItemBase
{
    public override string Name
    {
        get
        {
            return "Pills";
        }
    }

    public override void OnUse()
    {
        base.OnUse();
    }
}
