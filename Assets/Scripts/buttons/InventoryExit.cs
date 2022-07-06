using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryExit : MonoBehaviour
{
    public GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InventoryExitButton()
    {
        gameStatus.inventoryVisible = false;
    }
}
