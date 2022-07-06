using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAccess : MonoBehaviour
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

    public void InventoryButton()
    {
        gameStatus.inventoryVisible = true;
    }
}
