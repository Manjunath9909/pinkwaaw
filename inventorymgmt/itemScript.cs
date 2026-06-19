using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//this script should be able to hold the info regarding a game object 

public class itemScript : MonoBehaviour
{
    // itemName and GameObject name in the editor should be the same
    public string itemName;
    public string itemID;
    public string itemDescription;

    public void updateItemInfo(string newName, string newItemID, string newDescription)
    {
        this.itemName = newName;
        this.itemID = newItemID;
        this.itemDescription = newDescription;
    }
}
