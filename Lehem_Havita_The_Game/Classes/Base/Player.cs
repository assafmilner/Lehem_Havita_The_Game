namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents a player in the game
    public class Player
    {
        // Private field to reference the game form
        private Game Game_Form;

        // Properties
        public string Name { get; set; }
        public int Score;
        public int lives;

        // Constructor to initialize player properties
        public Player(Game GF, string name)
        {
            Game_Form = GF;
            this.Name = name;
            this.lives = 5;
        }

        // Update the score and display it
        public void Update_score_to_post()
        {
            Game_Form.Post_score(Score);
        }

        // Add points to the player's score
        public void Add_to_score(int added_Score)
        {
            string viki_comment = "אליפות!";
            this.Score += added_Score;
            if (Score < 0) Score = 0;
            Update_score_to_post();
            if(added_Score < 0) viki_comment = "מה קשור?!";
            Game_Form.Talking_viki(viki_comment); // Display a message
        }


        public void Get_effect_on_player(int e_lives , int e_time , int e_score , string sentence)
        {
            if (lives <= 6 && lives > 0) lives += e_lives;
            if (lives > 5) lives = 5;
            if (Score + e_score < 0) Score = 0;
            else Score += e_score;
            Game_Form.Effect_time(e_time);
            Game_Form.Talking_viki(sentence);
            if (lives <= 5) Game_Form.Update_life_display(lives);
            Update_score_to_post();
            if (lives == 0) GameState.Game_is_Active = false;
        }
    }
}