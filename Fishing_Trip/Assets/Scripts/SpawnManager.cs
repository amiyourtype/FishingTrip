using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<Fish> spawnList = new List<Fish>();
    public List<Fish> stageOneSpawns = new List<Fish>();
    public List<Fish> stageTwoSpawns = new List<Fish>();
    public List<Fish> stageThreeSpawns = new List<Fish>();
    public List<Fish> stageFourSpawns = new List<Fish>();
    public List<Fish> stageFiveSpawns = new List<Fish>();
    private List<Fish> pool;
    private List<Fish> currentFish = new List<Fish>();
    private int timer;
    public int spawnTime;
    public int maxFish;
    // Start is called before the first frame update
    void Start()
    {
        createPool(stageOneSpawns);
        for(int i = 0; i < maxFish; i++)
        {
            makeNewFish();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer > spawnTime)
        {
            timer -= spawnTime;
            makeNewFish();
        }
    }

    public void updatePool(int poolID)
    {
        if(poolID == 2)
        {
            createPool(stageTwoSpawns);
        }
        else if(poolID == 3)
        {
            createPool(stageThreeSpawns);
        }
        else if(poolID == 4)
        {
            createPool(stageFourSpawns);
        }
        else if(poolID == 5)
        {
            createPool(stageFiveSpawns);
        }
        makeNewFish();
        makeNewFish();
        makeNewFish();
    }

    private void createPool(List<Fish> spawnList)
    {
        pool = new List<Fish>();
        foreach (Fish fish in spawnList)
        {
            for (int i = 0; i < fish.rarity; i++)
            {
                pool.Add(fish);
            }
        }
    }
    private void makeNewFish()
    {
        Fish fish = Instantiate(pool[Random.Range(0, pool.Count)]);
        //fish.transform.position = new Vector3(Random.Range(-10, 11), Random.Range(-10, 11), 0);
        fish.transform.position = new Vector3(Random.Range(0, 1001), Random.Range(0, 563), 50);
        currentFish.Add(fish);
    }
}
