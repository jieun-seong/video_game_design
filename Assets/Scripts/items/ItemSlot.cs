using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameStatus gameStatus;
    public bool empty;
    public int itemID;
    public int itemCount;
    public string itemName;
    [TextArea(2, 4)]
    public string itemDescription;
    GameObject itemText;
    GameObject itemButton;
    GameObject equipText;
    public bool selected;
    public bool equipable;
    public bool equiped;

    // Start is called before the first frame update
    void Start()
    {
        empty = true;
        selected = false;
        equipable = false;
        equiped = false;
        itemText = this.transform.GetChild(1).gameObject;
        itemButton = this.transform.GetChild(2).gameObject;
        itemText.SetActive(false);
        itemButton.SetActive(false);
        equipText = this.transform.GetChild(3).gameObject;
        equipText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (equipable && gameStatus.itemEquiped && selected)
        {
            equipText.SetActive(true);
            equiped = true;
            gameStatus.itemEquiped = false;
            gameStatus.itemActivated = true;
            selected = false;
        }
        if (!equiped)
        {
            equipText.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData e)
    {
        if (!empty)
        {
            itemText.SetActive(true);
            itemButton.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData e)
    {
        itemText.SetActive(false);
        itemButton.SetActive(false);
    }
}
