using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;
namespace PetVet.Models
{
    public class Agendamento
    {
        private static List<DadosAg> lista = new List<DadosAg>();
        public void AdicionarPedido(DadosAg item){
            lista.Add(item);
        }
        public  List<DadosAg> Show(){
            return lista; 
        }
    }
}