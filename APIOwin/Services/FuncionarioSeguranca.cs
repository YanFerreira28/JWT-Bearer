using APIOwin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIOwin.Services
{
    public class FuncionarioSeguranca
    {
        public static bool Login(string nome, string senha)
        {
            using(OwinEntities _context = new OwinEntities())
            {
                var user =_context.Usuario.Where(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase) && c.Senha == senha).FirstOrDefault();

                if(user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}