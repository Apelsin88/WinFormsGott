using Newtonsoft.Json;

namespace WinFormsGott
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        List<Ingredient> storage = new List<Ingredient>();
        List<Recipe> knownRecipes = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
            FileInfo file = new FileInfo(storagePath);
            if (!file.Exists)
            {
                storage.Add(new Ingredient("Egg", 5));
                storage.Add(new Ingredient("Caviar", 3));
                foreach (Ingredient ingredient in storage)
                {
                    StorageListBox.Items.Add(ingredient.Name + " " + ingredient.Quantity);
                }
            }
            else
            {
                LoadStorage();
            }
            FileInfo file2 = new FileInfo(path);
            if (!file2.Exists)
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                ingredients.Add(new Ingredient("Egg", 1));
                ingredients.Add(new Ingredient("Caviar", 1));
                knownRecipes.Add(new Recipe("Egg with caviar", ingredients));
                foreach (Recipe recipe in knownRecipes)
                {
                    KnownRecipesListBox.Items.Add(recipe.Name);
                }

            }
            else
            {
                LoadKnownRecipes();
            }
            CanMake();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(StoragePanel);
            listPanel.Add(RecipePanel);
            StoragePanel.Visible = false;
            RecipePanel.Visible = false;

        }

        private void ToStorageButton_Click(object sender, EventArgs e)
        {
            StoragePanel.Visible = true;
            StoragePanel.BringToFront();
        }

        private void ToRecipesButton_Click(object sender, EventArgs e)
        {
            RecipePanel.Visible = true;
            RecipePanel.BringToFront();
        }
        private void ToNewRecipeButton_Click(object sender, EventArgs e)
        {

        }
        private void BackButtonS_Click(object sender, EventArgs e)
        {
            StoragePanel.Visible = false;
            RecipePanel.Visible = false;
        }

        private void BackButtonR_Click(object sender, EventArgs e)
        {
            StoragePanel.Visible = false;
            RecipePanel.Visible = false;
        }
        private void BackButtonN_Click(object sender, EventArgs e)
        {
            RecipePanel.Visible = true;
            RecipePanel.BringToFront();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        string storagePath = "storage.json";
        private void AddToStorageListBoxButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && QuantityUpDown.Value != 0)
            {
                string name = NameTextBox.Text;
                double quantity = (double)QuantityUpDown.Value;
                Ingredient ingredient = new Ingredient(name, quantity);
                storage.Add(ingredient);
                StorageListBox.Items.Add(ingredient.Name + " " + ingredient.Quantity);
                Refresh();
                NameTextBox.Text = "";
                QuantityUpDown.Value = 0;
            }
            string json = JsonConvert.SerializeObject(storage);
            using (StreamWriter sw = new StreamWriter(storagePath))
            {
                sw.Write(json);
            }

        }
        private void LoadStorage()
        {
            using (StreamReader sr = new StreamReader(storagePath))
            {
                string json = sr.ReadToEnd();
                storage = JsonConvert.DeserializeObject<List<Ingredient>>(json);
            }
            foreach (Ingredient ingredient in storage)
            {
                StorageListBox.Items.Add(ingredient.Name + " " + ingredient.Quantity);
            }
        }

        private void QuantityAddButton_Click(object sender, EventArgs e)
        {
            if (StorageListBox.SelectedItem != null)
            {
                int index = StorageListBox.SelectedIndex;
                Ingredient ingredient = storage[index];
                ingredient.Quantity += 1;
                string json = JsonConvert.SerializeObject(storage);
                using (StreamWriter sw = new StreamWriter(storagePath))
                {
                    sw.Write(json);
                }
                Refresh();
                StorageListBox.SelectedIndex = index;
            }

        }

        private void Refresh()
        {
            StorageListBox.Items.Clear();
            listBox1.Items.Clear();
            foreach (Ingredient ingredient in storage)
            {
                StorageListBox.Items.Add(ingredient.Name + " " + ingredient.Quantity);
            }
            CanMake();
        }

        private void QuantityDecraseButton_Click(object sender, EventArgs e)
        {
            if (StorageListBox.SelectedItem != null)
            {
                int index = StorageListBox.SelectedIndex;
                Ingredient ingredient = storage[index];
                ingredient.Quantity -= 1;
                string json = JsonConvert.SerializeObject(storage);
                using (StreamWriter sw = new StreamWriter(storagePath))
                {
                    sw.Write(json);
                }
                Refresh();
                StorageListBox.SelectedIndex = index;
            }
        }

        private void CreateRecipeButton_Click(object sender, EventArgs e)
        {
            if (RecipeNameTextBox.Text != "")
            {
                string name = RecipeNameTextBox.Text;
                List<Ingredient> ingredients = new List<Ingredient>();
                Recipe recipe = new Recipe(name, ingredients);
                NewRecipeLabel.Text = recipe.Name;
                knownRecipes.Add(recipe);

                RememberRecipeButton.Visible = true;
                NewRecipeLabel.Visible = true;
                RecipeIngredientsLabel.Visible = true;
                IngredientNameLabel.Visible = true;
                IngredientNameTextBox.Visible = true;
                IngredientQuantityLabel.Visible = true;
                IngredientQuantityUpDown.Visible = true;
                AddToRecipeButton.Visible = true;
                RecipeIngredientsListBox.Visible = true;
                RecipeNameLable.Visible = false;
                NewRecipeNameLable.Visible = false;
                RecipeNameTextBox.Visible = false;
                CreateRecipeButton.Visible = false;
                RecipeNameTextBox.Text = "";


            }


        }

        private void AddToRecipeButton_Click(object sender, EventArgs e)
        {
            if (IngredientNameTextBox.Text != "" && IngredientQuantityUpDown.Value != 0)
            {
                string name = IngredientNameTextBox.Text;
                double quantity = (double)IngredientQuantityUpDown.Value;
                Ingredient ingredient = new Ingredient(name, quantity);
                RecipeIngredientsListBox.Items.Add(ingredient.Name + " " + ingredient.Quantity);
                foreach (Recipe recipe in knownRecipes)
                {
                    if (recipe.Name == NewRecipeLabel.Text)
                    {
                        recipe.Ingredients.Add(ingredient);
                    }
                }
                IngredientNameTextBox.Text = "";
                IngredientQuantityUpDown.Value = 0;


            }


        }
        string path = "knownRecipes.json";

        private void RememberRecipeButton_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(knownRecipes);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
            }

            foreach (Recipe recipe in knownRecipes)
            {
                if (recipe.Name == NewRecipeLabel.Text)
                {
                    KnownRecipesListBox.Items.Add(recipe.Name);
                }
            }
            Refresh();
            RecipeIngredientsListBox.Items.Clear();
            NewRecipeLabel.Text = "Recipe";
            NewRecipeLabel.Visible = false;
            RememberRecipeButton.Visible = false;
            RecipeIngredientsLabel.Visible = false;
            IngredientNameLabel.Visible = false;
            IngredientNameTextBox.Visible = false;
            IngredientQuantityLabel.Visible = false;
            IngredientQuantityUpDown.Visible = false;
            AddToRecipeButton.Visible = false;
            RecipeIngredientsListBox.Visible = false;
            RecipeNameLable.Visible = true;
            NewRecipeNameLable.Visible = true;
            RecipeNameTextBox.Visible = true;
            CreateRecipeButton.Visible = true;

        }
        private void LoadKnownRecipes()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                knownRecipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }
            foreach (Recipe recipe in knownRecipes)
            {
                KnownRecipesListBox.Items.Add(recipe.Name);
            }
        }

        private void CanMake()
        {
            foreach (Recipe recipe in knownRecipes)
            {
                if (recipe.Ingredients.All(x => storage.Contains(x)))
                {
                    listBox1.Items.Add(recipe.Name);
                }
            }
        }

    }
}
