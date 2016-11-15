using UnityEngine;
using System.Collections;

// Offsets component to it's parent
public class VelocityOffsetPosition : MonoBehaviour {

    // Player rigid body. DO NOT MODIFY THIS FROM HERE!!!
    public Rigidbody2D parentRB;

    // Position of Trail Piece
    Transform myTransform;
    Vector2 startPos;

    // Amount to offset the trail position by
    public float MovementOffset;

	// Use this for initialization
	void Start () {
        // Get our transform and the player RB
        myTransform = this.transform;

        // Get local start position
        startPos = new Vector2(myTransform.localPosition.x, myTransform.localPosition.y);
    }
	
	// Update is called once per frame
	void Update () {
        float xOffset = parentRB.velocity.x;
        float yOffset = parentRB.velocity.y;
        myTransform.localPosition = new Vector2(startPos.x - (xOffset * MovementOffset), startPos.y - (yOffset * MovementOffset));
    }
}
