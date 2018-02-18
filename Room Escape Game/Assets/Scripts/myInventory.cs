using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myInventory : MonoBehaviour {

    public GameObject[] inventory = new GameObject[10];
    public Button[] InvButtons = new Button[10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //find the first open slot in the inventory
        for (int i = 0; i < inventory.Length; i++){
            if (inventory[i] == null){
                inventory[i] = item;
                //Update UI
                InvButtons[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(item.name + " was added");
                itemAdded = true;
                // Do something with the object
                item.SendMessage("DoInteraction");
                break;
            }
        }
        //inventory was full
        if (!itemAdded){
            Debug.Log("myInventory is full");
        }
    }

    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory [i] == item)
            {
                //we found the item - remove it
                inventory[i] = null;
                Debug.Log(item.name + " was removed from inventory");
                //Update UI
                InvButtons[i].image.overrideSprite = null;
                break;
            }
        }
    }
}
