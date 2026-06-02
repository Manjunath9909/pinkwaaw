using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemLookUp : MonoBehaviour
{

    [Serializable]
    public struct toImport
    {
        public string itemID;
        public GameObject itemObject;
    }

    [SerializeField]
    private List<toImport> itemsToImport = new List<toImport>();

    public Dictionary<string, GameObject> itemsList = new Dictionary<string, GameObject>();

    void Start()
    {
        // add all items to the referencable list
        foreach (var item in itemsToImport)
        {
            itemsList.Add(item.itemID, item.itemObject);
        }
    }
}
