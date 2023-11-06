using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcertoCTe
{
    class ConhecimentoVO
    {
        int carregamento;

        public int Carregamento
        {
            get { return carregamento; }
            set { carregamento = value; }
        }

        int nota;

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        int filial;

        public int Filial
        {
            get { return filial; }
            set { filial = value; }
        }

        TipoAtualizacao tipo;

        public TipoAtualizacao Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
