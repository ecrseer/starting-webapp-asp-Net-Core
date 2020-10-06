using System;
using System.ComponentModel.DataAnnotations;

namespace aspnetcoreapp.Modelos
{
    public class Filme{
      public int id{get;set;}
      public string Titulo{get;set;}
      public string Genero{get;set;}

      [DataType(DataType.Date)]
      public DateTime DataLancamento{get;set;}
      
    }
}