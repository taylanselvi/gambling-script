using System;
using SplashKitSDK;

public class Input {

    private static int BoardXOffset() {
        return RouletteDependencies.BoardXOffset;
    }

    private static int BoardYOffset() {
        return RouletteDependencies.BoardYOffset;
    }

        public static void run() {
        if (SplashKit.MouseClicked(MouseButton.LeftButton)) {
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 0, 3, 2 | TRIO
                RouletteBet RB = new RouletteBet(100, BetType.TRIO, new int[] { 0, 3, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 2, 3, 6, 5 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 2, 3, 6, 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 5, 6, 9, 8 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 5, 6, 9, 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 8, 9, 12, 11 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 8, 9, 12, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 11, 12, 15, 14 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 11, 12, 15, 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 14, 15, 17, 18 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 14, 15, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 17, 18, 21, 20 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 17, 18, 21, 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 20, 21, 24, 23 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 20, 21, 24, 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
               // 23, 24, 27, 26 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 23, 24, 27, 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 27, 26, 30, 29 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 27, 26, 30, 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 30, 29, 33, 32 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 30, 29, 33, 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 33, 32, 35, 36 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 33, 32, 35, 36 });
            }
            //start row 2 corner
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
	            //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                //  | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] {  });
            }

            //start
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
	            Console.WriteLine("it was 0"); //this is the basket
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 1");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 2");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 3");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 4");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 5");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 6");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 7");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 8");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 9");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 10");
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                Console.WriteLine("it was 11");
            }
        }
    }

}