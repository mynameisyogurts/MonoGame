using UnityEngine;
using System.Collections;

// Moves attached object back and forward between starting location and target location
public class MoveToComponent : MonoBehaviour {

    public Transform targetLocation;
    public float speed;

    // Our original position (where we start)
    Vector3 originalPosition;
    Vector3 targetPosition;
    Vector3 currentPosition;

    // Move using rigidbody or transform
    public bool useRigidbody = false;

    Rigidbody2D rb;

    void Start()
    {
        // Store our orignal position on start
        targetPosition = new Vector3(targetLocation.position.x, targetLocation.position.y,
            targetLocation.position.z);
        currentPosition = targetPosition;
        originalPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float step = speed * Time.fixedDeltaTime;
        Vector3 nF3 = Vector3.MoveTowards(transform.position, currentPosition, step);
        if (useRigidbody)
        {
            Vector2 nextFrame = new Vector2(nF3.x, nF3.y);
            rb.MovePosition(nextFrame);
        }
        else
        {
            transform.position = nF3;
        }

        if(transform.position == currentPosition)
        {
            currentPosition = originalPosition;
        }

        if (transform.position == originalPosition)
        {
            currentPosition = targetPosition;
        }
    }
}
