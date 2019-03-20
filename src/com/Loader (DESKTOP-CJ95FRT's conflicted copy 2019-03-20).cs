using System;
using SplashKitSDK;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class Loader
{
    public static void Main()
    {
        Window window = new Window("Gambling", 500, 500);
            
        while (!window.CloseRequested) {
            SplashKit.ProcessEvents();

            // Create and initialize a Button.
            Button button1 = new Button();

            // Set the button to return a value of OK when clicked.
            button1.DialogResult = DialogResult.OK;

            // Add the button to the form.
            Controls.Add(button1);


        }
    }
}
