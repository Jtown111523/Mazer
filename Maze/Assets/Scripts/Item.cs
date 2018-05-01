using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new Item", menuName = "Inventory/Item Pickup")]
public class Item : ScriptableObject {


    new public string name = "New Item";

    public Sprite image;

    public float keyNumber;

    public GameObject gameobject;


}
