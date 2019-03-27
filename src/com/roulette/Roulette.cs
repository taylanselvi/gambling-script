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
        PastRolls._window = window;
        RouletteBoard board = new RouletteBoard(window, _user, pr);
        PastRolls.DisplayList();
        
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();
            Input.Run(); 
            if (!PastRolls.rolling) {
                board.UpdateBalance(_user);
            }
            if (PastRolls.isRolled) {
                PastRolls.DisplayList();
            }
            SplashKit.RefreshWindow(window, 60);
        }
    }

}