using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public bool empty;
    public int itemID;
    public int itemCount;
    public string itemName;
    [TextArea(2, 4)]
    public string itemDescription;
    //GameObject itemText;

    // Start is called before the first frame update
    void Start()
    {
        empty = true;
        //itemText = this.transform.GetChild(1).gameObject;
        //itemText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        //itemText.SetActive(true);
    }

    public void OnMouseExit()
    {
        //itemText.SetActive(false);
    }
}
