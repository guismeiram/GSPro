using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Bussines.models
{
    public class Siati : Entity
    {
        public Boolean Resolvido { get; set; }
        public String Resolucao { get; set; }
        public String NumeroProcesso { get; set; }
        public DateTime DataCriacaoProcesso { get; set; }
        public String TipoProcesso { get; set; }
        public String NomeProcesso { get; set; }
        public String NomeUser { get; set; }

    }
}
