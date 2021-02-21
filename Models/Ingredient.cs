namespace Allspice.Models
{
    public class Ingredient
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
            public int RecipeId { get; set; }

            public Recipe Recipe { get; set; }

  }
}