using System;
using SplashKitSDK;

public class Loader
{

    // cd /c/Users/Taylan/Desktop/gambling-script

    public static Load MainPlayer;

    public static void Main()
    {
        MainPlayer = new Load(15, "Taylan");
        Roulette roulette = new Roulette(MainPlayer);
    }
}
