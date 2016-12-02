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

    // Threshold of movement amount required to trigger change
    [SerializeField]
    float Threshold;

	// Use this for initialization
	void Start () {
        // Get our transform and the player RB
        myTransform = this.transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (parentRB.velocity.magnitude >= Threshold)
        {
            myTransform.up = parentRB.velocity;
        }

        // Hacky bugfix to keep rotation locked to Z-axis only
        myTransform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z);
    }
}
