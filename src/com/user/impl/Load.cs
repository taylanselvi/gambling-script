using System;
using SplashKitSDK;

public class Load {

    private int _userId;
    private double _balance;
    private string _name;
    private QueryResult result;
    public static double BetAmount = 50.00;

    public Load(int id, string name) {
        _userId = id;
        _name = name;
        SplashKit.OpenDatabase("user", "user_database");
        InitialiseUser();

        PastRolls pr = new PastRolls(0);
        for (int x = 0; x < 10; x++) {
            Random rnd = new Random();
            pr.AddToList(rnd.Next(0, 36));
        }
        _balance = 1000.0;
    }

    public void InitialiseUser() {
        result = SplashKit.RunSql("user", $"SELECT * FROM users WHERE id = {_userId};");
        if (!SplashKit.HasRow(result)) {
            SplashKit.RunSql("user", $"INSERT INTO users (id, name, balance) VALUES ({_userId}, '{_name}', 0);");
            result = SplashKit.RunSql("user", $"SELECT * FROM users WHERE id = {_userId};");
        }
        _name = SplashKit.QueryColumnForString(result, 1);
        _balance = SplashKit.QueryColumnForDouble(result, 2);

        Console.WriteLine($"Welcome to Roulette, {_name}! Your current balance is ${_balance}.");

        SplashKit.FreeAllQueryResults();
    }

    public static void AdjustBetAmount(bool increase, double amount) {
        if (BetAmount + amount > 5000 && increase) {
            Console.WriteLine("Bet cannot be greater than $5000.");
            return;
        }
        if (BetAmount - amount < 0 && !increase) {
            BetAmount = 0;
            return;
        }
        if (increase) {
            BetAmount += amount;
        } else {
            BetAmount -= amount;
        }
    }

    

    public void BalanceAdjust(bool add, double amount) {
        if (add) {
            _balance += amount;
        } else {
            _balance -= amount;
            if (_balance < 0)
                _balance = 0;
        }
        SplashKit.RunSql("user", $"UPDATE users SET balance = {_balance} WHERE ID = {_userId};");
        SplashKit.FreeAllQueryResults();
    }

    public double balance() {
        return _balance;
    }

    public int user_id() {
        return _userId;
    }

    public string name() {
        return _name;
    }

}