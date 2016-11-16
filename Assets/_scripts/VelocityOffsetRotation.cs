using UnityEngine;
using System.Collections;

// Offsets component to it's parent
public class VelocityOffsetRotation : MonoBehaviour {

    // Player rigid body. DO NOT MODIFY THIS FROM HERE!!!
    public Rigidbody2D parentRB;

    // Position of Trail Piece
    Transform myTransform;

    // Amount to offset the trail position by
    public float MovementOffset;

	// Use this for initialization
	void Start () {
        // Get our transform and the player RB
        myTransform = this.transform;
    }
	
	// Update is called once per frame
	void Update () {
        myTransform.up = parentRB.velocity;
    }
}
