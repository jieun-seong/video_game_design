using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Consumable Item")]
public class ConsumableItem : InventoryItem
{
    public enum ConsumableType
    {
        healing,
        cartridge,
        battery,
        fuel
    }

    [Header("Consumable Stats")]
    public ConsumableType consumableType;
    public int statOne;
}
