using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Cockroach item in the game
    public class Cockroach : Not_Ingredients
    {
        // Constructor to initialize the Cockroach item
        public Cockroach(int add_to_falling_speed)
        {
            Id = 3; // ID for Cockroach item
            Name = GameState.Not_Ing_names[Id]; // Name of the item
            ImagePath = GameState.imagePaths1[Id]; // Image path for the item
            Picture.Image = Image.FromFile(ImagePath); // Load the item image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
            this.Effect_On_Lives = 0;
            this.Effect_On_Score = -10;
            this.Effect_On_Time = -10;
            this.Realeted_Sentence = "איכס!!";
        }

        // Destructor
        ~Cockroach()
        {

        }

        public override void Effect_Activation(Player p)
        {
            p.Get_effect_on_player(Effect_On_Lives, Effect_On_Time, Effect_On_Score, Realeted_Sentence);
        }
    }
}
