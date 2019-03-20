using System;
using SplashKitSDK;

public class Roulette {

    public Roulette() {
        RouletteWindow();
    }

    public void RouletteWindow() {
        Window window = new Window("Roulette", 1920, 1080);
            
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();
            RouletteDependencies.handleInput(); 
            RouletteBoard RB = new RouletteBoard(window);
        }
    }

}