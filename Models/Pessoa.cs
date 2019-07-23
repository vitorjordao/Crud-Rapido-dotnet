using System;
namespace CrudRapido.Models
{
    public class Pessoa
    {
        public int Id{get; set;}
        public string Nome{get; set;}
        public int Idade{get; set;} 
        public DateTime Data{get; set;}

        public Pessoa(){}

        public Pessoa(int id, string nome, int idade, DateTime data)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Data = data;
        }
    }
}