using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Teste
    {
        private static Teste teste;

        public static Teste GetInstance()
        {
            if (teste == null) teste = new Teste();
            return teste;

        }

        private Teste()
        {
        }
    }
}
