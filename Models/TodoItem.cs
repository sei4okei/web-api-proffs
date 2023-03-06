namespace TodoAPI.Models
{
    // Описание таблиц в базе данных
    public class info_users
    {
        public int Id { get; set; }
        public int users_id_users { get; set; }
        public string phone { get; set; }
        public string birthday { get; set; }
    }

    public class users
    {
        public int Id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
