//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Lunary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ranking
    {
        public int RESTAUID { get; set; }
        public string RESTANOME { get; set; }
        public double RESTAPRECO { get; set; }
        public string RESTADESCRICAO { get; set; }
        public string RESTACATEGORIA { get; set; }
        public Nullable<int> Curtidas { get; set; }
        public byte[] imagem { get; set; }
        public Nullable<double> RESTAPREPROMOCAO { get; set; }
    }
}