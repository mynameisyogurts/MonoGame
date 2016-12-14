using UnityEngine;
using System.Collections;

// ONLY BEING USED TO DRIVE KeyUIPanel
public class UISpaceComponent : MonoBehaviour {

    InventoryUISpace uiSpace;
    KeyUIPanel uiPanel;

	// Use this for initialization
	void Start () {
        uiSpace = new InventoryUISpace();
        SpriteRenderer cacheSprite = gameObject.GetComponent<SpriteRenderer>();
        uiSpace.color = cacheSprite.color;
        uiSpace.sprite = cacheSprite.sprite;
        uiSpace.name = gameObject.name;
        uiPanel = GameObject.Find("KeyUI").GetComponent<KeyUIPanel>();
    }

    void OnDestroy()
    {
        if (uiPanel != null)
        {
            uiPanel.AddUIItem(uiSpace);
        }
    }
}
