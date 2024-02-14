using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Viki_Heart item in the game
    public class Viki_Heart : Not_Ingredients
    {
        // Constructor to initialize the Viki_Heart item
        public Viki_Heart(int add_to_falling_speed)
        {
            Id = 4; // ID for Viki_Heart item
            Name = GameState.Not_Ing_names[Id]; // Name of the item
            ImagePath = GameState.imagePaths1[Id]; // Image path for the item
            Picture.Image = Image.FromFile(ImagePath); // Load the item image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
            this.Effect_On_Lives = 1;
            this.Effect_On_Score = 20;
            this.Effect_On_Time = 10;
            this.Realeted_Sentence = "איזה נשמה!";

        }

        // Destructor
        ~Viki_Heart()
        {

        }
        public override void Effect_Activation(Player p)
        {
            p.Get_effect_on_player(Effect_On_Lives, Effect_On_Time, Effect_On_Score, Realeted_Sentence);
        }

    }
}