using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required when using Event data.
using TMPro;

public class InventorySlot : MonoBehaviour
{

    public GameObject item;
    public GameObject itemTable;
    private GameObject mat;
    public TextMeshProUGUI myText;
    private bool firstInstance = true;

    public int itemstacks;
    private int maxStacks;

    public void Start()
    {
        maxStacks = itemstacks;
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
                mat.GetComponent<Mat>().AddStack();
            }
            if (firstInstance == true)
            {
                mat = Instantiate(item, new Vector3(itemTable.transform.position.x, itemTable.transform.position.y, item.transform.position.z), Quaternion.identity);
                mat.GetComponent<Mat>().AddStack();
                firstInstance = false;
            }
        }
    }

    public void LessMat()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (itemstacks < maxStacks)
            {
                itemstacks++;
                mat.GetComponent<Mat>().SubstractStack();
            }
        }
    }

    public void Recycle()
    {

    }
}