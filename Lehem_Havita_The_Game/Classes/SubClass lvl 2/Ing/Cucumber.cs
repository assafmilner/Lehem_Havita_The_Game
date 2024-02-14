using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Cucumber ingredient in the game
    public class Cucumber : Ingredients
    {
        // Constructor to initialize the Cucumber ingredient
        public Cucumber(int add_to_falling_speed)
        {
            Id = 2; // ID for Cucumber ingredient
            Name = GameState.Ing_names[Id]; // Name of the ingredient
            ImagePath = GameState.imagePaths[Id]; // Image path for the ingredient
            this.Cost = 3; // Cost of the ingredient
            Picture.Image = Image.FromFile(ImagePath); // Load the ingredient image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
        }

        // Destructor
        ~Cucumber()
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
