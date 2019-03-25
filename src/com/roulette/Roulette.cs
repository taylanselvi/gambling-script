using System;
using SplashKitSDK;

public class Roulette {

    private Load _user;

    public Roulette(Load user) {
        _user = user;
        RouletteWindow();
    }

    public void RouletteWindow() {
        Window window = new Window("Roulette", 771, 549);
        PastRolls pr = new PastRolls(window);
        RouletteBoard board = new RouletteBoard(window, _user);
        pr.displayList();
        
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();
            Input.run(); 
            board.updateBalance(_user);
            SplashKit.RefreshWindow(window, 60);
        }
    }

}