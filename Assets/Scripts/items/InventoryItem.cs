using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : ScriptableObject
{
    public enum ItemType
    {
        consumable,
        gear,
        weapon
    }

    public int itemID;
    public ItemType itemType;
    public string itemName;
    public Sprite itemPNG;
    [TextArea(2, 4)]
    public string itemDescription;
}
