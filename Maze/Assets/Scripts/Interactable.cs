
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius;

    bool inTrigger;

    SphereCollider sphere;

    private void Awake()
    {
        sphere = GetComponent<SphereCollider>();
        sphere.radius = radius;
        sphere.isTrigger = true;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //display UI for player
            //Debug.Log("Can Interact");

            if (Input.GetKeyDown(KeyCode.F))
            {
                //if player presses "F" they pick up the Item
                Debug.Log("Picked Up Item");

            }
        }

    }


}
