using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRestart : MonoBehaviour
{
    [SerializeField] private GameStatus gameStatus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStatus.playerDead)
        {
            SceneManager.LoadScene("startGame");
            Time.timeScale = 1f;
        }
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene("startGame");
        Time.timeScale = 1f;
    }
}
