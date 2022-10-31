using Estacionamento.Models.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Estacionamento.Models.DAO
{
    public class clienteDados_DAL
    {
        String _conexaoMySQL = null;
        MySqlConnection con = null;
        //String Conexão
        public clienteDados_DAL()
        {
            _conexaoMySQL = ConfigurationManager.ConnectionStrings["conexaoMySQL"].ToString();
        }
        // Selecionar Lista Cliente
        public List<clienteModelo_DTO> selectListCliente()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select * from cliente", conn))
                    {
                        conn.Open();
                        List<clienteModelo_DTO> listaCliente = new List<clienteModelo_DTO>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                clienteModelo_DTO cliente = new clienteModelo_DTO();
                                cliente.CodigoCliente = (int)dr["idcliente"];
                                cliente.Nome = (String)dr["nome"];
                                cliente.Placa = (String)dr["placa"];
                                cliente.ValorMens = (String)(dr["valorMens"]);
                                cliente.CPF = (String)dr["cpf"];
                                // cliente.Veiculo.IdVeiculo = (int)dr["idveiculo"];
                                //  cliente.Usuario.Codigo = (int)dr["id"];


                                listaCliente.Add(cliente);
                            }
                        }
                        return listaCliente;
                    }
                }
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco ao Listar cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação ao Listar cliente" + ex.Message);
            }
        }

        // Selecionar Lista Cliente
        public List<clienteModelo_DTO> listaClienteDetalhes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("Select * from cliente", conn))
                    {
                        conn.Open();
                        List<clienteModelo_DTO> listaCliente = new List<clienteModelo_DTO>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                clienteModelo_DTO cliente = new clienteModelo_DTO();
                                cliente.CodigoCliente = (int)dr["idcliente"];
                                cliente.Nome = (String)dr["nome"];
                                cliente.Placa = (String)dr["placa"];
                                cliente.ValorMens = (String)(dr["valorMens"]).ToString().Replace(".",",");
                                cliente.CPF = (String)dr["cpf"];
                                cliente.Telefone = (String)dr["Telefone"];
                                cliente.Celular = (String)dr["Celular"];
                                // cliente.Veiculo.IdVeiculo = (int)dr["idveiculo"];
                                //  cliente.Usuario.Codigo = (int)dr["id"];


                                listaCliente.Add(cliente);
                            }
                        }
                        return listaCliente;
                    }
                }
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco ao Listar cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação ao Listar cliente" + ex.Message);
            }
        }
        // Selecionar Lista cliente Por Id
        public List<clienteModelo_DTO> selectListClientePorId(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_conexaoMySQL))
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM cliente WHERE idCliente = @idCliente", conn))
                    {
                        command.Parameters.AddWithValue("@idCliente", id);
                        conn.Open();
                        List<clienteModelo_DTO> listaCliente = new List<clienteModelo_DTO>();
                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                clienteModelo_DTO clienteDto = new clienteModelo_DTO();

                                clienteDto.CodigoCliente = Convert.ToInt32(dr["idCliente"]);
                                clienteDto.Nome = dr["nome"].ToString();
                                clienteDto.CPF = dr["cpf"].ToString();
                                clienteDto.Placa = dr["placa"].ToString();
                                clienteDto.ValorMens = dr["valorMens"].ToString().Replace("", ",");
                                //  clienteDto.Veiculo.IdVeiculo = Convert.ToInt32(dr["idveiculo"]);
                                //clienteDto.Privilegio = dr["privilegios"].ToString();
                                //clienteDto.Status = dr["status"].ToString();

                                listaCliente.Add(clienteDto);
                            }
                        }
                        return listaCliente;
                    }
                }
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco ao Listar cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação ao Listar cliente" + ex.Message);
            }
        }

        //Inserir Cliente
        public void inserirCliente(clienteModelo_DTO cliente)
        {
            try
            {
                String sql = "INSERT INTO cliente (nome,cpf,placa,Telefone, Celular, valorMens) " +
                              " VALUES (@nome,@cpf,@placa,@Telefone, @Celular@valorMens) ";
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@placa", cliente.Placa);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@valorMens", cliente.ValorMens.Replace(",","."));
                //cmd.Parameters.AddWithValue("@privilegios", cliente.Privilegio);
                //cmd.Parameters.AddWithValue("@status", cliente.Status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco em cadastro cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação em cadastro cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // UPDATE Cliente
        public void updateCliente(clienteModelo_DTO cliente)
        {
            try
            {
                String sql = " UPDATE cliente SET nome=@nome,cpf=@cpf,placa=@placa, Telefone=@Telefone," +
                             " Celular=@Celular, valorMens=@valorMens  WHERE idcliente = @idcliente; ";

                //Alter Cliente
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Placa);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);                
                cmd.Parameters.AddWithValue("@valorMens", cliente.ValorMens.Replace(",", "."));                
                cmd.Parameters.AddWithValue("@IdCli", cliente.CodigoCliente);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco ao atualizar dados do cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação ao atualizar dados do cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // Deletar Usuario
        public void deletecliente(clienteModelo_DTO cliente)
        {
            try
            {
                String sql = "DELETE FROM cliente WHERE idcliente = @idcliente ";
                MySqlConnection con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idcliente", cliente.CodigoCliente);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro no banco ao deletar cliente" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na aplicação ao deletar cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}