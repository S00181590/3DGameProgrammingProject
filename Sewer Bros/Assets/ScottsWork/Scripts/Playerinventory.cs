using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinventory : MonoBehaviour
{
    public SaveableInventory Inventory = new SaveableInventory();

    // for testing 
    #region 
    public NpcInventory TestInventoryToBuyOff;
    public InventoryPanel testDisplay;
    void Start()
    {
        Inventory.Load("PlayerInventory");

        if (Inventory.Items.Count > 0)
            testDisplay.SetInventory(Inventory.Items);
    }
    #endregion

    //testing 
    #region 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Inventory.AddItem(0);
            //Inventory.AddItem("Health Potion");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Inventory.AddItem(1);
            //Inventory.AddItem("Magic Potion");
        }

        //But a health potion from the NPC
        if (Input.GetKeyDown(KeyCode.B))
        {
            Item item = TestInventoryToBuyOff.BuyItem(0);

            if (item != null)
                Inventory.AddItem(item);
        }
        //saveing the players inventory 
        if (Input.GetKeyDown(KeyCode.S))
        {
            Inventory.Save("PlayerInventory");
        }

        //loading the players inventory 
        if(Input.GetKeyDown(KeyCode.L))
        {
            Inventory.Load("PlayerInventory");
        }
    }
    #endregion
}
