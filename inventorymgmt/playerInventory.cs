using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

// this ithe player inventory script
// will hold and manipulate a list of items owned by the player 
// can edit, remove and add items to the players inventory 

public class playerInventory : MonoBehaviour
{
    [Serializable]
    public struct itemsStored
    {
        public string itemName;
        public int count;
    }

    [SerializeField]
    private List<itemsStored> items = new List<itemsStored>();

    // main function call to add an item into the list
    public void addItem(string iname, int icount)
    {
        if (itemexists(iname))
        {
            updateItemCount(iname, icount, 1);
        }
        else
        {
            items.Add(makeItemToStore(iname, icount));
        }
    }

    public void removeItem(string iname, int icount)
    {
        // need to check item existence 

        if (itemexists(iname))
        {
            updateItemCount(iname, icount, 2);
        }
    }

    // function call to update the item count
    private bool updateItemCount(string iname, int icount, int operation)
    {
        int index = items.FindIndex(item => item.itemName == iname);
        if (index >= 0)
        {
            switch (operation)
            {
                case 1:
                    items[index] = makeItemToStore(iname, items[index].count + icount);
                    break;
                case 2:
                    // need to check item count and decrease 
                    // if item count is 1, then remove the item from the list
                    if (items[index].count == 1 || items[index].count == icount)
                    {
                        items.Remove(new itemsStored { itemName = iname, count = 1 });
                        break;
                    }
                    if (items[index].count > icount)
                    {
                        items[index] = makeItemToStore(iname, items[index].count - icount);
                    }
                    break;
                default:
                    print("we have no function to perform");
                    break;
            }
        }
        return true;
    }

    // check if item exists or not
    private bool itemexists(string iname)
    {
        if (items.Any(item => item.itemName == iname))
        {
            print("item exists " + iname);
            return true;
        }
        else
        {
            print("item does not exist");
            return false;
        }
    }

    static itemsStored makeItemToStore(string ItemName, int Count)
    {
        // we ready an item to be entered or updated into the list 
        itemsStored newItem = new itemsStored { itemName = ItemName, count = Count };
        return newItem;
    }

    public void writeToMemory()
    {

    }

    public void readFromMemory()
    {

    }
}
