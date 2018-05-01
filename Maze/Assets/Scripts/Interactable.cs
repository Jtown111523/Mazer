using UnityEngine.UI;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius;

    bool inTrigger;

    SphereCollider sphere;

    public Item item;

    public Text interactUI;

    private void Awake()
    {
        sphere = GetComponent<SphereCollider>();
        if (sphere != null)
        {
            sphere.radius = radius;
            sphere.isTrigger = true;
        }

        interactUI.enabled = false;
    }

    private void OnTriggerStay(Collider col)
    {
            Interact(col);
        
    }

    private void OnTriggerExit(Collider other)
    {
        interactUI.enabled = false;
    }

    public virtual void Interact(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //display UI for player

            interactUI.enabled = true;

            //Debug.Log("Can Interact");

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (this.gameObject.tag == "Item")
                {
                    //if player presses "F" they pick up the Item
                    Debug.Log("Picked Up Item");
                    InventoryManager.instance.addItem(item);
                    //destroy item
                    Destroy(this.gameObject);
                }
                else if (this.gameObject.tag == "Obstacle")
                {
                    Debug.Log("MoveObstacle");
                    InventoryManager.instance.removeItem(item);
                    //destroy obstacle
                    Destroy(this.gameObject);

                }
                else if(this.gameObject.tag == "Untagged")
                {
                    Debug.LogWarning("Object Does not have a tag");
                }
                interactUI.enabled = false;
            }

        }
    }


}
