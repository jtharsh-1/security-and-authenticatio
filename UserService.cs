using System;

public class UserService
{
    private readonly Database _db;

    public UserService(Database db)
    {
        _db = db;
    }

    public bool Login(string username, string password)
    {
        var user = _db.GetUserByUsername(username);
        return user != null && user.Password == password;
    }
}
