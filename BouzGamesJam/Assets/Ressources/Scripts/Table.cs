﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] runes = new GameObject[4];
    private List<Recipe> recipes;

    void Start()
    {
        recipes = Recipes.GetRecipes();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Transmute()
    {
        
    }

    public List<Element> GetElementsInTable()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.dirt);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.sand);
        elements.Add(temp);
        return elements;
    }

    public bool VerifyTransmutation()
    {
        List<Element> elements = GetElementsInTable();
        foreach (Recipe recipe in recipes)
        {
            List<Element> temp = recipe.materials;

        }
        return false;
    }
}