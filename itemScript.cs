using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    public string itemID;
    public string itemName;
    public string itemDescription;
    public bool tradable;
    public bool consumable;
    public int coinValue;
    public void updateName(string newName)
    {
        this.itemName = newName;
    }

    public void updateDescription(string newDescription)
    {
        this.itemDescription = newDescription;
    }

    public itemScript getItemDetails()
    {
        return this;
    }

    public void consume()
    {
        //put code here to replinishes health and wellbeing of the player
    }
}
