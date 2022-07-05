using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class InventoryToggle : MonoBehaviour
{
	private CanvasGroup canvasGroup;
	public GameStatus gameStatus;

    // Start is called before the first frame update
    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
		gameStatus.inventoryVisible = false;
	}

	// Update is called once per frame
	void Update()
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
}
