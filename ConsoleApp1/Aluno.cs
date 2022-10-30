using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Model
{
    public class Aluno
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

        DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        decimal _peso;
        public decimal Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        bool _maiorIdade;
        public bool MaiorIdade
        {
            get { return _maiorIdade; }
            set { _maiorIdade = value; }
        }

    }
}
