# Librarycalc21
Biblioteca de calculos matemáticos 


[![Build status](https://ci.appveyor.com/api/projects/status/k331mrmxhh2ew72w/branch/master?svg=true)](https://ci.appveyor.com/project/yuri-lencio/librarycalc21-avrvd/branch/master)

## how to install
Install-Package librarycalc21 -Version 1.0.3

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc21.svg)

## how to use

```cs
using librarycalc21;
using System;

namespace calculadoratestes
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora calculadora = new calculadora();

            var result = calculadora.somar(2, 2);

            Console.WriteLine(result);
        }
    }
}

```
