﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element
{
    public int quantity;
    public int rune;
    public int id;

    public Element(int aQuantity, int aRune, int aId)
    {
        quantity = aQuantity;
        rune = aRune;
        id = aId;
    }

    public Element(Mat  mat, int aRune)
    {
        quantity = mat.Quantity;
        rune = aRune;
        id = mat.id;
    }
}
