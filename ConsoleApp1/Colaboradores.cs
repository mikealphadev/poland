using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
    class Colaboradores
    {

        string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }


        string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        DateTime _dataCadastro;
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }

        int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        string _funcao;
        public string Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }

        bool _maiorIdade;
        public bool MaiorIdade
        {
            get { return _maiorIdade; }
            set { _maiorIdade = value; }
        }




    }
}
