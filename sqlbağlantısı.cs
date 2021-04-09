using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace hastaneproje
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-VGGLDV2; Initial Catalog = Hastane; Integrated Security = True");
             baglan.Open();
             return baglan;
        }
    }
}
