﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player Finished");
            //Debug.Log(InventoryManager.instance.items);
        }
    }


}
