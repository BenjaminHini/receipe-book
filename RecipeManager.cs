using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    public class RecipeManager
    {
        private Recipe[] recipes;
        //constructor
        public RecipeManager(int maxNbRecipe)
        {
            recipes = new Recipe[maxNbRecipe];
        }
        //add a recipe to the recipe list
        public void addReceipe(Recipe a)
        {
            for(int i = 0; i < recipes.Length; ++i )
                if (recipes[i] == null)
                {
                    recipes[i] = a;
                    break;
                }
        }
        //geter and seter of the attribute
        public Recipe[] RECIPES
        {
            get { return recipes; }
            set { recipes = value; }
        }
    }
}
