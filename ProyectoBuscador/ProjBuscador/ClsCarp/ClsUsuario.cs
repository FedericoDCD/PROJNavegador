using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProjBuscador.ClsCarp
{
    class ClsUsuario
    {
        public void ABusqueda(ClsBusqueda ObjPelicula)
        {//Doy de alta a la búsqueda
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la película
            string URL = ObjPelicula.GetURL();
           
            using (SqlCommand comand = new SqlCommand("PRAInsertarBusqueda", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@URL", URL));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar la búsqueda: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable BuscarBusquedas()
        {
            ClsBD BD = new ClsBD();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarHistorial", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado, error buscando: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
    }
}
