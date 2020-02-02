using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairButton : MonoBehaviour
{
    private FixItem theItem;

    void Update()
    {
        if(theItem == null)
            theItem = FindObjectOfType<FixItem>();
    }

    public void ButtonClicked(string itemTag)
    {         
        if (theItem.gameObject.tag == itemTag)
        {
            theItem.FixThis();
        }
    }
}
