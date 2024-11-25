using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.cs.Classes
{
    internal class GerenciadorDB
    {
        private string connectionString = "Server=localhost;Database=Mercado;User ID=root;Password=;Persist Security Info=True;Convert Zero Datetime=True";
        // string connection = "Server=localhost;Database=Mercado;User ID=root;Password=;";

        public string getConnectionString()
        {
            return this.connectionString;
        }
    }
}
