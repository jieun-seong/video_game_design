using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Gear Item")]
public class GearItem : InventoryItem
{
    public enum GearType
    {
        helmet,
        armor,
        gauntlet,
        boots
    }

    [Header("Gear Stats")]
    public GearType gearType;
    public int statOne;
    public int statTwo;
    public int statThree;
}