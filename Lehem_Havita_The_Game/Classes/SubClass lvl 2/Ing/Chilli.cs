using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Chilli ingredient in the game
    public class Chilli : Ingredients
    {
        // Constructor to initialize the Chilli ingredient
        public Chilli(int add_to_falling_speed)
        {
            Id = 1; // ID for Chilli ingredient
            Name = GameState.Ing_names[Id]; // Name of the ingredient
            ImagePath = GameState.imagePaths[Id]; // Image path for the ingredient
            this.Cost = 5; // Cost of the ingredient
            Picture.Image = Image.FromFile(ImagePath); // Load the ingredient image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
        }

        // Destructor
        ~Chilli()
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