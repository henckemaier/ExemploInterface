﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploInterface.ConsoleApp
{
    interface IPadrao //interface ja é publico por padrão
    {
        void somar(int n1, int n2);

        void subtrair(int n1, int n2);
    }
}
