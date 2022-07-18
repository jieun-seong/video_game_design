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
        
    }

    public void UseItemButton()
    {
        gameStatus.itemSelected = false;
        gameStatus.itemActivated = true;
    }
}
