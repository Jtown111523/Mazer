using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteractable : Interactable {

    bool hasKey = false;

    public Obstacle obstacle;

    public override void Interact(Collider col)
    {
       foreach(Item item in InventoryManager.instance.items)
        {
            if(item.keyNumber == obstacle.obstacleNumber)
            {
                hasKey = true;
            }
        }

        if (hasKey == true)
        {
            //run if player has item in inventory only
            base.Interact(col);
        }

    }

}
