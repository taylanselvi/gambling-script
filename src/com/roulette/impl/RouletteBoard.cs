using System;
using SplashKitSDK;

public class RouletteBoard {

    private Bitmap _mainBoard = new Bitmap("RouletteTable", "RouletteTable.jpg");

    public RouletteBoard(Window window) {
        window.Clear(SplashKit.RGBColor(0, 129, 62));
        SplashKit.DrawBitmap(_mainBoard, xOffset(), yOffset());
        window.Refresh();
    }

    private int xOffset() {
        return RouletteDependencies.BoardXOffset;
    }

    private int yOffset() {
        return RouletteDependencies.BoardYOffset;
    }

}