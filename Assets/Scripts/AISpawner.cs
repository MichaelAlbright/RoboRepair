using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    public GameObject[] spawn;
    public GameObject[] ai;
    public int maxAi = 3;

    int tempCount;
    float timer = 3;

    public GameObject[] patrolPoints;
    public GameObject[] exits;

    void Start()
    {
        SpawnAI();
        tempCount = maxAi - 1;
    }

    void Update()
    {
        if(tempCount > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                tempCount--;
                timer = 3;
                SpawnAI();
            }
        }
    }

    public void SpawnAI()
    {
        int i = Random.Range(0, spawn.Length);
        GameObject temp = Instantiate(ai[Random.Range(0, ai.Length)], spawn[i].transform.position, spawn[i].transform.rotation);
        AI tempAI = temp.GetComponent<AI>();
        tempAI.patrolPoints = patrolPoints;
        tempAI.exits = exits;
    }
}
