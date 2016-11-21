using UnityEngine;
using System.Collections;

public class HealthComponent : MonoBehaviour {

    // Stores the number of health points, defaults to 100
    [SerializeField]
    private int healthCount = 100;

	// Use this for initialization
	void Start () {
	
	}

    // Method to change the amount of health the health component has
    // Pass negative values to deal damage, pass positive values to give health
    public void ChangeHealth(int changeAmt)
    {
        healthCount += changeAmt;
    }
	
	// Update is called once per frame
	void Update () {
	    if(healthCount <= 0)
        {
            // Destroy gameobject with component on kill, REPLACE THIS WITH A BETTER SYSTEM USING
            // UnityEngine.Events LATER
            Destroy(this.gameObject);
        }
	}
}
