using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class MainForm : Form
    {
        private const int maxNbIngredients = 50, maxNbRecipe = 200;
        private RecipeManager recipeManager = new RecipeManager(maxNbRecipe);
        private Recipe curr = new Recipe(maxNbIngredients);
        //add a recipe in the recipe manager
        private void addRecipe_btn_Click(object sender, EventArgs e)
        {
            string name, instru;
            FoodCategory category;
            if (recipe_txt.Text != string.Empty && instruction_txt.Text != string.Empty)
            {
                name = recipe_txt.Text;
                instru = instruction_txt.Text;
                category = getFoodCategory();
                if(curr.NAME == string.Empty)//curr gets set either here or in "addIngredient", we check it hasn't already been
                    curr = new Recipe(maxNbIngredients, name, instru, category);
                recipeManager.addReceipe(curr);
                curr = null;
                updateDisplay();
            }
            else
                MessageBox.Show("missing some data");
        }
        //creator, gets called by FormIngredient "ok" and "cancel" button
        //gets back the values it sends to the FormIngredient constructor
        public MainForm(RecipeManager r, Recipe recipe, int index)
        {
            InitializeComponent();
            recipeManager = r;
            curr = recipe;
            updateDisplay();
            recipe_txt.Text = curr.NAME;
            updateInstruction();
            instruction_txt.Text = curr.INSTRUCTION;
            category_cmb.SelectedIndex = (int)curr.CATEGORY;
            recipes_list.SelectedIndex = index;

        }
        //basic constructor
        public MainForm()
        {
            InitializeComponent();
            category_cmb.SelectedIndex = 0;
            curr = new Recipe(maxNbIngredients);
        }
        //calls the FormIngredient form to add ingredients to the recipe
        private void addIngredient_btn_Click(object sender, EventArgs e)
        {
            string name, instru;
            FoodCategory category;
            if (recipe_txt.Text != string.Empty && instruction_txt.Text != string.Empty)
            {
                name = recipe_txt.Text;
                instru = instruction_txt.Text;
                category = getFoodCategory();
                if(curr.NAME == string.Empty)//create the recipe if not already done
                    curr = new Recipe(maxNbIngredients, name, instru, category);
                var form = new FormIngredients(recipeManager, curr, recipes_list.SelectedIndex);//calls and show FormIngredient
                form.Show();
                this.Hide();
                curr = null;
            }
            else
                MessageBox.Show("some data is missing");
        }
        //set the foodCategory of the recipe in function of the value of the combolist
        public FoodCategory getFoodCategory()
        {
            string value = category_cmb.Items[category_cmb.SelectedIndex].ToString();
            if (value == "Meats")
                return FoodCategory.Meats;
            else if (value == "Pasta")
                return FoodCategory.Pasta;
            else if (value == "Pizza")
                return FoodCategory.Pizza;
            else if (value == "Fish")
                return FoodCategory.Fish;
            else if (value == "Seafood")
                return FoodCategory.Seafood;
            else if (value == "Soup")
                return FoodCategory.Soups;
            else if (value == "Stew")
                return FoodCategory.Stew;
            else if (value == "Vegan")
                return FoodCategory.Vegan;
            else if (value == "Vegetarian")
                return FoodCategory.Vegetarian;
            else if (value == "Vegetarian_Diary_Egg")
                return FoodCategory.Vegetarian_Diary_Egg;
            else
                return FoodCategory.Other;
        }
        //delete the selected recipe
        private void delete_btn_Click(object sender, EventArgs e)
        {
            int index = recipes_list.SelectedIndex;
            try
            {
                recipeManager.RECIPES[index] = null;
                moveElementLeft(index);
                updateDisplay();
            }
            catch(IndexOutOfRangeException ex){ MessageBox.Show("select the recipe you want to delete");}
        }
        //update the display after a recipe is add, deleted or edited
        public void updateDisplay()
        {
            recipes_list.Items.Clear();
            recipe_txt.Text = string.Empty;
            instruction_txt.Text = string.Empty;
            int nbIngr = 0;
            foreach (Recipe element in recipeManager.RECIPES)
                if (element != null)
                {
                    nbIngr = 0;
                    foreach (string values in element.INGREDIENTS)
                        if (values != null)
                            ++nbIngr;
                    recipes_list.Items.Add(element.NAME + "\r\t\t\t" + element.CATEGORY.ToString()
                        + "\r\t\t" + nbIngr+"\r\n");
                }
        }
        //set curr to the recipe we want to edit
        private void editBegin_btn_Click(object sender, EventArgs e)
        {
            try
            {
                curr = recipeManager.RECIPES[recipes_list.SelectedIndex];
                recipe_txt.Text = curr.NAME;
                instruction_txt.Text = curr.INSTRUCTION;
                category_cmb.SelectedIndex = (int)curr.CATEGORY;
            }
            catch (IndexOutOfRangeException ex) { MessageBox.Show("select the recipe you want to edit"); }
        }
        //save the modification made by the user
        private void editFinish_btn_Click(object sender, EventArgs e)
        {
            try{
                int index = recipes_list.SelectedIndex;
                curr.NAME = recipe_txt.Text;
                curr.INSTRUCTION = instruction_txt.Text;
                curr.CATEGORY = getFoodCategory();
                recipeManager.RECIPES[index] = curr;
                updateDisplay();
            }
             catch  { MessageBox.Show("select the recipe you want to edit"); }
        }

        //unselect the linne selected by the user in the textlist
        private void clear_btn_Click(object sender, EventArgs e)
        {
            recipes_list.SelectedIndex = -1;
        }
        //move elements of index [index+1] of the recipes list one to the left
        public void moveElementLeft(int index)
        {
            for(int i = index+1; i<recipeManager.RECIPES.Length;++i)
            {
                recipeManager.RECIPES[i - 1] = recipeManager.RECIPES[i];
                recipeManager.RECIPES[i] = null;
            }
        }
        //add a string containing the list of ingredients to the instructions
        public void updateInstruction()
        {
            int i;
            for (i = 0; i < curr.INGREDIENTS.Length; ++i)
                if (curr.INGREDIENTS[i] == null)
                    break;
            if(i !=0)
            {
                curr.INSTRUCTION += "\r\nlist of ingredients : \n";
                for (int j = 0; j < i; ++j)
                    curr.INSTRUCTION += "\r\n" + curr.INGREDIENTS[j];
            }
        }
    }

}
