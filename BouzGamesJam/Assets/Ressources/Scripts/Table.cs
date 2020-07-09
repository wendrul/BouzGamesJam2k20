using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
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
        Recipe recipe = VerifyTransmutation();
        if (recipe != null)
        {
            print($"Succes: {recipe.id}");
        }
        else
            print("Failure");
    }

    public List<Element> GetElementsInTable()
    {
        List<Element> elements = new List<Element>();
        
        return elements;
    }

    public bool CompareElements(Element element1, Element element2, bool isRuneLocked)
    {
        if (isRuneLocked)
            return element1.id == element2.id && element1.quantity == element2.quantity && element1.rune == element2.rune;
        else
            return element1.id == element2.id && element1.quantity == element2.quantity;
    }


    private string GetRuneName(int id)
    {
        switch (id)
        {
            case 0:
                return "Fire";
            case 1:
                return "Air";
            case 2:
                return "earth";
            case 3:
                return "water";
            default:
                return null;
        }
    }


    public bool CompareToRecipe(List<Element> elements)
    {
        List<int> occupiedRunes = new List<int>();
        foreach (Element element in elements)
        {
            if (element.rune > -1)
            {
                Element temp = GameObject.Find(GetRuneName(element.rune)).GetComponent<Runes>().Element;
                if (temp != null && !occupiedRunes.Contains(element.rune) && CompareElements(element, temp, true))
                {
                    occupiedRunes.Add(element.rune);
                    continue;
                }
                else
                    return false;
            }
            else
            {
                int i = 0;
                while (i < 4)
                {
                    Element temp = GameObject.Find(GetRuneName(i)).GetComponent<Runes>().Element;
                    if (temp == null || occupiedRunes.Contains(i))
                    {
                        i++;
                        continue;
                    }
                    if (CompareElements(element, temp, false))
                    {
                        occupiedRunes.Add(i);
                        break;
                    }
                    i++;
                }
                if(i >= 4)
                    return false;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (!occupiedRunes.Contains(i))
            {
                if (GameObject.Find(GetRuneName(i)).GetComponent<Runes>().Element != null)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public Recipe VerifyTransmutation()
    {
        foreach (Recipe recipe in recipes)
        {
            Debug.Log($"Recipe: {recipe.id}");
            List<Element> temp = recipe.materials;
            if (CompareToRecipe(temp))
            {
                return recipe;
            }
            else
                continue;
                
        }
        return null;
    }
}
