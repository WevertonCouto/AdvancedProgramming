using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class Game
    {
        abstract protected void Initialize();
        abstract protected void StartPlay();
        abstract protected void EndPlay();

        public void Play()
        {
            this.Initialize();
            this.StartPlay();
            this.EndPlay();
        }
    }
}
