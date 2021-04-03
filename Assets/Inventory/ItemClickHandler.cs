using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickHandler : MonoBehaviour
{
    public InventoryPanel _Inventory;
    public void OnItemClicked()
    {
        ItemDragHandler dragHandler =
            gameObject.transform.Find("imageType").GetComponent<ItemDragHandler>();
            InventoryItemBase item = dragHandler.Item;
            Debug.Log(item.Name);

        _Inventory.UseItem(item);

             item.OnUse();

    }
}
