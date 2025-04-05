using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dating_app
{
    internal class Chats
    {
        public int ChatID { get; set; }
        public string ChatName { get; set; }
        public bool IsFavorite { get; set; }
        string connectionString;

        public Chats(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Chats> GetChatsFromDatabase(int clientID, string sortAtribut)
        {
            List<Chats> chats = new List<Chats>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query;
                if (sortAtribut == "date")
                {
                    query = $"SELECT Client_chat.chat_id, Client_chat.favorite_status, Chat.chat_name, MIN(Chat_message.message_date) AS first_message_date " +
                        $"FROM Chat JOIN Client_chat ON Chat.chat_id = Client_Chat.chat_id " +
                        $"LEFT JOIN Chat_message ON Client_chat.client_chat_id = Chat_message.client_chat_id " +
                        $"WHERE Client_Chat.client_id = {clientID} GROUP BY Client_chat.chat_id, Client_chat.favorite_status, Chat.chat_name " +
                        $"ORDER BY first_message_date ASC;";
                }
                else
                {
                    query = $"SELECT Client_chat.chat_id, Client_chat.favorite_status, Chat.chat_name FROM Chat JOIN Client_chat " +
                        $"ON Chat.chat_id = Client_Chat.chat_id WHERE Client_Chat.client_id = {clientID} ORDER BY {sortAtribut};";
                }
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Chats chat = new Chats(connectionString)
                            {
                                ChatID = reader.GetInt32(reader.GetOrdinal("chat_id")),
                                ChatName = reader.GetString(reader.GetOrdinal("chat_name")),
                                IsFavorite = reader.GetBoolean(reader.GetOrdinal("favorite_status")),
                            };
                            chats.Add(chat);
                        }
                    }
                }
            }
            return chats;
        }
    }
}
