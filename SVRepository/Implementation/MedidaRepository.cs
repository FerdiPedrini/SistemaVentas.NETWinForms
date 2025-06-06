﻿using Microsoft.Data.SqlClient;
using SVRepository.DB;
using SVRepository.Entities;
using SVRepository.Interfaces;
using System.Data;

namespace SVRepository.Implementation
{
    public class MedidaRepository : IMedidaRepository
    {
        private readonly Conexion _conexion;
        public MedidaRepository(Conexion conexion)
        {
                _conexion = conexion;
        }
        public async Task<List<Medida>> Listar()
        {
            List<Medida> lista = new List<Medida>();
            try
            {
                using (var con = _conexion.ObtenerSQLConexion())
                {
                    con.Open();
                    var cmd = new SqlCommand("sp_listaMedida", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            lista.Add(new Medida
                            {
                                IdMedida = Convert.ToInt32(dr["IdMedida"]),
                                Nombre = dr["Nombre"].ToString(),
                                Abreviatura = dr["Abreviatura"].ToString(),
                                Equivalente = dr["Equivalente"].ToString(),
                                Valor = Convert.ToInt32(dr["Valor"]),
                            });
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error inesperado al listar medidas", ex);
            }
            
            
        }
    }
}
