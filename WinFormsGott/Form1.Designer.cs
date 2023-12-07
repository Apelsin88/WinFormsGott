namespace WinFormsGott
{
    partial class Form1
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
            listBox1 = new ListBox();
            label1 = new Label();
            ToStorageButton = new Button();
            ToRecipesButton = new Button();
            StoragePanel = new Panel();
            label7 = new Label();
            QuantityDecraseButton = new Button();
            QuantityAddButton = new Button();
            label6 = new Label();
            AddToStorageListBoxButton = new Button();
            QuantityUpDown = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            NameTextBox = new TextBox();
            BackButtonS = new Button();
            StorageListBox = new ListBox();
            label2 = new Label();
            RecipePanel = new Panel();
            RememberRecipeButton = new Button();
            CreateRecipeButton = new Button();
            NewRecipeNameLable = new Label();
            RecipeNameTextBox = new TextBox();
            RecipeNameLable = new Label();
            NewRecipeLabel = new Label();
            RecipeIngredientsLabel = new Label();
            AddToRecipeButton = new Button();
            IngredientQuantityUpDown = new NumericUpDown();
            IngredientQuantityLabel = new Label();
            IngredientNameLabel = new Label();
            IngredientNameTextBox = new TextBox();
            RecipeIngredientsListBox = new ListBox();
            BackButtonR = new Button();
            KnownRecipesListBox = new ListBox();
            label3 = new Label();
            StoragePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).BeginInit();
            RecipePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientQuantityUpDown).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(288, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 548);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 7);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 1;
            label1.Text = "Meal Tips :P";
            label1.Click += label1_Click;
            // 
            // ToStorageButton
            // 
            ToStorageButton.Location = new Point(28, 34);
            ToStorageButton.Name = "ToStorageButton";
            ToStorageButton.Size = new Size(150, 46);
            ToStorageButton.TabIndex = 2;
            ToStorageButton.Text = "Storage";
            ToStorageButton.UseVisualStyleBackColor = true;
            ToStorageButton.Click += ToStorageButton_Click;
            // 
            // ToRecipesButton
            // 
            ToRecipesButton.Location = new Point(28, 101);
            ToRecipesButton.Name = "ToRecipesButton";
            ToRecipesButton.Size = new Size(150, 46);
            ToRecipesButton.TabIndex = 3;
            ToRecipesButton.Text = "Recipes";
            ToRecipesButton.UseVisualStyleBackColor = true;
            ToRecipesButton.Click += ToRecipesButton_Click;
            // 
            // StoragePanel
            // 
            StoragePanel.Controls.Add(label7);
            StoragePanel.Controls.Add(QuantityDecraseButton);
            StoragePanel.Controls.Add(QuantityAddButton);
            StoragePanel.Controls.Add(label6);
            StoragePanel.Controls.Add(AddToStorageListBoxButton);
            StoragePanel.Controls.Add(QuantityUpDown);
            StoragePanel.Controls.Add(label5);
            StoragePanel.Controls.Add(label4);
            StoragePanel.Controls.Add(NameTextBox);
            StoragePanel.Controls.Add(BackButtonS);
            StoragePanel.Controls.Add(StorageListBox);
            StoragePanel.Controls.Add(label2);
            StoragePanel.Location = new Point(12, 12);
            StoragePanel.Name = "StoragePanel";
            StoragePanel.Size = new Size(649, 609);
            StoragePanel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(183, 139);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 10, 0, 10);
            label7.Size = new Size(129, 57);
            label7.TabIndex = 13;
            label7.Text = "Quantity";
            // 
            // QuantityDecraseButton
            // 
            QuantityDecraseButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityDecraseButton.Location = new Point(174, 199);
            QuantityDecraseButton.Name = "QuantityDecraseButton";
            QuantityDecraseButton.Size = new Size(71, 58);
            QuantityDecraseButton.TabIndex = 12;
            QuantityDecraseButton.Text = "-";
            QuantityDecraseButton.UseVisualStyleBackColor = true;
            QuantityDecraseButton.Click += QuantityDecraseButton_Click;
            // 
            // QuantityAddButton
            // 
            QuantityAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityAddButton.Location = new Point(251, 199);
            QuantityAddButton.Name = "QuantityAddButton";
            QuantityAddButton.Size = new Size(71, 58);
            QuantityAddButton.TabIndex = 11;
            QuantityAddButton.Text = "+";
            QuantityAddButton.UseVisualStyleBackColor = true;
            QuantityAddButton.Click += QuantityAddButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(53, 307);
            label6.Name = "label6";
            label6.Size = new Size(240, 40);
            label6.TabIndex = 10;
            label6.Text = "New Ingredient";
            // 
            // AddToStorageListBoxButton
            // 
            AddToStorageListBoxButton.Location = new Point(80, 478);
            AddToStorageListBoxButton.Name = "AddToStorageListBoxButton";
            AddToStorageListBoxButton.Size = new Size(196, 46);
            AddToStorageListBoxButton.TabIndex = 9;
            AddToStorageListBoxButton.Text = "Add To Storage";
            AddToStorageListBoxButton.UseVisualStyleBackColor = true;
            AddToStorageListBoxButton.Click += AddToStorageListBoxButton_Click;
            // 
            // QuantityUpDown
            // 
            QuantityUpDown.Location = new Point(111, 409);
            QuantityUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            QuantityUpDown.Name = "QuantityUpDown";
            QuantityUpDown.Size = new Size(240, 39);
            QuantityUpDown.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.MenuHighlight;
            label5.Location = new Point(-1, 409);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuHighlight;
            label4.Location = new Point(3, 365);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 6;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(111, 362);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(238, 39);
            NameTextBox.TabIndex = 5;
            // 
            // BackButtonS
            // 
            BackButtonS.Location = new Point(12, 12);
            BackButtonS.Name = "BackButtonS";
            BackButtonS.Size = new Size(150, 46);
            BackButtonS.TabIndex = 4;
            BackButtonS.Text = "Back";
            BackButtonS.UseVisualStyleBackColor = true;
            BackButtonS.Click += BackButtonS_Click;
            // 
            // StorageListBox
            // 
            StorageListBox.FormattingEnabled = true;
            StorageListBox.ItemHeight = 32;
            StorageListBox.Location = new Point(355, 49);
            StorageListBox.Name = "StorageListBox";
            StorageListBox.Size = new Size(291, 516);
            StorageListBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(355, 6);
            label2.Name = "label2";
            label2.Size = new Size(128, 40);
            label2.TabIndex = 2;
            label2.Text = "Storage";
            // 
            // RecipePanel
            // 
            RecipePanel.Controls.Add(RememberRecipeButton);
            RecipePanel.Controls.Add(CreateRecipeButton);
            RecipePanel.Controls.Add(NewRecipeNameLable);
            RecipePanel.Controls.Add(RecipeNameTextBox);
            RecipePanel.Controls.Add(RecipeNameLable);
            RecipePanel.Controls.Add(NewRecipeLabel);
            RecipePanel.Controls.Add(RecipeIngredientsLabel);
            RecipePanel.Controls.Add(AddToRecipeButton);
            RecipePanel.Controls.Add(IngredientQuantityUpDown);
            RecipePanel.Controls.Add(IngredientQuantityLabel);
            RecipePanel.Controls.Add(IngredientNameLabel);
            RecipePanel.Controls.Add(IngredientNameTextBox);
            RecipePanel.Controls.Add(RecipeIngredientsListBox);
            RecipePanel.Controls.Add(BackButtonR);
            RecipePanel.Controls.Add(KnownRecipesListBox);
            RecipePanel.Controls.Add(label3);
            RecipePanel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            RecipePanel.Location = new Point(12, 12);
            RecipePanel.Name = "RecipePanel";
            RecipePanel.Size = new Size(935, 662);
            RecipePanel.TabIndex = 5;
            // 
            // RememberRecipeButton
            // 
            RememberRecipeButton.Location = new Point(346, 152);
            RememberRecipeButton.Name = "RememberRecipeButton";
            RememberRecipeButton.Size = new Size(244, 46);
            RememberRecipeButton.TabIndex = 22;
            RememberRecipeButton.Text = "<-- Remember Recipe";
            RememberRecipeButton.UseVisualStyleBackColor = true;
            RememberRecipeButton.Visible = false;
            RememberRecipeButton.Click += RememberRecipeButton_Click;
            // 
            // CreateRecipeButton
            // 
            CreateRecipeButton.Location = new Point(373, 389);
            CreateRecipeButton.Name = "CreateRecipeButton";
            CreateRecipeButton.Size = new Size(150, 46);
            CreateRecipeButton.TabIndex = 21;
            CreateRecipeButton.Text = "Create";
            CreateRecipeButton.UseVisualStyleBackColor = true;
            CreateRecipeButton.Click += CreateRecipeButton_Click;
            // 
            // NewRecipeNameLable
            // 
            NewRecipeNameLable.AutoSize = true;
            NewRecipeNameLable.BackColor = SystemColors.MenuHighlight;
            NewRecipeNameLable.Location = new Point(269, 353);
            NewRecipeNameLable.Name = "NewRecipeNameLable";
            NewRecipeNameLable.Size = new Size(69, 30);
            NewRecipeNameLable.TabIndex = 20;
            NewRecipeNameLable.Text = "Name";
            // 
            // RecipeNameTextBox
            // 
            RecipeNameTextBox.Location = new Point(377, 348);
            RecipeNameTextBox.Name = "RecipeNameTextBox";
            RecipeNameTextBox.Size = new Size(238, 35);
            RecipeNameTextBox.TabIndex = 19;
            // 
            // RecipeNameLable
            // 
            RecipeNameLable.AutoSize = true;
            RecipeNameLable.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            RecipeNameLable.Location = new Point(319, 288);
            RecipeNameLable.Name = "RecipeNameLable";
            RecipeNameLable.Size = new Size(283, 40);
            RecipeNameLable.TabIndex = 18;
            RecipeNameLable.Text = "Create New Recipe";
            // 
            // NewRecipeLabel
            // 
            NewRecipeLabel.AutoSize = true;
            NewRecipeLabel.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            NewRecipeLabel.Location = new Point(630, 61);
            NewRecipeLabel.Name = "NewRecipeLabel";
            NewRecipeLabel.Size = new Size(111, 40);
            NewRecipeLabel.TabIndex = 17;
            NewRecipeLabel.Text = "Recipe";
            NewRecipeLabel.Visible = false;
            // 
            // RecipeIngredientsLabel
            // 
            RecipeIngredientsLabel.AutoSize = true;
            RecipeIngredientsLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            RecipeIngredientsLabel.Location = new Point(319, 435);
            RecipeIngredientsLabel.Name = "RecipeIngredientsLabel";
            RecipeIngredientsLabel.Size = new Size(164, 37);
            RecipeIngredientsLabel.TabIndex = 16;
            RecipeIngredientsLabel.Text = "Ingredients";
            RecipeIngredientsLabel.Visible = false;
            // 
            // AddToRecipeButton
            // 
            AddToRecipeButton.Location = new Point(346, 606);
            AddToRecipeButton.Name = "AddToRecipeButton";
            AddToRecipeButton.Size = new Size(196, 46);
            AddToRecipeButton.TabIndex = 15;
            AddToRecipeButton.Text = "Add To Recipe";
            AddToRecipeButton.UseVisualStyleBackColor = true;
            AddToRecipeButton.Visible = false;
            AddToRecipeButton.Click += AddToRecipeButton_Click;
            // 
            // IngredientQuantityUpDown
            // 
            IngredientQuantityUpDown.Location = new Point(377, 537);
            IngredientQuantityUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            IngredientQuantityUpDown.Name = "IngredientQuantityUpDown";
            IngredientQuantityUpDown.Size = new Size(240, 35);
            IngredientQuantityUpDown.TabIndex = 14;
            IngredientQuantityUpDown.Visible = false;
            // 
            // IngredientQuantityLabel
            // 
            IngredientQuantityLabel.AutoSize = true;
            IngredientQuantityLabel.BackColor = SystemColors.MenuHighlight;
            IngredientQuantityLabel.Location = new Point(265, 537);
            IngredientQuantityLabel.Name = "IngredientQuantityLabel";
            IngredientQuantityLabel.Size = new Size(93, 30);
            IngredientQuantityLabel.TabIndex = 13;
            IngredientQuantityLabel.Text = "Quantity";
            IngredientQuantityLabel.Visible = false;
            // 
            // IngredientNameLabel
            // 
            IngredientNameLabel.AutoSize = true;
            IngredientNameLabel.BackColor = SystemColors.MenuHighlight;
            IngredientNameLabel.Location = new Point(269, 493);
            IngredientNameLabel.Name = "IngredientNameLabel";
            IngredientNameLabel.Size = new Size(69, 30);
            IngredientNameLabel.TabIndex = 12;
            IngredientNameLabel.Text = "Name";
            IngredientNameLabel.Visible = false;
            // 
            // IngredientNameTextBox
            // 
            IngredientNameTextBox.Location = new Point(377, 490);
            IngredientNameTextBox.Name = "IngredientNameTextBox";
            IngredientNameTextBox.Size = new Size(238, 35);
            IngredientNameTextBox.TabIndex = 11;
            IngredientNameTextBox.Visible = false;
            // 
            // RecipeIngredientsListBox
            // 
            RecipeIngredientsListBox.FormattingEnabled = true;
            RecipeIngredientsListBox.ItemHeight = 30;
            RecipeIngredientsListBox.Location = new Point(630, 104);
            RecipeIngredientsListBox.Name = "RecipeIngredientsListBox";
            RecipeIngredientsListBox.Size = new Size(291, 544);
            RecipeIngredientsListBox.TabIndex = 7;
            RecipeIngredientsListBox.Visible = false;
            // 
            // BackButtonR
            // 
            BackButtonR.Location = new Point(13, 12);
            BackButtonR.Name = "BackButtonR";
            BackButtonR.Size = new Size(150, 46);
            BackButtonR.TabIndex = 5;
            BackButtonR.Text = "Back";
            BackButtonR.UseVisualStyleBackColor = true;
            BackButtonR.Click += BackButtonR_Click;
            // 
            // KnownRecipesListBox
            // 
            KnownRecipesListBox.FormattingEnabled = true;
            KnownRecipesListBox.ItemHeight = 30;
            KnownRecipesListBox.Location = new Point(13, 103);
            KnownRecipesListBox.Name = "KnownRecipesListBox";
            KnownRecipesListBox.Size = new Size(240, 544);
            KnownRecipesListBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 60);
            label3.Name = "label3";
            label3.Size = new Size(232, 40);
            label3.TabIndex = 2;
            label3.Text = "Known Recipes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(950, 677);
            Controls.Add(RecipePanel);
            Controls.Add(StoragePanel);
            Controls.Add(ToRecipesButton);
            Controls.Add(ToStorageButton);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Gott";
            Load += Form1_Load;
            StoragePanel.ResumeLayout(false);
            StoragePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).EndInit();
            RecipePanel.ResumeLayout(false);
            RecipePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IngredientQuantityUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button ToStorageButton;
        private Button ToRecipesButton;
        private Panel StoragePanel;
        private ListBox StorageListBox;
        private Label label2;
        private Panel RecipePanel;
        private ListBox KnownRecipesListBox;
        private Label label3;
        private Button BackButtonS;
        private Button BackButtonR;
        private Label label4;
        private TextBox NameTextBox;
        private Label label5;
        private NumericUpDown QuantityUpDown;
        private Button AddToStorageListBoxButton;
        private Label label6;
        private Label label7;
        private Button QuantityDecraseButton;
        private Button QuantityAddButton;
        private Label RecipeIngredientsLabel;
        private Button AddToRecipeButton;
        private NumericUpDown IngredientQuantityUpDown;
        private Label IngredientQuantityLabel;
        private Label IngredientNameLabel;
        private TextBox IngredientNameTextBox;
        private ListBox RecipeIngredientsListBox;
        private Label NewRecipeNameLable;
        private TextBox RecipeNameTextBox;
        private Label RecipeNameLable;
        private Label NewRecipeLabel;
        private Button CreateRecipeButton;
        private Button RememberRecipeButton;
    }
}