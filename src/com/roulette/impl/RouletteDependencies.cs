using System;
using SplashKitSDK;

public class RouletteDependencies {

    public static readonly int[] RedNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};
    public static readonly int[] BlackNumbers = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

    public static void handleInput() {
        if (SplashKit.MouseClicked(MouseButton.LeftButton)) {
            Console.WriteLine($"X: {SplashKit.MouseX()}   Y: {SplashKit.MouseY()}");
        }
    }

}