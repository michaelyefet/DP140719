﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_EX15
{
    class MushroomTopping : ToppingDecoratorBase
    {
        public MushroomTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " nice mushroom";
        }

        public override double GetPrice()
        {
            return this.pizza.GetPrice() + 7;
        }
    }
}
