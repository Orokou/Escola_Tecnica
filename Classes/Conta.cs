using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Conta
    {
        private static string email;
        private static string senha;
        private static string permissao;

        public static string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public static string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
        public static string Permissao
        {
            get
            {
                return permissao;
            }

            set
            {
                permissao = value;
            }
        }
    }
}
