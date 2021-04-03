using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunInvent : InventoryItemBase
{
    public override string Name
    {
        get
        {
            return "Riffle";
        }
    }

    public override void OnUse()
    {
        base.OnUse();
    }
}