using UnityEngine;
using System.Collections;

public class LevelExitComponent : MonoBehaviour {

    [SerializeField]
    private string nextLevel;

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.gameObject.tag == "Player")
        {
            Application.LoadLevel(nextLevel);
        }
    }
}
