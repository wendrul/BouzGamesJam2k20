using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Recipes
{
    public static List<Recipe> GetRecipes()
    {
        List<Recipe> recipes = new List<Recipe>();
        for (int i = 0; i < Const.totalRecipes; i++)
        {
            recipes.Add(GetRecipe(i));
        }
        return recipes;
    }
    public static Recipe GetRecipe(int id)
    {
        Recipe recipe = null;

        switch (id)
        {
            case Const.rGlass:
                recipe = GlassRecipe();
                break;
            case Const.rPlastic:
                recipe = PlasticRecipe();
                break;
            default:
                recipe = null;
                break;
        }

        return recipe;
    }

    private static Recipe GlassRecipe()
    {
        List<Element> elements = new List<Element>();
        Element temp  = new Element(1, Const.noRune, Const.dirt);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.sand);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.rGlass, elements);
        return recipe;
    }
    private static Recipe PlasticRecipe()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.fireRune, Const.wood);
        elements.Add(temp);
        temp = new Element(1, Const.waterRune, Const.leaves);
        elements.Add(temp);
        temp = new Element(1, Const.airRune, Const.glass);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.rPlastic, elements);
        return recipe;
    }

}
