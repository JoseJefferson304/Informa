using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Informa.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public string Valor { get; set; }
    }
}