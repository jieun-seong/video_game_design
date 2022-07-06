using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Item")]
public class WeaponItem : InventoryItem
{
    public enum WeaponType
    {
        melee,
        gun,
        electrical,
        fuel_based
    }

    [Header("Weapon Stats")]
    public WeaponType weaponType;
    public int statOne;
    public int statTwo;
    public int statThree;
}
