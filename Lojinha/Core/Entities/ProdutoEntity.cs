using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha.Core.Entities
{
    public class ProdutoEntity : TableEntity
    {
        public ProdutoEntity()
        {

        }
        public ProdutoEntity(string partitonKey, string rowkey)
            : base(partitonKey, rowkey)
        {

        }

        public string Produto { get; set; }
    }
}
