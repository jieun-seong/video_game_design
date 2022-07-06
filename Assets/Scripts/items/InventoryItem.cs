using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : ScriptableObject
{
    public int itemID;
    public string itemName;
    public Sprite itemPNG;
    [TextArea(2, 4)]
    public string itemDescription;
}
