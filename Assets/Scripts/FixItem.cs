using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixItem : MonoBehaviour
{
    public GameObject objBroken;
    public GameObject objFixed;
    public GameObject effects;
    public SpawnItem spawner;

    void Start()
    {
        objBroken.SetActive(true);
        objFixed.SetActive(false);
        spawner = FindObjectOfType<SpawnItem>();
    }

    public void FixThis()
    {
        objBroken.SetActive(false);
        objFixed.SetActive(true);
        effects.SetActive(true);
        spawner.Done();
        this.enabled = false;
    }
}
