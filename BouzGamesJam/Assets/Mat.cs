using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mat : MonoBehaviour
{
    public TextMeshPro myText;
    private int stacks;
    private int id;
    private bool snapBin;


    void Update()
    {
        myText.SetText(stacks.ToString());
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
