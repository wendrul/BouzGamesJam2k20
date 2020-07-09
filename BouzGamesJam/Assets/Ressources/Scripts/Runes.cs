using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runes : MonoBehaviour
{
    public Element Element { get; set; }
    public int id;

    //todo: When the element is removed it should go back to null

    // Start is called before the first frame update
    void Start()
    {
        Element = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (id == 0 && Element != null)
        {
            Debug.Log(Element.id);
        }
    }
}