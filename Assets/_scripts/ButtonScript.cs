using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public void OnMouseDown ()
    {
        Application.LoadLevel("Level1");
        //Debug.Log("Button has been pressed");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
    
	}
}
