using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus.playerDead || gameStatus.playerWon)
        {
            string endStatus = "";
            if (gameStatus.playerDead)
            {
                endStatus = "You have died";
            }
            if (gameStatus.playerWon)
            {
                endStatus = "You have won";
            }

            transform.GetComponent<Text>().text = endStatus;

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
