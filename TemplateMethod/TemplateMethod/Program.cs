using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gameOne = new GameOne();
            gameOne.Play();

            Game gameTwo = new GameTwo();
            gameTwo.Play();
        }
    }
}
