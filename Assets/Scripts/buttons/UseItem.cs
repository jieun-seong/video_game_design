using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<Text>().text = "Use Item";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus.itemEquipable)
        {
            transform.GetChild(0).GetComponent<Text>().text = "Equip Item";
        }
        else
        {
            transform.GetChild(0).GetComponent<Text>().text = "Use Item";
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
