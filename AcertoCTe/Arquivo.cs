using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcertoCTe
{
    class Arquivo
    {
        public static void CopiarArquivos()
        {
            if (System.IO.File.Exists(@"C:\WINTHOR\Prod\PCFES\FuncoesWinthor.dll"))
                System.IO.File.Delete(@"C:\WINTHOR\Prod\PCFES\FuncoesWinthor.dll");

            System.IO.File.Copy(@"P:\PCFES\FuncoesWinthor.dll", @"C:\WINTHOR\Prod\PCFES\FuncoesWinthor.dll");
        }
    }
}
