namespace BlazorControlWork.Data
{
    public class ActiveLogin
    {
        static User _user = new User("Guest", "Guest", "", "", "");
        public static User User 
        { 
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                if (value == null)
                {
                    _user = new User("Guest", "Guest", "", "", "");
                }
            }
        }
    }
}
