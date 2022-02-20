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
    public class DadosAg
    {
        public string Nome {get; set; }
        public int Telefone {get; set; }
        public int Idade { get; set; }
        public string Agem { get; set; }
        public string Animal { get; set; }
        public string Necessidade { get; set; }
        public int Data { get; set; }
    }
}