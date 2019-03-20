using System;
using SplashKitSDK;

public class Roulette {

    public Roulette() {
        RouletteWindow();
    }

    public void RouletteWindow() {
        Window window = new Window("Roulette", 1280, 720);
            
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();
            Input.run(); 
            RouletteBoard RB = new RouletteBoard(window);
        }
    }

}