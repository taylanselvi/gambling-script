using System;
using SplashKitSDK;

public class RouletteBoard {

    private Bitmap _mainBoard = new Bitmap("RouletteTable", "RouletteTable.jpg");
    private Window _window;
    private Load _user;

    public RouletteBoard(Window window, Load user, PastRolls rolls) {
        _window = window;
        _user = user;
        window.Clear(SplashKit.RGBColor(0, 129, 62));
        SplashKit.DrawBitmap(_mainBoard, XOffset(), YOffset());
        if (PastRolls.rolling)
            UpdateBalance(user);
        window.Refresh();
    }

    public void UpdateBalance(Load user) {
        int textWidth, balanceWidth;

        Bitmap BetBG = new Bitmap("BetAmountBG", "BetAmountBG.jpg");

        balanceWidth = SplashKit.TextWidth($"${user.balance()}", "BN.ttf", 24);
        SplashKit.DrawBitmap("BetAmountBG", RouletteDependencies.BoardXOffset + 259, RouletteDependencies.BoardYOffset + 354);
        SplashKit.DrawText($"${user.balance()}", Color.White, "BN.ttf", 24, RouletteDependencies.BoardXOffset + 257 + ((192-balanceWidth) / 2), RouletteDependencies.BoardYOffset + 354);

        textWidth = SplashKit.TextWidth($"${Load.BetAmount}", "BN.ttf", 24);
        SplashKit.DrawBitmap("BetAmountBG", RouletteDependencies.BoardXOffset + 259, RouletteDependencies.BoardYOffset + 300);
        SplashKit.DrawText($"${Load.BetAmount}", Color.White, "BN.ttf", 24, RouletteDependencies.BoardXOffset + 257 + ((192-textWidth) / 2), RouletteDependencies.BoardYOffset + 300);
        _window.Refresh();
    }

    private int XOffset() {
        return RouletteDependencies.BoardXOffset;
    }

    private int YOffset() {
        return RouletteDependencies.BoardYOffset;
    }

}