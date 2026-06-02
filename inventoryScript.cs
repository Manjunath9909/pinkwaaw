using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class inventoryScript : MonoBehaviour
{
    [Serializable]
    public struct itemsStored
    {
        public string itemID;
        public int count;
    }

    [SerializeField]
    private List<itemsStored> items1 = new List<itemsStored>();

    public void addItem()
    {

    }

    public void removeItem()
    {

    }
}
