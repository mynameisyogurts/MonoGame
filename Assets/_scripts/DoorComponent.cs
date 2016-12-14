using UnityEngine;
using System.Collections;

public class DoorComponent : MonoBehaviour {
    public string itemname;

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.tag == "Player")
        {

            InventoryComponent inv = hit.gameObject.GetComponent<InventoryComponent>();
            if (inv.GetKey(itemname)>=1)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
