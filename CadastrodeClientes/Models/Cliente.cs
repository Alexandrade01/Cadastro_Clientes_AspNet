using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeClientes.Models
{
    //Criacao de tabela de clientes
    [Table("Clientes")]
    public class Cliente
    { //Regra de negocio do cliente, usando Id,Nome,Telefone e Email
        //Display o que sera mostrado e column em qual coluna

        [Display(Name = "ID")]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
    }
}
