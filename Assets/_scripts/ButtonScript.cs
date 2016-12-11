using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

    public void OnMouseDown ()
    {
        Application.LoadLevel("Level1");
        //Debug.Log("Button has been pressed");
    }
	
	// Update is called once per frame
	void Update () {
    
	}
}
