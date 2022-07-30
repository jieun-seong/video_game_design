using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public int questInt;
    public string questString;
    public Vector3 loc;
    public Text txt;
    public GameObject player;
    private int dis;

    void Update() {
        dis = (int)Vector3.Distance(loc,player.transform.position);
        txt.text = "Current Objective: " + questString + " Distance:" + dis;
    }

    public void ChangeQuest(string quest, int num, Vector3 locat) {
        if(num > questInt) {
            questInt = num;
            questString = quest;
            loc = locat;
            txt.text = "Current Objective: " + quest;
        }
    }
}
