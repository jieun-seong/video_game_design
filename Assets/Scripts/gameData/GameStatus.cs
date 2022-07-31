using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Status")]

public class GameStatus : ScriptableObject
{
    public bool weaponEquiped;
    public bool menuVisible;
    public bool inventoryVisible;
    public bool playerDead;
    public GameObject slotObject;
    public GameObject inventoryItem;
    public int itemID;
    public string itemName;
    public bool itemSelected;
    public bool itemActivated;
    public bool itemEquipable;
    public bool itemEquiped;
    public bool itemUsed;
    public int healthAdded;
    public int manaAdded;

}
