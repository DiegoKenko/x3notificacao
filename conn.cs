using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace c
{
    public class Conn
    {
        public List<string> connect()
        {
            List<string> aRet = new List<string>();
            using (SqlConnection con = new SqlConnection("server=10.2.0.4;database=DADOSMP11;integrated Security=SSPI;"))
            {
                string queryStatement = "SELECT * FROM VW_ATUALIZACAO_X3;";


                var sqlCmd = new SqlCommand(queryStatement, con);
                con.Open();
                using (SqlDataReader rdr = sqlCmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                            try
                            {
                                aRet.Add("Empresa: " + rdr["EMPRESA"].ToString());
                            }
                            catch (Exception ex) { }
                            
                    }

                }


            }

            return aRet;
        }
   
    }
}
