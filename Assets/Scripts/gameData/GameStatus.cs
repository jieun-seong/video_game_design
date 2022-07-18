using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Status")]

public class GameStatus : ScriptableObject
{
    //public float currentHP;
    //public float maxHP;
    public bool menuVisible;
    public bool inventoryVisible;
    public bool playerDead;
    public int itemID;
    public string itemName;
    public bool itemSelected;
    public bool itemActivated;
    public bool itemUsed;
    public int healthAdded;
    public int manaAdded;

}
