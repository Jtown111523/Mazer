using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {


    #region Singleton Pattern
    public static InventoryManager instance;

	void Awake () {

        if (instance != null)
            Debug.LogWarning("There is more than one Inventory Manager in the Scene");

        instance = this;
		
	}
    #endregion

    public List<Item> items = new List<Item>(); 

    public void addItem(Item item)
    {
        items.Add(item);
    }

    public void removeItem(Item item)
    {
        items.Remove(item);
    }
}
