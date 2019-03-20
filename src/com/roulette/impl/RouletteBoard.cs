using System;
using SplashKitSDK;

public class RouletteBoard {

    private Bitmap _mainBoard = new Bitmap("RouletteTable", "RouletteTable.jpg");

    public RouletteBoard(Window window) {
        window.Clear(Color.Green);
        SplashKit.DrawBitmap(_mainBoard, 10, 10);
        window.Refresh();
    }

}