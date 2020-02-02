using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RandomSelect : MonoBehaviour
{
    public Items[] set;

    [Serializable]
    public class Items
    {
        public GameObject[] items;
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach(Items temp in set)
        {
            foreach(GameObject tempItem in temp.items)
            {
                tempItem.SetActive(false);
            }
            temp.items[UnityEngine.Random.Range(0, temp.items.Length)].SetActive(true);
        }
    }

}
