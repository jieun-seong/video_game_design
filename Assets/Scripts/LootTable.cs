using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Loot
{
    public string name;
    public GameObject drop;
    public int dropChance;
    public int minCount;
    public int maxCount;

    public int count { get; set; }
}

[CreateAssetMenu]
public class LootTable : ScriptableObject
{
    public Loot[] drops;

    public ArrayList getLoot()
    {
        ArrayList dropList = new ArrayList();
        float rng = Random.Range(0.0f, 100.0f);

        foreach (Loot l in drops)
        {
            if (rng <= l.dropChance)
            {
                l.count = getQuantity(l);
                dropList.Add(l);
            }
        }

        return dropList;
    }

    public int getQuantity(Loot loot)
    {
        return Random.Range(loot.minCount, loot.maxCount);
    }
}
