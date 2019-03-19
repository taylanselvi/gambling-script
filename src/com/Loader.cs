using System;
using SplashKitSDK;
using System.Windows.Forms.ButtonBase;
using System.Windows.Forms.IButtonControl;

public class Loader
{
    public static void Main()
    {
        Window window = new Window("Gambling", 500, 500);
            
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();

            Button button1 = new Button();
 
            button1.DialogResult = DialogResult.OK;
 
            Controls.Add(button1);


        }
    }
}
