using UnityEngine;
using System.Collections;

public class PlayerMovemet : MonoBehaviour
{
    private Rigidbody2D myRB;
    public float MoveSpeed = 5;

	// Use this for initialization
	void Start ()
    {
        myRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	     
	}

    void FixedUpdate ()
    {
        myRB.AddForce(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * MoveSpeed, ForceMode2D.Force);
    }
}
