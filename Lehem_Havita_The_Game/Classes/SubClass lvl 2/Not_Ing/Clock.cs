using Lehem_Havita_The_Game.Classes.Base;
using System.Drawing;

namespace Lehem_Havita_The_Game
{
    // Represents the Clock item in the game
    public class Clock : Not_Ingredients
    {
        // Constructor to initialize the Clock item
        public Clock(int add_to_falling_speed)
        {
            Id = 2; // ID for Clock item
            Name = GameState.Not_Ing_names[Id]; // Name of the item
            ImagePath = GameState.imagePaths1[Id]; // Image path for the item
            Picture.Image = Image.FromFile(ImagePath); // Load the item image
            this.Falling_speed += add_to_falling_speed; // Adjust falling speed
            this.Effect_On_Lives = 0;
            this.Effect_On_Score = 10;
            this.Effect_On_Time = 15;
            this.Realeted_Sentence = "קח ת'זמן!";
        }

        // Destructor
        ~Clock()
        {

        }

        public override void Effect_Activation(Player p)
        {
            p.Get_effect_on_player(Effect_On_Lives, Effect_On_Time, Effect_On_Score, Realeted_Sentence);
        }
    }
}
