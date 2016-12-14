using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// Hacky way of doing an "objects held" UI
// Seriously this is a terible way to do this
public class InventoryUISpace
{
    public string name;

    // Stores the items image (this should be greyscale)
    public Sprite sprite;

    // Stores the color to draw set on the SpriteRenderer
    public Color color;

    // Order of the the item in the Key/Inventory panel
    public int position;
}

public class KeyUIPanel : MonoBehaviour
{
    List<InventoryUISpace> uiItems;
    int lastPosition = 0;

    public void AddUIItem(InventoryUISpace toAdd)
    {
        toAdd.position = lastPosition;
        lastPosition++;
        uiItems.Add(toAdd);
        UpdateUI();
    }

    void UpdateUI()
    {
        // Destroy all existing childern of the item
        List<GameObject> existingElements = new List<GameObject>();
        foreach (Transform child in transform)
            existingElements.Add(child.gameObject);
        existingElements.ForEach(child => Destroy(child));

        // Add new stuff
        for (int i = 0; i < uiItems.Count; i++)
        {
            GameObject newUIItem = new GameObject();
            newUIItem.transform.parent = gameObject.transform;
            newUIItem.transform.localPosition = new Vector3(0 + (uiItems[i].position * 50), 0, 0);

            newUIItem.name = uiItems[i].name;

            Image newImage = newUIItem.AddComponent<Image>();
            newImage.rectTransform.anchorMin = new Vector2(0, 0.5f);
            newImage.rectTransform.anchorMax = new Vector2(0, 0.5f);
            newImage.rectTransform.pivot = new Vector2(0.2f, 0.5f);
            newImage.rectTransform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            newImage.sprite = uiItems[i].sprite;
            newImage.color = uiItems[i].color;
        }
    }

    void Start()
    {
        uiItems = new List<InventoryUISpace>();
        //AddUIItem("test", null, Color.green, 0);
    }
}
