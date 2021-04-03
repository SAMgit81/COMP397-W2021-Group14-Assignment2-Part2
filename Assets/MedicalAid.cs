using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalAid : InventoryItemBase
{
    public override string Name
    {
        get
        {
            return "First Aid";
        }
    }

    public override void OnUse()
    {
        base.OnUse();
    }
}
