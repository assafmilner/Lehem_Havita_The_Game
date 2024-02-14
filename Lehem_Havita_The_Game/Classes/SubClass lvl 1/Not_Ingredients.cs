namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents an abstract base class for non-ingredient items
    public abstract class Not_Ingredients : Falling_Item
    {

        public int Effect_On_Lives;
        public int Effect_On_Score;
        public int Effect_On_Time;
        public string Realeted_Sentence;
        // Constructor (no specific implementation in this class)
        public Not_Ingredients()
        {
            // No additional logic here
        }

        // Destructor (no specific implementation in this class)
        ~Not_Ingredients()
        {
            // No additional logic here
        }
        public virtual void Effect_Activation(Player p) { }
    }
}