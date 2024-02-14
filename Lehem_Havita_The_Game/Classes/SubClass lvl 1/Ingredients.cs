namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents an abstract base class for ingredients
    public abstract class Ingredients : Falling_Item
    {

        public int Cost;

        // Constructor (no specific implementation in this class)
        public Ingredients()
        {
            // No additional logic here
        }

        // Destructor (no specific implementation in this class)
        ~Ingredients()
        {
            // No additional logic here
        }

        public virtual string Get_Name() { return ""; }
        public virtual int Get_Cost() { return 0; }
    }
}