using H_3_Bolcher__WebPage_.Models;
using Microsoft.Data.SqlClient;

namespace H_3_Bolcher__WebPage_.Database
{
    public class Db
    {
        string CornectionString = "Server=localhost;Database=H3Bolcher;Trusted_Connection=True;TrustServerCertificate=True;";
        public Db()
        {

        }
        public List<Bolcher> /*Bolcher*/ GetAllBolcher()
        {
            List<Bolcher> list = new List<Bolcher>();
            Bolcher b = null;
            string queryString = " EXEC GetAllFromBolche;";


            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();



                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }






        public List<Bolcher> /*Bolcher*/ GetAllBolcherWhereSearchWordIs(string SearchBox)
        {
            List<Bolcher> list = new List<Bolcher>();

            string queryString = "EXEC GetAllFromBolcheWhereSearchWordIs @SearchWord =" + SearchBox;


            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();



                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }

        public List<Bolcher> /*Bolcher*/ GetAllBolcherWhereSearchWordIsFromBegining(string SearchBox)
        {
            List<Bolcher> list = new List<Bolcher>();
            Bolcher b = null;
            string queryString = " EXEC GetAllFromBolcheWhereSearchWordIsFromBegining @SearchWord =" + SearchBox;

            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();
                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }

        public List<Bolcher> /*Bolcher*/ GetAllBolcherWhereSearchWordIsFromBeginingWithColor(string SearchBox, string Color)
        {
            List<Bolcher> list = new List<Bolcher>();
            Bolcher b = null;
            string queryString = " EXEC GetAllBolcherWhereSearchWordIsFromBeginingWithColor @SearchWord =" + SearchBox + ", @Color =" + Color;

            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }
        public List<Bolcher> /*Bolcher*/ GetAllBolcherWhereSearchWordIsWithColor(string SearchBox, string Color)
        {
            List<Bolcher> list = new List<Bolcher>();
            Bolcher b = null;
            string queryString = " EXEC GetAllBolcherWhereSearchWordIsWithColor @SearchWord =" + SearchBox + ", @Color =" + Color;


            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }
        public List<Bolcher> /*Bolcher*/ GetAllBolcherWithColor(string Color)
        {
            List<Bolcher> list = new List<Bolcher>();
            Bolcher b = null;
            string queryString = " EXEC GetAllBolcherWithColor @Color =" + Color;


            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            string Faver = (string)reader["FaveNavn"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            string Smag_Surhed = (string)reader["SsuNavn"];
                            string Smag_Styrke = (string)reader["SstNavn"];
                            string Smag_Type = (string)reader["StNavn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];

                            //do stuff 
                            list.Add(new Bolcher()
                            {
                                Id = Id,
                                Navn = Navn,
                                Faver = Faver,
                                Vægt_i_gram = Vægt_i_gram,
                                Smag_Surhed = Smag_Surhed,
                                Smag_Styrke = Smag_Styrke,
                                Smag_Type = Smag_Type,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                            });
                        }
                    }
                }
                connection.Close();
            }

            return list;
        }

        public List<Bolche_Omkostninger> /*Bolcher*/ GetAllBolcherWithNettoprisAndSalgspris()
        {
            List<Bolche_Omkostninger> list = new List<Bolche_Omkostninger>();
            Bolche_Omkostninger b = null;
            string queryString = " EXEC GetAllBolcherWithNettoprisAndSalgspris";


            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        //Read the data
                        while (reader.Read())
                        {
                            int Id = (int)reader["Id"];
                            string Navn = (string)reader["Navn"];
                            int Råvarepris_i_øre = (int)reader["Råvarepris_i_øre"];
                            int Vægt_i_gram = (int)reader["Vægt_i_gram"];
                            Decimal Nettopris = (Decimal)reader["Nettopris"];
                            Decimal Salgspris = (Decimal)reader["Salgspris"];
                            Decimal Salgspris_pr_100_gram = (Decimal)reader["Salgspris_pr_100_gram"];


                            //do stuff 
                            list.Add(new Bolche_Omkostninger()
                            {
                                Id = Id,
                                Navn = Navn,
                                Vægt_i_gram = Vægt_i_gram,
                                Råvarepris_i_øre = Råvarepris_i_øre,
                                Nettopris = Nettopris,
                                Salgspris = Salgspris,
                                Salgspris_pr_100_gram = Salgspris_pr_100_gram
                            });
                        }
                    }
                }
                connection.Close();
            }
            return list;
        }
    }
}
