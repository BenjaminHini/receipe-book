
namespace assignment4
{
    partial class FormIngredients
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingredient_list = new System.Windows.Forms.ListBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.ingredient_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ingredientNB_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Ingredients";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ingredient_list);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.ingredient_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient";
            // 
            // ingredient_list
            // 
            this.ingredient_list.FormattingEnabled = true;
            this.ingredient_list.ItemHeight = 25;
            this.ingredient_list.Location = new System.Drawing.Point(6, 104);
            this.ingredient_list.Name = "ingredient_list";
            this.ingredient_list.Size = new System.Drawing.Size(405, 304);
            this.ingredient_list.TabIndex = 5;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(417, 179);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(94, 40);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(417, 116);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(94, 40);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(417, 51);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 40);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // ingredient_txt
            // 
            this.ingredient_txt.Location = new System.Drawing.Point(6, 51);
            this.ingredient_txt.Name = "ingredient_txt";
            this.ingredient_txt.Size = new System.Drawing.Size(405, 31);
            this.ingredient_txt.TabIndex = 0;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(101, 533);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(94, 40);
            this.ok_btn.TabIndex = 5;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(284, 533);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(94, 40);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ingredientNB_lbl
            // 
            this.ingredientNB_lbl.AutoSize = true;
            this.ingredientNB_lbl.Location = new System.Drawing.Point(464, 55);
            this.ingredientNB_lbl.Name = "ingredientNB_lbl";
            this.ingredientNB_lbl.Size = new System.Drawing.Size(0, 25);
            this.ingredientNB_lbl.TabIndex = 6;
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 615);
            this.Controls.Add(this.ingredientNB_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormIngredients";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ingredient_txt;
        private System.Windows.Forms.ListBox ingredient_list;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label ingredientNB_lbl;
    }
}

