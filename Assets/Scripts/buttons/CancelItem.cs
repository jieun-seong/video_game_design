using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelItem : MonoBehaviour
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

    public void CancelItemButton()
    {
        gameStatus.itemSelected = false;
        gameStatus.itemID = -1;
        gameStatus.itemName = "";
    }
}
