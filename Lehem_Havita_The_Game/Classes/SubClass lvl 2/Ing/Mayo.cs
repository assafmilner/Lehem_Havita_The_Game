using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Mayo ingredient in the game
    public class Mayo : Ingredients
    {
        // Constructor to initialize the Mayo ingredient
        public Mayo(int add_to_falling_speed)
        {
            Id = 5; // ID for Mayo ingredient
            Name = GameState.Ing_names[Id]; // Name of the ingredient
            ImagePath = GameState.imagePaths[Id]; // Image path for the ingredient
            this.Cost = 3; // Cost of the ingredient
            Picture.Image = Image.FromFile(ImagePath); // Load the ingredient image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
        }

        // Destructor
        ~Mayo()
        {

        }

        public override string Get_Name()
        {
            return this.Name;
        }
        public override int Get_Cost()
        {
            return this.Cost;
        }
    }
}
