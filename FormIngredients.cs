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
    public partial class FormIngredients : Form
    {
        private Recipe recipe;
        private RecipeManager rcpM;
        private int a;

        //constructor of the form, receive the RecipeManager, the current Recipe as well
        //as the index of the recipe in the recipe list, usefull in case of an edit
        public FormIngredients(RecipeManager mng, Recipe rcp, int index)
        {
            InitializeComponent();
            rcpM = mng;
            recipe = rcp;
            a = index;
            updateDisplay();
        }
        //update the display after an ingredient is added, deleted or edited
        public void updateDisplay()
        {
            ingredient_txt.Text = string.Empty;
            ingredient_list.Items.Clear();
            int j=0;
            foreach (string element in recipe.INGREDIENTS)
                if (element != null)
                {
                    ingredient_list.Items.Add(element);
                    j++;
                }
            ingredientNB_lbl.Text = j.ToString();
        }
        //save the added ingredients and calls MainForm back
        private void ok_btn_Click(object sender, EventArgs e)
        {
            var form = new MainForm(rcpM, recipe, a);
            form.Show();
            this.Hide();
        }
        //delete the added ingredients and calls MainForm back
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            recipe.INGREDIENTS = new string[recipe.INGREDIENTS.Length];
            var form = new MainForm(rcpM, recipe, a);
            form.Show();
            this.Hide();
        }
        //delete the selected ingredient
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ingredient_list.SelectedIndex;
                recipe.INGREDIENTS[index] = null;
                moveElementLeft(index);
                updateDisplay();
            }
            catch (IndexOutOfRangeException ex) { MessageBox.Show("select the ingredient you want to delete"); }
        }
        //move the elements of index[index+1] of the ingredient list one to the left
        public void moveElementLeft(int index)
        {
            for(int i = index+1; i<recipe.INGREDIENTS.Length; ++i)
            {
                recipe.INGREDIENTS[i - 1] = recipe.INGREDIENTS[i];
                recipe.INGREDIENTS[i] = null;
            }
        }
        //add an ingredient to the list
        private void add_btn_Click_1(object sender, EventArgs e)
        {
            if (ingredient_txt.Text != null)
            {
                for (int i = 0; i < recipe.INGREDIENTS.Length; ++i)
                    if (recipe.INGREDIENTS[i] ==null)
                    {
                        recipe.INGREDIENTS[i] = ingredient_txt.Text;
                        break;
                    }
            }
            else
                MessageBox.Show("enter ingredient name");
            updateDisplay();
        }
        //edit the selected ingredient
        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ingredient_list.SelectedIndex;
                if (ingredient_txt.Text != string.Empty)
                    recipe.INGREDIENTS[index] = ingredient_txt.Text;
                else
                    MessageBox.Show("enter the new name of the ingredient in the \"name\" textbox");
                updateDisplay();
            }
            catch (IndexOutOfRangeException ex) { MessageBox.Show("select the ingredient you want to update"); }
        }
    }
}
