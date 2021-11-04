
namespace assignment4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.category_cmb = new System.Windows.Forms.ComboBox();
            this.instruction_txt = new System.Windows.Forms.TextBox();
            this.recipe_txt = new System.Windows.Forms.TextBox();
            this.addRecipe_btn = new System.Windows.Forms.Button();
            this.addIngredient_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editBegin_btn = new System.Windows.Forms.Button();
            this.editFinish_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.recipes_list = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.category_cmb);
            this.groupBox1.Controls.Add(this.instruction_txt);
            this.groupBox1.Controls.Add(this.recipe_txt);
            this.groupBox1.Controls.Add(this.addRecipe_btn);
            this.groupBox1.Controls.Add(this.addIngredient_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(924, 1033);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new recipe";
            // 
            // category_cmb
            // 
            this.category_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cmb.FormattingEnabled = true;
            this.category_cmb.Items.AddRange(new object[] {
            "Meats",
            "Pasta",
            "Pizza",
            "Fish",
            "Seafood",
            "Soup",
            "Stew",
            "Vegan",
            "Vegetarian",
            "Vegetarian_Diary_Egg",
            "Other"});
            this.category_cmb.Location = new System.Drawing.Point(192, 194);
            this.category_cmb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.category_cmb.Name = "category_cmb";
            this.category_cmb.Size = new System.Drawing.Size(360, 56);
            this.category_cmb.TabIndex = 7;
            // 
            // instruction_txt
            // 
            this.instruction_txt.Location = new System.Drawing.Point(12, 278);
            this.instruction_txt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.instruction_txt.Multiline = true;
            this.instruction_txt.Name = "instruction_txt";
            this.instruction_txt.Size = new System.Drawing.Size(896, 641);
            this.instruction_txt.TabIndex = 6;
            // 
            // recipe_txt
            // 
            this.recipe_txt.Location = new System.Drawing.Point(388, 108);
            this.recipe_txt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recipe_txt.Name = "recipe_txt";
            this.recipe_txt.Size = new System.Drawing.Size(520, 55);
            this.recipe_txt.TabIndex = 5;
            // 
            // addRecipe_btn
            // 
            this.addRecipe_btn.Location = new System.Drawing.Point(12, 935);
            this.addRecipe_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addRecipe_btn.Name = "addRecipe_btn";
            this.addRecipe_btn.Size = new System.Drawing.Size(900, 65);
            this.addRecipe_btn.TabIndex = 4;
            this.addRecipe_btn.Text = "Add Recipe";
            this.addRecipe_btn.UseVisualStyleBackColor = true;
            this.addRecipe_btn.Click += new System.EventHandler(this.addRecipe_btn_Click);
            // 
            // addIngredient_btn
            // 
            this.addIngredient_btn.Location = new System.Drawing.Point(614, 194);
            this.addIngredient_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addIngredient_btn.Name = "addIngredient_btn";
            this.addIngredient_btn.Size = new System.Drawing.Size(298, 65);
            this.addIngredient_btn.TabIndex = 3;
            this.addIngredient_btn.Text = "Add Ingredients";
            this.addIngredient_btn.UseVisualStyleBackColor = true;
            this.addIngredient_btn.Click += new System.EventHandler(this.addIngredient_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1040, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1576, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2030, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. of ingredients";
            // 
            // editBegin_btn
            // 
            this.editBegin_btn.Location = new System.Drawing.Point(1082, 920);
            this.editBegin_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editBegin_btn.Name = "editBegin_btn";
            this.editBegin_btn.Size = new System.Drawing.Size(224, 65);
            this.editBegin_btn.TabIndex = 6;
            this.editBegin_btn.Text = "Edit-begin";
            this.editBegin_btn.UseVisualStyleBackColor = true;
            this.editBegin_btn.Click += new System.EventHandler(this.editBegin_btn_Click);
            // 
            // editFinish_btn
            // 
            this.editFinish_btn.Location = new System.Drawing.Point(1406, 920);
            this.editFinish_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.editFinish_btn.Name = "editFinish_btn";
            this.editFinish_btn.Size = new System.Drawing.Size(224, 65);
            this.editFinish_btn.TabIndex = 7;
            this.editFinish_btn.Text = "Edit-finish";
            this.editFinish_btn.UseVisualStyleBackColor = true;
            this.editFinish_btn.Click += new System.EventHandler(this.editFinish_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(1738, 920);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(224, 65);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(2030, 920);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(292, 65);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Unselect";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // recipes_list
            // 
            this.recipes_list.FormattingEnabled = true;
            this.recipes_list.ItemHeight = 48;
            this.recipes_list.Location = new System.Drawing.Point(1040, 152);
            this.recipes_list.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recipes_list.Name = "recipes_list";
            this.recipes_list.Size = new System.Drawing.Size(1296, 724);
            this.recipes_list.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2364, 1135);
            this.Controls.Add(this.recipes_list);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.editFinish_btn);
            this.Controls.Add(this.editBegin_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "APU Receipe Book by Benjamin Hini";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox instruction_txt;
        private System.Windows.Forms.TextBox recipe_txt;
        private System.Windows.Forms.Button addRecipe_btn;
        private System.Windows.Forms.Button addIngredient_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editBegin_btn;
        private System.Windows.Forms.Button editFinish_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.ComboBox category_cmb;
        private System.Windows.Forms.ListBox recipes_list;
    }
}

