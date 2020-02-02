using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    float timer = 30;
    int timeDis;
    public Text timeText;
    public GameObject finish;

    void OnEnable()
    {
        timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeDis = Mathf.CeilToInt(timer);
        timeText.text = "" + timeDis;
        if(timer <= 0)
        {
            gameObject.SetActive(false);
            finish.SetActive(true);            
        }
    }
}