using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{

    public Text txtName;//Name of item
    public Image imgIcon;//icon image
    public int ItemID; //id of item 

    public void SetItem(int itemID)
    {
        Item foundItem = GameManager.Instance.AllItemsInTheGame.GetItem(itemID);

        txtName.text = foundItem.Name;
        imgIcon.sprite = foundItem.Icon;
        imgIcon.color = foundItem.tint;

        ItemID = itemID;
    }
}
