using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("UI Stuff")]
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private Image itemImage;
    
    [Header("Variables for the item")]
    public InventoryItem thisItem;
    public InventoryManager thisManager;

    public void SetupItem(InventoryItem newItem, InventoryManager itemManager)
    {
        thisItem = newItem;
        thisManager = itemManager;

        if(thisItem){
            itemImage.sprite = thisItem.itemImage;
            itemNameText.text = thisItem.itemName;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
