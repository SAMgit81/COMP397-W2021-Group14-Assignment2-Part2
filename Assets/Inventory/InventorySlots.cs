using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlots 
{
    private Stack<InventoryItemBase> nItemStack = new Stack<InventoryItemBase>();
    private int nId = 0;

    public InventorySlots(int id)
    {
        nId = id;
    }
    public int Id
    {
        get { return nId; }
    }
    public void AddItem(InventoryItemBase item)
    {
        item.Slot = this;
        nItemStack.Push(item);
    }

    public InventoryItemBase FirstItem
    {
        get
        {
            if (IsEmpty)
                return null;
            return nItemStack.Peek();
        }
    }

    public bool IsStackble(InventoryItemBase item)
    {
        if (IsEmpty)
            return false;

        InventoryItemBase first = nItemStack.Peek();

        if (first.Name == item.Name)
            return true;

        return false; 
    }

    public bool IsEmpty
    {
        get { return Count == 0; }
    }

    public int Count
    {
        get { return nItemStack.Count; }
    }

    public bool Remove(InventoryItemBase item)
    {
        if (IsEmpty)
            return false;

        InventoryItemBase first = nItemStack.Peek();
        if(first.Name == item.Name)
        {
            nItemStack.Pop();
                return true;
        }
        return false;
    }
}
