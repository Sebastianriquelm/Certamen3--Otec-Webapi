using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace OtecLibrary
{
    class ConectionBD
    {
        public SqlConnection conexion = new SqlConnection("Data Source=200.36.208.13;Initial Catalog=pooipvg;User ID=ipvg;Password=ipvg"); 

        public void Conectarbd()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }
        public void Cerrarbd()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        public DataSet listar(string query)
        {
            Conectarbd();

            DataSet data = new DataSet();                                            
            SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
            adapter.Fill(data);                                                       
            Cerrarbd();
            return data;
        }

        public int GuardarDatos(string query)
        {
            Conectarbd();
            SqlCommand ingr = new SqlCommand(query, conexion);
            int resul = ingr.ExecuteNonQuery();
            Cerrarbd();
            return resul;
        }
        public DataSet listado(String codAsi, List<Parametros_ASIG> lst)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter da;
            try
            {
                Conectarbd();
                da = new SqlDataAdapter(codAsi, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].SP_asig1, lst[i].Val_asig1);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Cerrarbd();
            return dt;
        }
    }
}
