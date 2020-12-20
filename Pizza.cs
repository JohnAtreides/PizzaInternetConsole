using System;
namespace PizzaInternetConsole {
    public class Pizza {

        protected String name;
        private int price;
        protected String[] ingredients;

        //Constructor
        public Pizza(String pizzaName, int pizzaPrice, String[] pizzaIngredients) {
            this.name = pizzaName;
            this.price = pizzaPrice;
            this.ingredients = pizzaIngredients;
        }

        virtual public void DisplayPizza() {
            Console.WriteLine("Pizza : " + name + " - " + price + "€");
            Console.WriteLine(String.Join(", ", ingredients));
        }
    }
}
