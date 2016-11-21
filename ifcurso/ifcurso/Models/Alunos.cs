using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ifcurso.Models
{
    public class Alunos
    {
        public int  Id { get; set; }
        public String Nome { get; set; }
        public String numDocumento { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}