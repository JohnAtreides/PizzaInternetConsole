using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaInternetConsole {
    class MainClass {
      
        public static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            String pizzasJson = "[{\"name\":\"4 fromages\",\"price\":11,\"ingredients\":[\"emmental\",\"chèvre\",\"mozzarella\",\"conté\"]},{\"name\":\"Végétarienne\",\"price\":7,\"ingredients\":[\"bleu\",\"emmental\",\"brie\",\"reblochon\"]},{\"name\":\"Norvégienne\",\"price\":16,\"ingredients\":[\"crème\",\"saumon fumé\",\"oigons crus\"]},{\"name\":\"Normande\",\"price\":12,\"ingredients\":[\"brie\",\"pommes\",\"oignons\"]},{\"name\":\"Louis Vuitton\",\"price\":200,\"ingredients\":[\"oeufs d'esturgeons\",\"truffe\",\"gelée royale\",\"poutargue\",\"cèpes\",\"boeuf kobe\"]},{\"name\":\"Louis Vuitton\",\"price\":200,\"ingredients\":[\"oeufs d'esturgeons\",\"truffe\",\"gelée royale\",\"poutargue\",\"cèpes\",\"boeuf kobe\"]},{\"name\":\"Végétarienne\",\"price\":9,\"ingredients\":[\"salade\",\"tomates\",\"oignons\",\"poivrons\",\"olives\"]},{\"name\":\"Montagnarde\",\"price\":15,\"ingredients\":[\"reblochon\",\"pommes de terre\",\"oignons\"]}]";

            List<Pizza> pizzasList = JsonConvert.DeserializeObject<List<Pizza>>(pizzasJson);

            /*
            List<Pizza> pizzasList = new List<Pizza>();

            pizzasList.Add(new Pizza("4 fromages", 11, new string[] { "emmental", "chèvre", "mozzarella", "conté" }));
            pizzasList.Add(new Pizza("Norvégienne", 16, new string[] { "crème", "saumon fumé", "oigons crus" }));
            pizzasList.Add(new Pizza("Normande", 12, new string[] { "brie", "pommes", "oignons" }));
            pizzasList.Add(new Pizza("Louis Vuitton", 200, new string[] { "oeufs d'esturgeons", "truffe", "gelée royale", "poutargue", "cèpes", "boeuf kobe" }));
            pizzasList.Add(new Pizza("Végétarienne", 9, new string[] { "salade", "tomates", "oignons", "poivrons", "olives" }));
            pizzasList.Add(new Pizza("Montagnarde", 15, new string[] { "reblochon", "pommes de terre", "oignons" }));
            */

            foreach (Pizza p in pizzasList) {
                p.DisplayPizza();
            }

        }
    }
}
