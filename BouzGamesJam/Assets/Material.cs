using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Material : MonoBehaviour
{
    public TextMeshPro displaystack;
    public int itemNumber;
    // Start is called before the first frame update

    private void Start()
    {
            itemNumber = 0;
    }

    void Update()
    {
        displaystack.SetText(itemNumber.ToString());
    }

    public void AddStack()
    {
        itemNumber++;
        print(itemNumber);
    }
}
