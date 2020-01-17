using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInventory : MonoBehaviour
{

    public List<int> ItemIDs;

    public List<Item> Items = new List<Item>();

    public InventoryPanel TestDisplay;

    // Start is called before the first frame update
    void Start()
    {
        foreach (int id in ItemIDs)
        {
            Item foundItem = GameManager.Instance.AllItemsInTheGame.GetItem(id);
            Items.Add(foundItem);
        }

        TestDisplay.SetInventory(ItemIDs);
    }

    public Item BuyItem(int itemID)
    {
        
            if (ItemIDs.Contains(itemID))
                return GameManager.Instance.AllItemsInTheGame.GetItem(itemID);
            else return null;
    }
         
}
