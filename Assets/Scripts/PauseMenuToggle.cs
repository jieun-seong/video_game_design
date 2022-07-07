using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class PauseMenuToggle : MonoBehaviour
{
	private CanvasGroup canvasGroup;
	public GameStatus gameStatus;

	// Start is called before the first frame update
	void Awake()
    {
		canvasGroup = GetComponent<CanvasGroup>();
		gameStatus.menuVisible = false;
	}

    // Update is called once per frame
    void Update()
    {
		if (gameStatus.inventoryVisible)
		{
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
			canvasGroup.alpha = 0f;
		}
		if (gameStatus.menuVisible && !gameStatus.inventoryVisible)
		{
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
			canvasGroup.alpha = 1f;
		}
		if (Input.GetKeyUp(KeyCode.Escape) && !gameStatus.inventoryVisible && !gameStatus.playerDead)
		{
			if (canvasGroup.interactable)
			{
				Cursor.visible = false;
        		Cursor.lockState = CursorLockMode.Locked;
				Time.timeScale = 1f;
				canvasGroup.interactable = false;
				canvasGroup.blocksRaycasts = false;
				canvasGroup.alpha = 0f;
				gameStatus.menuVisible = false;
			}
			else
			{
				Cursor.visible = true;
        		Cursor.lockState = CursorLockMode.None;
				Time.timeScale = 0f;
				canvasGroup.interactable = true;
				canvasGroup.blocksRaycasts = true;
				canvasGroup.alpha = 1f;
				gameStatus.menuVisible = true;
			}
		}
	}
}
