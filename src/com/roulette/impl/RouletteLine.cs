using System;
using SplashKitSDK;

public class RouletteLine {

    private int _x, _y;
    private bool _horizontal;
    private Window _window;

    public RouletteLine(int x, int y, bool horizontal, Window window) {
        _x = x;
        _y = y;
        _horizontal = horizontal;
        _window = window;
    }

    public void drawLine() {
        SplashKit.DrawLineOnWindow(_window, Color.Black, _x, _y, _x + 5, _y + 5);
    }

}   