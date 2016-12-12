using UnityEngine;
using System.Collections;

// Moves enemy when seen by player
public class EnemyComponent : MonoBehaviour
{
    public float speed;

    bool canMove = false;

    Rigidbody2D myRB;
    GameObject playerRef;

    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        myRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            float step = speed * Time.fixedDeltaTime;
            Vector3 nF3 = Vector3.MoveTowards(transform.position, playerRef.transform.position, step);
            Vector2 nextFrame = new Vector2(nF3.x, nF3.y);
            myRB.MovePosition(nextFrame);

            //myRB.velocity = (new Vector2(playerRef.transform.position.x,
              //  playerRef.transform.position.y) - myRB.position) * speed * Time.fixedDeltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.tag == "PlayerLight")
            canMove = true;
    }

    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.tag == "PlayerLight")
            canMove = false;
    }
}
