using UnityEngine;
using System.Collections;

public class DoorComponent : MonoBehaviour {
    public string itemname;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
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
