using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Validación_códigos
{
    internal class ConsultasDB{

        public void Crear_Cliente(int idt, string nom, DateTime nac){
            ConexionDB con = new ConexionDB();
            using (var conexionsql = con.GetConnection()){
                conexionsql.Open();
                using (var cmd = new SqlCommand("Crear_Cliente", conexionsql)){
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idt", idt);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@nac", nac);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int Validar_Codigo(int idt){
            ConexionDB con = new ConexionDB();
            using (SqlConnection conexionSql = con.GetConnection()){
                conexionSql.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.Validar_Codigo(@idt)",conexionSql);
                cmd.Parameters.Add("@idt", SqlDbType.Int).Value = idt;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Crear_Tarjeta(int idt){
            ConexionDB con = new ConexionDB();
            using (var conexionsql = con.GetConnection()){
                conexionsql.Open();
                using (var cmd = new SqlCommand("Crear_Tarjeta", conexionsql)){
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idt", idt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Cargar_Saldo(int idt, decimal monto){
            ConexionDB con = new ConexionDB();
            using (var conexionsql = con.GetConnection()){
                conexionsql.Open();
                using (var cmd = new SqlCommand("Cargar_Saldo", conexionsql)){
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idt", idt);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public decimal Consulta_Saldo(int idt){
            ConexionDB con = new ConexionDB();
            using (SqlConnection conexionSql = con.GetConnection()){
                conexionSql.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.Consulta_Saldo(@idt)",conexionSql);
                cmd.Parameters.Add("@idt", SqlDbType.Int).Value = idt;
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}
