using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnItem : MonoBehaviour
{
    GameObject current;
    public bool done;
    public float newTimer = 3;
    float timer;
    int counter;
    public Text score;
    public Text finalScore;
    int previousNumber = 12;

    public GameObject[] items;

    void OnEnable()
    {
        timer = newTimer;
        counter = 0;
        done = false;
        if(current != null)
            Destroy(current);
    }

    // Update is called once per frame
    void Update()
    {
        if(done)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                Destroy(current);
                done = false;
                timer = newTimer;
            }
        }

        if (current == null)
        {
            int i = Random.Range(0, items.Length);
            if(i == previousNumber)
                i = Random.Range(0, items.Length);

            previousNumber = i;
            current = Instantiate(items[i], transform.position, transform.rotation);
            current.transform.parent = transform;
        }

        finalScore.text = "" + counter;
        score.text = "" + counter;
    }

    public void Done()
    {
        if (!done)
        {
            done = true;
            counter++;
            score.text = "" + counter;
        }
    }
}
