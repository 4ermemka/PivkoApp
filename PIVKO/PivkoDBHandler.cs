using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace PIVKO
{
    static class PivkoDBHandler
    {

        private static string lowCase = "abcdefghijklmnopqrstuvwxyz";
        private static string upCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string numbers = "0123456789";

        public static PivkoMDL db;

        #region Encryption/Decryption & Hash

        public static int get_num_low(char c) // получить номер строчной буквы в алфавите
        {
            return ((int)(c) - (int)('a'));
        }

        public static int get_num_cap(char c) // получить номер заглавной в алфавите
        {
            return ((int)(c) - (int)('A'));
        }

        public static bool is_low(char c) // является ли символ строчной буквой?
        {
            if (c >= 'a' && c <= 'z') return true;
            return false;
        }

        public static bool is_cap(char c)// является ли символ заглавной буквой?
        {
            if (c >= 'A' && c <= 'Z') return true;
            return false;
        }

        public static char get_char_low(int x) // получение строчной буквы по номеру в алфавите
        {
            return (char)(x + (int)('a'));
        }

        public static char get_char_cap(int x) // получение заглавной буквы по номеру в алфавите
        {
            return (char)(x + (int)('A'));
        }

        public static string clearNickName(string nick)
        {
            string res = nick.ToLower();
            foreach (char c in res)
                if (c < 'a' || c > 'z') res.Replace(c, '\0');
            if (res == string.Empty) res = "StandartNickname";
            return res;
        }

        public static string clearPassword(string password)
        {
            string res = password;
            foreach (char c in res)
                if (!is_low(c) && !is_cap(c)) res.Replace(c, '\0');
            return res;
        }

        public static char CodePhoneNum(char n, int move)
        {
            int temp = ((int)(n) - (int)('0') + move) % 10;
            return (char)(temp + (int)('0'));
        }

        public static string encPhone(string phone, string nick)
        {
            string temp = "";
            foreach (char c in phone)
            {
                temp += CodePhoneNum(c, nick.Length);
            }

            return temp;
        }

        public static string decPhone(string phone, string nick)
        {
            string temp = "";
            foreach (char c in phone)
            {
                int x = (int)(c) - (int)('0') - nick.Length;
                if (x < 0) x += 10;
                temp += (char)(x % 10 + (int)('0'));
            }
            return temp;
        }

        public static bool PhoneIsCorrect(string phone)
        {
            foreach (char c in phone)
                if (c < '0' || c > '9' || phone.Length < 7 || phone.Length > 11) return false;
            return true;
        }

        public static bool PasswordIsCorrect(string password)
        {
            bool l = false;
            bool u = false;
            bool n = false;

            foreach (char c in password)
            {
                if (lowCase.Contains(c.ToString())) l = true;
                else if (upCase.Contains(c.ToString())) u = true;
                else if (numbers.Contains(c.ToString())) n = true;
                else return false;
            }

            return l && u && n;
        }

        public static string vigenere(string str, string keyshort) // шифр виженера
        {
            string key = string.Empty;
            int k = 0;

            int len = str.Length;

            while (len > key.Length)
            {
                if (k < keyshort.Length && (is_low(str[key.Length]) || is_cap(str[key.Length])))
                {
                    key += keyshort[k];
                    k++;
                }
                else if (k < keyshort.Length) key += str[key.Length];
                else k = 0;
            }

            string result = "";

            for (int i = 0; i < len; i++)
            {
                int num = 0;
                if (is_low(str[i])) num = get_num_low(str[i]) + get_num_cap(key[i]);
                else if (is_cap(str[i])) num = get_num_cap(str[i]) + get_num_cap(key[i]);

                if (num > 25) num -= 26;

                if (is_low(str[i])) result += get_char_low(num);
                else if (is_cap(str[i])) result += get_char_cap(num);
                else result += str[i];
            }

            return result;
        }

        public static string devigenere(string str, string keyshort) // расшифровка виженера
        {
            string key = string.Empty;
            int k = 0;

            int len = str.Length;

            while (len > key.Length)
            {
                if (k < keyshort.Length && (is_low(str[key.Length]) || is_cap(str[key.Length])))
                {
                    key += keyshort[k];
                    k++;
                }
                else if (k < keyshort.Length) key += str[key.Length];
                else k = 0;
            }

            string result = "";

            for (int i = 0; i < len; i++)
            {
                int num = 0;
                if (is_low(str[i])) num = get_num_low(str[i]) - get_num_cap(key[i]);
                else if (is_cap(str[i])) num = get_num_cap(str[i]) - get_num_cap(key[i]);

                if (num < 0) num += 26;

                if (is_low(str[i])) result += get_char_low(num);
                else if (is_cap(str[i])) result += get_char_cap(num);
                else result += str[i];
            }

            return result;
        }

        public static string hashPassword(string password, string nickname, int id)
        {
            string hashedPassword = string.Empty;
            string word = vigenere(clearPassword(password), clearNickName(nickname));

            foreach (char c in word)
            {
                if (is_cap(c)) hashedPassword += get_char_cap(((int)(c) + nickname.Length * id) % 26);
                else hashedPassword += get_char_cap(((int)(c) + id + nickname.Length) % 26);
            }

            foreach (char c in password)
                if (numbers.Contains(c.ToString())) hashedPassword += CodePhoneNum(c, nickname.Length + id);

            return hashedPassword;
        }

        #endregion

        #region Database operations

        #region IdOperations 

        public static bool idIsInData(DataTable ds, int id, string cname)
        {
            for (int i = 0; i < ds.Rows.Count; i++)
                if (ds.Rows[i].Field<int>(cname) == id) return true;
            return false;
        }

        public static bool idIsInData(DataTable ds, int id, string cname, out int index)
        {
            for (int i = 0; i < ds.Rows.Count; i++)
                if (ds.Rows[i].Field<int>(cname) == id) 
                {
                    index = i;
                    return true; 
                }
            index = -1;
            return false;
        }

        public static int findMinId(DataTable ds, string name)
        {
            bool found = false;
            int minId = 0;
            do
            {
                minId++;
                found = false;
                for (int i = 0; i < ds.Rows.Count; i++)
                    if (ds.Rows[i].Field<int>(name) == minId) found = true;
            }
            while (found);
            return minId;
        }

        #endregion

        public static void AddNewUserDB(string login, string password, string phone, out string err)
        {
            err = string.Empty;
            DataTable ds = GetData("SELECT * FROM Users WHERE Login = \'" + login + "\'");

            if (ds.Rows.Count == 0)
            {
                ds = GetData("SELECT * FROM Users");

                int id = findMinId(ds, "ID_user");

                Users u = new Users
                {
                    ID_User = id,
                    Login = login,
                    Password = hashPassword(password, login, id),
                    Phone = encPhone(phone, login)
                };

                db.Users.Add(u);
                db.SaveChanges();
                //MessageBox.Show("Id:" + u.ID_User + "\nUser: " + u.Login + "\nPassword: " + u.Password + "\nPhone: " + u.Phone);
            }
            else err = "User already exists!";
        }

        public static void AddNewTaskDB(int id_room, int points, string taskName)
        {
            Tasks t = new Tasks();
            DataTable ds = GetData("SELECT * From Tasks");

            int id = findMinId(ds, "ID_Task");

            t.Description = taskName;
            t.ID_Room = id_room;
            t.Points = points;
            t.ID_Task = id;

            db.Tasks.Add(t);
            db.SaveChanges();
        }

        public static DataTable GetAllUsers(int id_admin)
        {
            string ask = "SELECT distinct * " +
              "From Users Where ID_User <> " + id_admin;

            return GetData(ask);
        }

        public static void DeleteRoomDB(int id_room)
        {
            var admins = (from Admin in db.Admin
                          where Admin.ID_Room == id_room
                          select Admin).ToList<Admin>();

            foreach (Admin a in admins) db.Admin.Remove(a);

            var tasks = (from Tasks in db.Tasks
                         where Tasks.ID_Room == id_room
                         select Tasks).ToList<Tasks>();

            foreach (Tasks t in tasks) PivkoDBHandler.db.Tasks.Remove(t);

            var players = (from Player in db.Player
                           where Player.ID_Room == id_room
                           select Player).ToList<Player>();

            foreach (Player p in players) db.Player.Remove(p);

            db.SaveChanges();

            MessageBox.Show("Комната успешно удалена!");
        }

        #region Player

        public static DataTable GetRoomPlayers(int user_id)
        {
            string ask = "SELECT distinct Room.ID_Room, Room.RoomName, Room.Description, Room.Begin_Data, Room.End_Data, Room.Prize " +
                "From Room,Users Where ID_Room in " +
                "(SELECT Room.ID_Room From (Player Inner Join Room On Player.ID_Room = Room.ID_Room) Where Player.ID_User = \'" + user_id + "\' AND Users.ID_User =\'" + user_id + "\');";

            return GetData(ask);
        }

        public static DataTable GetRoomPlayers(int user_id, string roomName)
        {
            string ask = "SELECT distinct Room.ID_Room, Room.RoomName, Room.Description, Room.Begin_Data, Room.End_Data, Room.Prize " +
                "From Room,Users Where RoomName Like \'%" + roomName + "%\' AND ID_Room in " +
                "(SELECT Room.ID_Room From (Player Inner Join Room On Player.ID_Room = Room.ID_Room) Where Player.ID_User = \'" + user_id + "\' AND Users.ID_User =\'" + user_id + "\');";

            return GetData(ask);
        }

        #endregion

        #region Judge

        public static DataTable GetJudgedRooms(int user_id)
        {
            string ask = "SELECT distinct Room.ID_Room, Room.RoomName, Room.Description, Room.Begin_Data, Room.End_Data, Room.Prize " +
                "From Room,Users Where ID_Room in " +
                "(SELECT Room.ID_Room From(Admin Inner Join Room On Admin.ID_Room = Room.ID_Room) Where Admin.ID_User = \'" + user_id + "\' AND Users.ID_User =\'" + user_id + "\');";

            return GetData(ask);
        }

        public static DataTable GetJudgedRooms(int user_id, string roomName)
        {
            string ask = "SELECT distinct Room.ID_Room, Room.RoomName, Room.Description, Room.Begin_Data, Room.End_Data, Room.Prize " +
                "From Room,Users Where Room.RoomName Like \'%" + roomName + "%\' AND ID_Room in " +
                "(SELECT Room.ID_Room From(Admin Inner Join Room On Admin.ID_Room = Room.ID_Room) Where Admin.ID_User = \'" + user_id + "\' AND Users.ID_User =\'" + user_id + "\');";

            return GetData(ask);
        }

        #endregion

        public static void CountPointsForTask(int id_user, int id_task, int id_room)
        {
            Player p = PivkoDBHandler.db.Player.Find(id_user, id_room);
            Tasks t = PivkoDBHandler.db.Tasks.Find(id_task, id_room);

            if (p != null && t != null)
            {
                p.Points += t.Points;
                PivkoDBHandler.db.SaveChanges();
                MessageBox.Show("Очки успешно добавлены!");
            }
            else MessageBox.Show("Ошибка! Очки не засчитаны!");
        }

        public static DataTable GetData(string sqlCommand)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PIVKO; Integrated Security=True";
            SqlConnection cardConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlCommand, cardConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }

        #endregion
    }
}
