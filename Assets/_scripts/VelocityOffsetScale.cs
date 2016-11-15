using UnityEngine;
using System.Collections;

// Offsets component to it's parent
public class VelocityOffsetScale : MonoBehaviour
{

    // Player rigid body. DO NOT MODIFY THIS FROM HERE!!!
    public Rigidbody2D parentRB;

    // Position of Trail Piece
    Transform myTransform;
    Vector2 startScale;

    // Amount to offset the trail position by
    public Vector2 ScaleOffset;

    // Use this for initialization
    void Start()
    {
        // Get our transform and the player RB
        myTransform = this.transform;

        // Get local start position
        startScale = new Vector2(myTransform.localScale.x, myTransform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        float xOffset = parentRB.velocity.x;
        float yOffset = parentRB.velocity.y;

        myTransform.localScale = startScale + new Vector2(xOffset * ScaleOffset.x, xOffset * ScaleOffset.x);
    }
}
