﻿namespace SOLID
{
    public class DrinkEvaluation : IDrinkEvaluation
    {
        public void Evaluate()
        {
            Console.WriteLine("Please evaluate the drink out of 10");
        }

        public void Comment()
        {
            Console.WriteLine("Please comment on the drink");
        }
    }
}
