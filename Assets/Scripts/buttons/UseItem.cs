using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus.itemEquipable)
        {
            //transform.GetChild(0).GetComponent<Text>().text = "Equip Item";
        }
    }

    public void UseItemButton()
    {
        gameStatus.itemSelected = false;        
        if (gameStatus.itemEquipable)
        {
            gameStatus.itemActivated = false;
            gameStatus.itemEquiped = true;
        }
        else
        {
            gameStatus.itemActivated = true;
        }
    }
}
