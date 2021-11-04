using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    public class Recipe
    {
        private string name, instruction;
        private FoodCategory category;
        private string[] ingredients;
        //geters and seters for each attributes of the Recipe class
        public string  NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string INSTRUCTION
        {
            get { return instruction; }
            set { instruction = value; }
        }
        public FoodCategory CATEGORY
        {
            get { return category; }
            set { category = value; }
        } 

        public string[] INGREDIENTS
        {
            get { return ingredients ; }
            set { ingredients = value; }
        }
        //full constructor
        public Recipe(int maxNbIngredients,string nm, string instru, FoodCategory categ)
        {
            ingredients = new string[maxNbIngredients];
            name = nm;
            instruction = instru;
            category = categ;
        }
        //default constructor
        public Recipe(int maxNbIngredients)
        {
            ingredients = new string[maxNbIngredients];
            name = string.Empty;
            instruction = string.Empty;
            category = FoodCategory.Other;
        }

    }
}
