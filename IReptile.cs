﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion8
{
    interface IReptile : IAnimal, ICarnivorous
    {
        void Habitat();
    }
}
