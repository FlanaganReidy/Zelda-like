using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Inventory Information")]
    public PlayerInventory playerInventory;
    [SerializeField] private GameObject blankInventorySlot;
    [SerializeField] private GameObject viewPort;
    public void MakeInventorySlot(){
        if(playerInventory){
            for(int i = 0; i<playerInventory.myInventory.Count; i++)
            {
                GameObject temp = Instantiate(blankInventorySlot, viewPort.transform.position, Quaternion.identity);
                temp.transform.SetParent(viewPort.transform);
                InventorySlot newSlot = temp.GetComponent<InventorySlot>();
                if (newSlot){
                    newSlot.SetupItem(playerInventory.myInventory[i], this);
                }
            }
        }

    }
    void Start()
    {
        MakeInventorySlot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
