using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool empty;
    public int itemID;
    public int itemCount;
    public string itemName;
    [TextArea(2, 4)]
    public string itemDescription;
    GameObject itemText;
    GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        empty = true;
        itemText = this.transform.GetChild(1).gameObject;
        itemButton = this.transform.GetChild(2).gameObject;
        itemText.SetActive(false);
        itemButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
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
