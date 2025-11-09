using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    //os campos com get e set, podemos pegar as informações que estão armazenadas neles e também podemos atribuir novos valores a eles
    public class Quarto
    {
        public string Descricao { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
    }
}
