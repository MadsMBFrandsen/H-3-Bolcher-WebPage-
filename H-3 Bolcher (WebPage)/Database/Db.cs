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
            string queryString1 =
                "select b.Navn, f.Navn,b.Vægt_i_gram,ssu.Navn,sst.Navn,st.Navn,b.Råvarepris_i_øre" +
                "from Bolche b inner join Faver f on b.FarveId = f.FarveId " +
                "inner join Smag_Surhed ssu on b.Smag_SurhedId = ssu.Smag_SurhedId" +
                "inner join Smag_Styrke sst on b.Smag_StyrkeId = sst.Smag_StyrkeId" +
                "inner join Smag_Type st on b.Smag_TypeId = st.Smag_TypeId";

            //DB connection inside a using clause to ensure the closing of connection when done.
            using (SqlConnection connection = new SqlConnection(CornectionString))
            {
                //OPEN CONNECTION
                connection.Open();

                //SqlCommand command = new SqlCommand(queryString, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;
                    //SqlCommand sqlc = new SqlCommand(queryString, connection);
                    //sqlc.ExecuteNonQuery();
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
                    ////Execute the command and send the query to the database with a data reader
                }
                //not necessary 
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
                    ////Execute the command and send the query to the database with a data reader
                }
                //not necessary 
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

                //SqlCommand command = new SqlCommand(queryString, connection);
                //command.Connection.Open();
                //command.ExecuteNonQuery();

                //Create a new SQL query command
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.CommandText = queryString;
                    //SqlCommand sqlc = new SqlCommand(queryString, connection);
                    //sqlc.ExecuteNonQuery();
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
                    ////Execute the command and send the query to the database with a data reader
                }
                //not necessary 
                connection.Close();
            }

            return list;
        }
    }
}
