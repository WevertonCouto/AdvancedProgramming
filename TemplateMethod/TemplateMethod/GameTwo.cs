using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class GameTwo : Game
    {
        protected override void EndPlay() => Console.WriteLine("End play");

        protected override void Initialize() => Console.WriteLine("Initialize");

        protected override void StartPlay() => Console.WriteLine("Start play");
    }
}
