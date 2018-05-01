using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new obstacle",menuName ="Inventory/Create Obstacle")]
public class Obstacle : ScriptableObject {

    new public string name;

    public GameObject gameobject;

    public int obstacleNumber;

}
