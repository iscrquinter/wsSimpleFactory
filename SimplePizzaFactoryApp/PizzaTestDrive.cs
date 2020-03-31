using System;

namespace pizzas
{
    public class PizzaTestDrive {
        static void Main(string[] args) {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");

            pizza = store.orderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");

            Console.ReadLine();
        }
    }
}