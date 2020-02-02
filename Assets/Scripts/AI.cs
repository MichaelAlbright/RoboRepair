using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject[] patrolPoints;
    public GameObject[] exits;
    NavMeshAgent nav;
    int counter;
    AISpawner spawner;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        counter = Random.Range(2, 5);
        nav.destination = patrolPoints[Random.Range(0, patrolPoints.Length)].transform.position;    
        spawner = FindObjectOfType<AISpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > 0)
        {
            if (Vector3.Distance(transform.position, nav.destination) < 0.5f)
            {
                counter--;
                if(counter > 0)
                    nav.destination = patrolPoints[Random.Range(0, patrolPoints.Length)].transform.position;
                else
                    nav.destination = exits[Random.Range(0, exits.Length)].transform.position;
            }
        }
        if(counter <= 0)
            if (Vector3.Distance(transform.position, nav.destination) < 1.0f)
            {
                spawner.SpawnAI();
                Destroy(gameObject);
            }
    }
}
