using System;
using SplashKitSDK;

public class PastRolls {

    private int _roll;
    public static Window _window;
    public static bool rolling = false;
    public static bool isRolled = false;

    public PastRolls(int roll) {
        _roll = roll;
        AddToList(_roll);
    }

    public PastRolls(Window window) {
        _window = window;
    }

    public void AddToList(int roll) {
        if (RouletteDependencies.PastRolls.Count == 10) {
            RouletteDependencies.PastRolls.RemoveAt(0);
        }
        RouletteDependencies.PastRolls.Add(roll);
    }

    public void TestRun() {
        Bitmap one;

        
    }

    public static void DisplayList() {

        Bitmap one, two, three, four, five, six, seven, eight, nine, ten, BG, one_behind;
        BG = new Bitmap("PastRollsBG", "PastRollsBG.png");
        SplashKit.DrawBitmap("PastRollsBG", RouletteDependencies.BoardXOffset, RouletteDependencies.BoardYOffset - 70);

        two = new Bitmap(RouletteDependencies.PastRolls[8].ToString(), $"{RouletteDependencies.PastRolls[8]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[8].ToString(), RouletteDependencies.BoardXOffset + 154, RouletteDependencies.BoardYOffset - 60);

        three = new Bitmap(RouletteDependencies.PastRolls[7].ToString(), $"{RouletteDependencies.PastRolls[7]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[7].ToString(), RouletteDependencies.BoardXOffset + 203, RouletteDependencies.BoardYOffset - 60);

        four = new Bitmap(RouletteDependencies.PastRolls[6].ToString(), $"{RouletteDependencies.PastRolls[6]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[6].ToString(), RouletteDependencies.BoardXOffset + 252, RouletteDependencies.BoardYOffset - 60);

        five = new Bitmap(RouletteDependencies.PastRolls[5].ToString(), $"{RouletteDependencies.PastRolls[5]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[5].ToString(), RouletteDependencies.BoardXOffset + 301, RouletteDependencies.BoardYOffset - 60);

        six = new Bitmap(RouletteDependencies.PastRolls[4].ToString(), $"{RouletteDependencies.PastRolls[4]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[4].ToString(), RouletteDependencies.BoardXOffset + 350, RouletteDependencies.BoardYOffset - 60);

        seven = new Bitmap(RouletteDependencies.PastRolls[3].ToString(), $"{RouletteDependencies.PastRolls[3]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[3].ToString(), RouletteDependencies.BoardXOffset + 399, RouletteDependencies.BoardYOffset - 60);

        eight = new Bitmap(RouletteDependencies.PastRolls[2].ToString(), $"{RouletteDependencies.PastRolls[2]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[2].ToString(), RouletteDependencies.BoardXOffset + 448, RouletteDependencies.BoardYOffset - 60);

        nine = new Bitmap(RouletteDependencies.PastRolls[1].ToString(), $"{RouletteDependencies.PastRolls[1]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[1].ToString(), RouletteDependencies.BoardXOffset + 497, RouletteDependencies.BoardYOffset - 60);

        ten = new Bitmap(RouletteDependencies.PastRolls[0].ToString(), $"{RouletteDependencies.PastRolls[0]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[0].ToString(), RouletteDependencies.BoardXOffset + 546, RouletteDependencies.BoardYOffset - 60);

        SplashKit.DrawText("Past Rolls:", Color.White, "BN.ttf", 35, RouletteDependencies.BoardXOffset + 282, RouletteDependencies.BoardYOffset - 111);

        if (isRolled) {
            SplashKit.PlaySoundEffect(new SoundEffect("RouletteRoll", "RouletteRoll.mp3"));
            for (int x = 0; x < 20; x++) {
                Random rnd = new Random();
                int num = rnd.Next(0, 36);
                one_behind = new Bitmap("BehindRoller", "BehindRoller.png");
                SplashKit.DrawBitmap("BehindRoller", 137, 62);
                one = new Bitmap(num.ToString(), $"{num}.png");
                SplashKit.DrawBitmap(num.ToString(), RouletteDependencies.BoardXOffset + 105, RouletteDependencies.BoardYOffset - 60);
                _window.Refresh();
                SplashKit.Delay(100 + (20 * Convert.ToUInt32(x)));
                Console.WriteLine(100 + (20 * Convert.ToUInt32(x)));
            }
        }
        
        one_behind = new Bitmap("BehindRoller", "BehindRoller.png");
        SplashKit.DrawBitmap("BehindRoller", 137, 62);

        one = new Bitmap(RouletteDependencies.PastRolls[9].ToString(), $"{RouletteDependencies.PastRolls[9]}.png");
        SplashKit.DrawBitmap(RouletteDependencies.PastRolls[9].ToString(), RouletteDependencies.BoardXOffset + 105, RouletteDependencies.BoardYOffset - 60);

        isRolled = false;


    }

}