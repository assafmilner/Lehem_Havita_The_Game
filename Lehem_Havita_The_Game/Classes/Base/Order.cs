using System;
using System.Collections.Generic;

namespace Lehem_Havita_The_Game.Classes.Base
{
    // Represents an order in the game
    public class Order

    {
        // Properties
        public List<string> Ing_list { get; set; }
        public List<string> Current_Order { get; set; }
        public int Order_count{ get; set; }
        private Game Game_Form;
        private Random rand;

        // Constructor
        public Order(Game GF)
        {
            // Initialize variables and load initial ingredient list
            rand = new Random();
            Game_Form = GF;
            Ing_list = new List<string>();
            Current_Order = new List<string>();
            Load_ing_list();
            Order_count = 0;
            Game_Form.Update_sandwich_count(0);
        }

        // Create a new order
        public void Make_new_order()
        {
            // Generate a new order with random ingredients
            int i;
            for (i = 0; i < 5; i++)
            {
                Get_new_ing_to_list();
            }
            Load_ing_list();
            Game_Form.Post_ing(Current_Order);
        }

        // Add a new ingredient to the current order
        private void Get_new_ing_to_list()
        {

            int index = rand.Next(0, Ing_list.Count);
            Current_Order.Add(Ing_list[index]);
            Ing_list.RemoveAt(index);
        }

        // Check if an ingredient is in the current order
        public bool Is_in_Order(string ing_name)
        {
            if (Current_Order.Contains(ing_name)) return true;
            else return false;
        }

        // Complete an order and update the order count
        public void Complete_order()
        {
            Order_count++;
            Game_Form.Update_sandwich_count(Order_count);
        }

        // Remove an ingredient from the current order
        public void Remove_from_current_order(string ing)
        {
            Game_Form.Remove_ing_from_order_display(ing);
            Current_Order.Remove(ing);
        }

        // Load initial list of ingredients
        private void Load_ing_list()
        {
            Ing_list.Clear();
            Ing_list.Add("Chuma Chilli");
            Ing_list.Add("Cucumber");
            Ing_list.Add("Fried Egg");
            Ing_list.Add("Onion");
            Ing_list.Add("Mayo");
            Ing_list.Add("Margez");
            Ing_list.Add("Tomato");
        }
    }
}