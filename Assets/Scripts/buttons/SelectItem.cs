using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;
    ItemSlot slotScript;

    // Start is called before the first frame update
    void Start()
    {
        slotScript = transform.parent.GetComponent<ItemSlot>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SelectItemButton()
    {
        slotScript.selected = true;
        gameStatus.itemSelected = true;
        gameStatus.itemID = slotScript.itemID;
        gameStatus.itemName = slotScript.itemName;
        gameStatus.itemEquipable = slotScript.equipable;
        gameStatus.slotObject = transform.parent.gameObject;
    }
}
