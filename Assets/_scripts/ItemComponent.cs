using UnityEngine;
using System.Collections;

// Class for describing a single item
public class ItemComponent : MonoBehaviour {

    [SerializeField]
    private string itemName;

    [SerializeField]
    private int itemQuantity;

    // Collision logic
    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            hit.gameObject.GetComponent<InventoryComponent>().AddItem(itemName, itemQuantity);
            Destroy(this.gameObject);
        }
    }
}
