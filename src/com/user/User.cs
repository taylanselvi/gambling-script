using System;
using SplashKitSDK;

public class User {

    private int _id;
    private string _name;
    
    public User(int id, string name) {
        _id = id;
        _name = name;

        //SplashKit.OpenDatabase("user", "user_database");
        //SplashKit.RunSql("user", "CREATE TABLE users (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, balance INTEGER);");
    }

}