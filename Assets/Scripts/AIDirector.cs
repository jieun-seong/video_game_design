using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDirector : MonoBehaviour
{
    public bool Enabled;
    private float timer;
    public GameObject[] spawn;
    public GameObject[] spawnOutVillage;
    public GameObject zomb;
    public int state;
    public Quest quest;

    public int zombKills = 0;
    public int zombsTotal = 1;
    public int dangerLVL = 0;
    public int maxZombies = 0;
    public GameObject player;
    public GameObject village;

    //controls
    public int absmax = 70;
    public float healthMod = 1f;
    public float speedMod = 1f;

    void Update()
    {
        if (dangerLVL >= 70) {
            quest.ChangeQuest("Too many zombies! Look for a safe house!",4, new Vector3(5200, 37, 5000));
            GameObject palettes = GameObject.Find("Palettes");
            palettes.SetActive(true);
        }
        switch (state) {
            case 1:
                if(dangerLVL < absmax) {
                    maxZombies = dangerLVL;
                } else {
                    maxZombies = absmax;
                }
                dangerLVL = 1 + zombKills/2;
                if(Enabled) {
                    if(timer <= 0 && zombsTotal < maxZombies) {
                        spawnZomVillage();
                        timer = Random.Range(7f/dangerLVL, 15f/dangerLVL);
                    } else if(zombsTotal < dangerLVL){
                        timer -= Time.deltaTime;
                    } else {
                        timer = 10f/dangerLVL;
                    }
                }
                if(Vector3.Distance(player.transform.position, village.transform.position) > 250) state = 2;
                break;
            case 2:
                if(dangerLVL < absmax) {
                    maxZombies = dangerLVL;
                } else {
                    maxZombies = absmax;
                }
                dangerLVL = 1 + zombKills/2;
                if(Enabled) {
                    if(timer <= 0 && zombsTotal < maxZombies) {
                        spawnZomForest();
                        timer = Random.Range(7f/dangerLVL, 15f/dangerLVL);
                    } else if(zombsTotal < dangerLVL){
                        timer -= Time.deltaTime;
                    } else {
                        timer = 10f/dangerLVL;
                    }
                }
                if(Vector3.Distance(player.transform.position, village.transform.position) < 250) state = 1;
                break;
        }
    }

    public void spawnZomVillage() {
        float health = 10 + dangerLVL * 2;
        float speed =2.5f*((50 * dangerLVL/20) + 30)/80f;
        zombsTotal++;
        GameObject newGuy = Instantiate(zomb);
        int Zomran = Random.Range(0, spawn.Length);
        newGuy.transform.position = spawn[Zomran].transform.position;
        newGuy.transform.GetComponent<ZombieControlScript>().original = false;
        newGuy.transform.GetComponent<ZombieControlScript>().setHealth((int)(health * healthMod));
        newGuy.transform.GetComponent<ZombieControlScript>().setSpeed(speedMod * speed);
        newGuy.transform.GetComponent<ZombieControlScript>().setDespawn(30);
    }

    public void spawnZomForest() {
        float health = 50 + dangerLVL/20;
        float speed =2.5f*((50 * dangerLVL/20) + 30)/80f;
        zombsTotal++;
        GameObject newGuy = Instantiate(zomb);
        int Zomran = Random.Range(0, spawnOutVillage.Length);
        newGuy.transform.position = spawnOutVillage[Zomran].transform.position;
        newGuy.transform.GetComponent<ZombieControlScript>().original = false;
        newGuy.transform.GetComponent<ZombieControlScript>().setHealth((int)(health * healthMod));   
        newGuy.transform.GetComponent<ZombieControlScript>().setSpeed(speedMod * speed);
        newGuy.transform.GetComponent<ZombieControlScript>().setDespawn(30); 
    }
}
