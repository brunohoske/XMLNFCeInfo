﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLSearch.Models
{
    public class XmlNfce
    {
        public string FileName { get; set; }
        public XDocument XML = new XDocument();
        public long NumNfce { get; set; }
        public int? Serie { get; set; }
        public string? Cnpj { get; set; }
        public DateTime? DataHora { get; set; }
        public int? Modelo { get; set; }
        public int? QuantItens { get; set; }
        public int? Status { get; set; }
        public string? Motivo { get; set; }
        public double Total {  get; set; }
        public double TotalItens { get; set; }
        public double TotalDesconto { get; set; }
        public double TotalPag {  get; set; }
        public double TotalTroco { get; set; }
        public string ChaveDeAcesso { get; set; }
        public long Cupom {  get; set; }
        public int? TipoPagamento { get; set; }
        public XmlNfce()
        {
            TotalTroco = 0;
        }
        public XmlNfce(long numNfce, int serie)
        {
            NumNfce = numNfce;
            Serie = serie;
        }

        public override string ToString()
        {
            return $"NFCe:{NumNfce}\r\n Serie:{Serie}";
        }

       
    }
}
