using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class ItemSelectedToggle : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus.itemSelected)
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
            //this.transform.GetChild(2).GetComponent<Text>().text = gameStatus.itemName + "\n" + "selected";
        }
        else
        {
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.alpha = 0f;
        }
    }
}
