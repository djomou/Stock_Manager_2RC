using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Manager_2RC
{
    class Fonctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConString;

        public Fonctions()
        {
            ConString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\2RCStockManagerBD.mdf;Integrated Security=True";
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable RecupererDonnees(string Req) 
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Req, ConString);
            sda.Fill(dt);
            return dt;
        }
        public int EnvoyerDonnees(string Req)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed) 
            {
                Con.Open();
            }
            Cmd.CommandText = Req;
            cnt = Cmd.ExecuteNonQuery();
            return cnt;
        }  
    }
}
