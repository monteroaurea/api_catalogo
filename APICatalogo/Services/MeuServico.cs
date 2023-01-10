using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Services
{
    public class MeuServico : IMeusServicos
    {
    public string Saudacao(string nome)
    {
        return $"Bem-Vindo, {nome} \n\n{DateTime.Now}";
    }
}
}