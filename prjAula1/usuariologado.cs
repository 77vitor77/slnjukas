using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace prjAula1
{
        public static class UsuarioLogado
        {
            public static int Id { get; set; }
            public static string? NomeCliente { get; set; }
            public static string? Cpf { get; set; }
            public static string? RG { get; set; }
            public static int? Senha { get; set; }
            public static DateTime? DataNascimento { get; set; }    
            public static string? Email { get; set; }
            public static string? sexo { get; set; }
            public static string? Celular { get; set; }
            public static string? Endereço { get; set; }
            public static string? Complemento { get; set; }
            public static string? Cidade { get; set; }
            public static string? Estado { get; set; }
            



            public static List<Conta> Contas = new List<Conta>();



            public static void Deslogar()
            {
                UsuarioLogado.Id = 0;
                UsuarioLogado.NomeCliente = String.Empty;
                UsuarioLogado.DataNascimento = null;
                UsuarioLogado.RG = String.Empty;
                UsuarioLogado.Email = String.Empty;
                UsuarioLogado.Endereço = null;
                UsuarioLogado.Cidade = String.Empty;
                UsuarioLogado.Estado = String.Empty;
                UsuarioLogado.Cpf = String.Empty;
                UsuarioLogado.Celular = String.Empty;
                UsuarioLogado.Senha = 0;
                UsuarioLogado.Contas.Clear();
            }
        }   
}
