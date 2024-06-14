using RecipeAppSystem;
using System.Data;
using System.Globalization;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}

	private void SearchRecipes()
	{
		DataTable dt = Recipe.SearchRecipes();
		Recipelst.ItemsSource = dt.Rows;
	}

	private void SearchBtn_Clicked(object sender, EventArgs e)
	{
		SearchRecipes();
	}


}