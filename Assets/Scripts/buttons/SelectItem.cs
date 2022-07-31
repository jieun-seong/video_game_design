using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectItemButton()
    {
        ItemSlot slotScript = transform.parent.GetComponent<ItemSlot>();

        gameStatus.itemSelected = true;
        gameStatus.itemID = slotScript.itemID;
        gameStatus.itemName = slotScript.itemName;
        gameStatus.itemEquipable = slotScript.equipable;
        gameStatus.slotObject = transform.parent.gameObject;
    }
}
