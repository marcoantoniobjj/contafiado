using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaFiado.Model
{
    public class Clientes
    {
        string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }


        string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        string _logradouro;
        public string Logradouro 
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        string _estado;
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        bool _maiorIdade;
        public bool MaiorIdade
        {
            get { return _maiorIdade; }
            set { _maiorIdade = value; }
        }