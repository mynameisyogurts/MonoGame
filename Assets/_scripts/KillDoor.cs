using UnityEngine;
using System.Collections;

public class KillDoor : MonoBehaviour {

    public EnemyComponent[] enemies;
    private int counter = 1;
    public TextMesh text;

	// Use this for initialization
	void Start () {
        counter = enemies.Length;
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].OnKill = Decrement;
        }
        UpdateText();
	}

    void UpdateText()
    {
        if (text != null)
        {
            text.text = counter.ToString();
        }
    }

    void Decrement()
    {
        counter -= 1; 
        if (counter <= 0)
        {
            Destroy(this.gameObject);
        }
        UpdateText();
    }
}
