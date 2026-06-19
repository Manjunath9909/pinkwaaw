using System.Collections.Generic;
using UnityEngine;

//this is a bank of all the items in the game. this is script shoukd answer read only asnwers like supplying info
//this scrips should not be allowed to add items to the bank 

public class items : MonoBehaviour
{
    public List<GameObject> allItems = new List<GameObject>();
}