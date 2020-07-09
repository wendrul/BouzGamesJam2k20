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
            case Const.recipe1a:
                recipe = recipe1a();
                break;
            case Const.recipe1b:
                recipe = recipe1b();
                break;
            case Const.recipe1c:
                recipe = recipe1c();
                break;
            case Const.recipe1d:
                recipe = recipe1d();
                break;
            case Const.recipe2a:
                recipe = recipe2a();
                break;
            case Const.recipe2b:
                recipe = recipe2b();
                break;
            case Const.recipe2c:
                recipe = recipe2c();
                break;
            case Const.recipe2d:
                recipe = recipe2d();
                break;
            case Const.recipe2e:
                recipe = recipe2e();
                break;
            case Const.recipe2f:
                recipe = recipe2f();
                break;
            case Const.recipe2g:
                recipe = recipe2g();
                break;
            case Const.recipe2h:
                recipe = recipe2h();
                break;
            case Const.recipe2i:
                recipe = recipe2i();
                break;
            case Const.recipe2j:
                recipe = recipe2j();
                break;
            case Const.recipe2k:
                recipe = recipe2k();
                break;
            case Const.recipe2l:
                recipe = recipe2l();
                break;
            case Const.recipe3a:
                recipe = recipe3a();
                break;
            case Const.recipe3b:
                recipe = recipe3b();
                break;
            case Const.recipe3c:
                recipe = recipe3c();
                break;
            case Const.recipe3d:
                recipe = recipe3d();
                break;
            /*  case Const.recipe3e:
                  recipe = recipe3e();
                  break;
              case Const.recipe3f:
                  recipe = recipe3f();
                  break;
             case Const.recipe3g:
                  recipe = recipe3g();
                  break;
              case Const.recipe3h:
                  recipe = recipe3h();
                  break;
              case Const.recipe3i:
                  recipe = recipe3i();
                  break;
              case Const.recipe3j:
                  recipe = recipe3j();
                  break;
              case Const.recipe3k:
                  recipe = recipe3k();
                  break;
              case Const.recipe3l:
                  recipe = recipe3l();
                  break;
              case Const.recipe3m:
                  recipe = recipe3m();
                  break;*/
            default:
                recipe = null;
                break;
        }

        return recipe;
    }

    private static Recipe recipe1a()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe1a, elements);
        return recipe;
    }
    private static Recipe recipe1b()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.c);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe1b, elements);
        return recipe;
    }
    private static Recipe recipe1c()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.c);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe1c, elements);
        return recipe;
    }
    private static Recipe recipe1d()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe1d, elements);
        return recipe;
    }
    private static Recipe recipe2a()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2a, elements);
        return recipe;
    }
    private static Recipe recipe2b()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(3, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2b, elements);
        return recipe;
    }
    private static Recipe recipe2c()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(3, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2c, elements);
        return recipe;
    }
    private static Recipe recipe2d()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(2, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(3, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2d, elements);
        return recipe;
    }
    private static Recipe recipe2e()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(4, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2e, elements);
        return recipe;
    }
    private static Recipe recipe2f()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(7, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.d);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2f, elements);
        return recipe;
    }
    private static Recipe recipe2g()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2g, elements);
        return recipe;
    }
    private static Recipe recipe2h()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(2, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2h, elements);
        return recipe;
    }
    private static Recipe recipe2i()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(2, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(3, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2i, elements);
        return recipe;
    }
    private static Recipe recipe2j()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(3, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2j, elements);
        return recipe;
    }
    private static Recipe recipe2k()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(4, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.c);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2k, elements);
        return recipe;
    }
    private static Recipe recipe2l()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.noRune, Const.a);
        elements.Add(temp);
        temp = new Element(2, Const.noRune, Const.b);
        elements.Add(temp);
        temp = new Element(3, Const.noRune, Const.c);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe2l, elements);
        return recipe;
    }
    private static Recipe recipe3a()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.redRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe3a, elements);
        return recipe;
    }
    private static Recipe recipe3b()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.blueRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.b);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe3b, elements);
        return recipe;
    }
    private static Recipe recipe3c()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.redRune, Const.b);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.c);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe3c, elements);
        return recipe;
    }
    private static Recipe recipe3d()
    {
        List<Element> elements = new List<Element>();
        Element temp = new Element(1, Const.greenRune, Const.a);
        elements.Add(temp);
        temp = new Element(1, Const.blueRune, Const.c);
        elements.Add(temp);
        temp = new Element(1, Const.noRune, Const.d);
        elements.Add(temp);
        Recipe recipe = new Recipe(Const.recipe3d, elements);
        return recipe;
    }
    /* private static Recipe recipe3e()
     {
         List<Element> elements = new List<Element>();
         Element temp = new Element(1, Const.noRune, Const.a);
         elements.Add(temp);
         Recipe recipe = new Recipe(Const.recipe3e, elements);
         return recipe;
     }
     private static Recipe recipe3f()
     {
         List<Element> elements = new List<Element>();
         Element temp = new Element(1, Const.blueRune, Const.a);
         elements.Add(temp);
         temp = new Element(1, Const.Rune, Const.b);
         elements.Add(temp);
         Recipe recipe = new Recipe(Const.recipe3f, elements);
         return recipe;
     }*/
}

