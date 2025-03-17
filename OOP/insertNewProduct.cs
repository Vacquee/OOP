﻿using System;
using MySql.Data.MySqlClient;

namespace OOP
{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private string connString;

            public InsertNewProduct()
            {
                string server = "localhost";
                string database = "csharpapp";
                string username = "root";
                string password = "";
                connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }

            public void InsertData(string productName, int productPrice, string productDescription)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected to MySQL!");

                        string countQuery = "SELECT COUNT(*) FROM products";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (rowCount >= 5)
                            {
                                Console.WriteLine(@"

                                                                                    ██╗     ██╗███╗   ███╗██╗████████╗    ██████╗ ███████╗ █████╗  ██████╗██╗  ██╗███████╗██████╗ ██╗
                                                                                    ██║     ██║████╗ ████║██║╚══██╔══╝    ██╔══██╗██╔════╝██╔══██╗██╔════╝██║  ██║██╔════╝██╔══██╗██║
                                                                                    ██║     ██║██╔████╔██║██║   ██║       ██████╔╝█████╗  ███████║██║     ███████║█████╗  ██║  ██║██║
                                                                                    ██║     ██║██║╚██╔╝██║██║   ██║       ██╔══██╗██╔══╝  ██╔══██║██║     ██╔══██║██╔══╝  ██║  ██║╚═╝
                                                                                    ███████╗██║██║ ╚═╝ ██║██║   ██║       ██║  ██║███████╗██║  ██║╚██████╗██║  ██║███████╗██████╔╝██╗
                                                                                    ╚══════╝╚═╝╚═╝     ╚═╝╚═╝   ╚═╝       ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝




                                    Database limit reached! Maximum of 5 products allowed.");
                                return;
                            }
                        }

                        string query = "INSERT INTO products (productName, productPrice, productDescription) VALUES (@name, @price, @description)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            cmd.Parameters.AddWithValue("@description", productDescription);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine(rowsAffected > 0 ? @"              




                                            ██████   █████  ████████  █████      ██ ███    ██ ███████ ███████ ██████  ████████ ███████ ██████      ███████ ██    ██  ██████  ██████ ███████ ███████ ███████ ███████ ██    ██ ██      ██      ██    ██ ██ 
                                            ██   ██ ██   ██    ██    ██   ██     ██ ████   ██ ██      ██      ██   ██    ██    ██      ██   ██     ██      ██    ██ ██      ██      ██      ██      ██      ██      ██    ██ ██      ██       ██  ██  ██ 
                                            ██   ██ ███████    ██    ███████     ██ ██ ██  ██ ███████ █████   ██████     ██    █████   ██   ██     ███████ ██    ██ ██      ██      █████   ███████ ███████ █████   ██    ██ ██      ██        ████   ██ 
                                            ██   ██ ██   ██    ██    ██   ██     ██ ██  ██ ██      ██ ██      ██   ██    ██    ██      ██   ██          ██ ██    ██ ██      ██      ██           ██      ██ ██      ██    ██ ██      ██         ██       
                                            ██████  ██   ██    ██    ██   ██     ██ ██   ████ ███████ ███████ ██   ██    ██    ███████ ██████      ███████  ██████   ██████  ██████ ███████ ███████ ███████ ██       ██████  ███████ ███████    ██    ██ "







: "");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
} 