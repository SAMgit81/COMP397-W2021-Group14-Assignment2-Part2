using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : InventoryItemBase
{
    public override string Name
    {
        get
        {
            return "Health Potion";
        }
    }

    public override void OnUse()
    {
        base.OnUse();

    }
}