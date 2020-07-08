using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required when using Event data.
using TMPro;

public class InventorySlot : MonoBehaviour
{

    public GameObject item;
    public GameObject itemTable;
    public TextMeshProUGUI myText;
    private bool firstInstance = true;

    public int itemstacks;

    public void Start()
    {

    }
    private void Update()
    {
        myText.SetText(itemstacks.ToString());
    }
    public void InstanceObject()
    {
        if (itemstacks > 0)
        {
            itemstacks--;
            if (firstInstance == false)
            {
            }
            if (firstInstance == true)
            {
//                item.GetComponent<Material>().AddStack();
                Instantiate(item, new Vector3(itemTable.transform.position.x, itemTable.transform.position.y, item.transform.position.z), Quaternion.identity);
                firstInstance = false;
            }
        }
    }
}