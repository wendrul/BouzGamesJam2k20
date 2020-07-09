using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mat : MonoBehaviour
{
    public TextMeshPro myText;
    private int stacks;
    public int Quantity { get; set; }
    public int id;
    private bool snapBin;


    void Update()
    {
        myText.SetText(stacks.ToString());
        Quantity = stacks;
    }

    public void AddStack()
    {
        stacks++;
    }

    public void SubstractStack()
    {
        stacks--;
    }
}
