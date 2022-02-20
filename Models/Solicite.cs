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


    public static class Solicite
    {

        public static Agendamento Sol { get; set; }

        static Solicite()

        {

            Sol = new Agendamento();

        }

    }
}