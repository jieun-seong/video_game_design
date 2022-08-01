using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class InventoryPanel : MonoBehaviour
{
	public Sprite empty;
	[SerializeField] private GameObject panelSpot;
	[SerializeField] private GameStatus gameStatus;
	private List<GameObject> items = new List<GameObject>();
	private CanvasGroup canvasGroup;
	private GameObject[] itemRepresentation;
	private int inventorySpace;

	// Start is called before the first frame update
	void Awake()
    {
		canvasGroup = GetComponent<CanvasGroup>();
		gameStatus.itemID = -1;
		gameStatus.itemName = "";
		gameStatus.itemSelected = false;
		gameStatus.itemActivated = false;
		gameStatus.inventoryVisible = false;
		gameStatus.itemUsed = false;
		gameStatus.healthAdded = 0;
		gameStatus.manaAdded = 0;

		inventorySpace = panelSpot.transform.childCount;
		itemRepresentation = new GameObject[inventorySpace];

		for (int a = 0; a < inventorySpace; a++)
        {
			itemRepresentation[a] = panelSpot.transform.GetChild(a).gameObject;
		}

		ClearInventory();
	}

	// Update is called once per frame
	void Update()
	{
		if (gameStatus.itemActivated)
        {
			if(gameStatus.itemEquipable)
            {
				EquipItem();

            }
			else
			{
				ConsumeItem();				
			}
			gameStatus.itemActivated = false;
			//gameStatus.itemID = -1;
			gameStatus.itemName = "";
			gameStatus.itemUsed = true;
		}
		if (!gameStatus.itemSelected)
		{
			if (gameStatus.inventoryVisible)
			{
				canvasGroup.interactable = true;
				canvasGroup.blocksRaycasts = true;
				canvasGroup.alpha = 1f;
			}
			else
			{
				canvasGroup.interactable = false;
				canvasGroup.blocksRaycasts = false;
				canvasGroup.alpha = 0f;
			}
		}
        else
        {
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
		}
	}

	public void AddItem(GameObject item)
    {
		// need to add check when inventory is full
		bool itemAdded = false;
		int a = 0;
		items.Add(item);
		objectAsItem equipmentScript = item.GetComponent<objectAsItem>();
		InventoryItem thisItem = equipmentScript.myItem;
		while (!itemAdded && a < inventorySpace)
        {
			ItemSlot slotScript = itemRepresentation[a].GetComponent<ItemSlot>();
			if (!slotScript.empty)
            {
				if (slotScript.itemID == thisItem.itemID)
                {
					itemAdded = true;
					slotScript.itemCount++;
					itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = slotScript.itemCount + "";
					//itemRepresentation[a].transform.GetChild(1).GetComponent<Text>().text = slotScript.itemName + ": " + thisItem.itemDescription;
				}
            }
			a++;
        }
		if (!itemAdded)
        {
			a = 0;
			while (!itemAdded && a < inventorySpace)
			{
				ItemSlot slotScript = itemRepresentation[a].GetComponent<ItemSlot>();
				if (slotScript.empty)
                {
					itemAdded = true;
					slotScript.itemCount = 1;
					slotScript.itemID = thisItem.itemID;
					slotScript.empty = false;
					slotScript.itemName = thisItem.itemName;
					slotScript.itemDescription = thisItem.itemDescription;
					if (thisItem.itemType == InventoryItem.ItemType.gear || thisItem.itemType == InventoryItem.ItemType.weapon)
                    {
						slotScript.equipable = true;
					}
					else
                    {
						slotScript.equipable = false;
                    }
					itemRepresentation[a].transform.GetComponent<Image>().sprite = thisItem.itemPNG;
					itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = slotScript.itemCount + "";
					itemRepresentation[a].transform.GetChild(1).GetComponent<Text>().text = slotScript.itemName + ": " + thisItem.itemDescription;
				}
				a++;
			}
		}
	}

	public void EquipItem()
    {
		int a = System.Array.IndexOf(itemRepresentation, gameStatus.slotObject);
		ItemSlot slotScript = itemRepresentation[a].GetComponent<ItemSlot>();

		foreach (GameObject searchedItem in items)
		{
			objectAsItem equipmentScript = searchedItem.GetComponent<objectAsItem>();
			InventoryItem thisItem = equipmentScript.myItem;
			if (thisItem.itemID == slotScript.itemID)
			{
				gameStatus.inventoryItem = searchedItem;
				break;
			}
		}
	}

	public void ConsumeItem()
    {
		int a = System.Array.IndexOf(itemRepresentation, gameStatus.slotObject);
		ItemSlot slotScript = itemRepresentation[a].GetComponent<ItemSlot>();
		slotScript.itemCount--;

		if (slotScript.itemID == 10)
        {
			gameStatus.healthAdded = 50;
		}

		if (slotScript.itemID == 11)
		{
			gameStatus.manaAdded = 50;
		}

		foreach (GameObject searchedItem in items)
        {
			objectAsItem equipmentScript = searchedItem.GetComponent<objectAsItem>();
			InventoryItem thisItem = equipmentScript.myItem;
			if (thisItem.itemID == slotScript.itemID)
            {
				RemoveItem(searchedItem);
				Destroy(searchedItem);
				break;
			}
		}
		if (slotScript.itemCount == 0)
		{
			slotScript.empty = true;
			slotScript.itemID = -1;
			itemRepresentation[a].transform.GetComponent<Image>().sprite = empty;
			itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = "";
		}
		else
		{
			itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = slotScript.itemCount + "";
		}
	}

	public void RemoveItem(GameObject item)
	{
		//incomplete
		items.Remove(item);
	}

	void ClearInventory()
	{
		for (int a = 0; a < inventorySpace; a++)
		{
			itemRepresentation[a].transform.GetComponent<Image>().sprite = empty;
			itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = "";
		}
	}

	void UpdateInventoryTest()
	{
		for (int a = 0; a < items.Count; a++)
		{
			objectAsItem equipmentScript = items[a].GetComponent<objectAsItem>();
			InventoryItem thisItem = equipmentScript.myItem;

			itemRepresentation[a].transform.GetComponent<Image>().sprite = empty;
			itemRepresentation[a].transform.GetChild(0).GetComponent<Text>().text = "2";
		}
	}

	void SecondTest()
	{
		objectAsItem tempScript = items[0].GetComponent<objectAsItem>();
		if (tempScript == null)
		{
			Debug.Log("null script");
		}

		InventoryItem temp2 = tempScript.myItem;
		if (temp2 == null)
		{
			Debug.Log("null scriptable object");
		}

		empty = tempScript.myItem.itemPNG;
		if (empty == null)
        {
			Debug.Log("null image");
        }
	}
}
