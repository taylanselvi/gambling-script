using System;
using SplashKitSDK;

public class Input {

    private static int BoardXOffset() {
        return RouletteDependencies.BoardXOffset;
    }

    private static int BoardYOffset() {
        return RouletteDependencies.BoardYOffset;
    }

        public static void Run() {
        if (SplashKit.MouseClicked(MouseButton.LeftButton)) {

            /* START BET AMOUNT ADJUSTMENTS */

            if (SplashKit.MouseX() >= (BoardXOffset() + 63) && SplashKit.MouseX() <= (BoardXOffset() + 158) && SplashKit.MouseY() >= (BoardYOffset() + 282) && SplashKit.MouseY() <= (BoardYOffset() + 306)) {
                // -2.50
                Load.AdjustBetAmount(false, 2.50);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 161) && SplashKit.MouseX() <= (BoardXOffset() + 255) && SplashKit.MouseY() >= (BoardYOffset() + 282) && SplashKit.MouseY() <= (BoardYOffset() + 306)) {
                // -10.00
                Load.AdjustBetAmount(false, 10.00);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 63) && SplashKit.MouseX() <= (BoardXOffset() + 158) && SplashKit.MouseY() >= (BoardYOffset() + 309) && SplashKit.MouseY() <= (BoardYOffset() + 333)) {
                // -25.00
                Load.AdjustBetAmount(false, 25.00);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 161) && SplashKit.MouseX() <= (BoardXOffset() + 255) && SplashKit.MouseY() >= (BoardYOffset() + 309) && SplashKit.MouseY() <= (BoardYOffset() + 333)) {
                // -100.00
                Load.AdjustBetAmount(false, 100.00);
                Console.WriteLine(Load.BetAmount);
            }

            if (SplashKit.MouseX() >= (BoardXOffset() + 454) && SplashKit.MouseX() <= (BoardXOffset() + 548) && SplashKit.MouseY() >= (BoardYOffset() + 282) && SplashKit.MouseY() <= (BoardYOffset() + 306)) {
                // +2.50
                Load.AdjustBetAmount(true, 2.50);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 552) && SplashKit.MouseX() <= (BoardXOffset() + 646) && SplashKit.MouseY() >= (BoardYOffset() + 282) && SplashKit.MouseY() <= (BoardYOffset() + 306)) {
                // +10.00
                Load.AdjustBetAmount(true, 10);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 454) && SplashKit.MouseX() <= (BoardXOffset() + 548) && SplashKit.MouseY() >= (BoardYOffset() + 309) && SplashKit.MouseY() <= (BoardYOffset() + 333)) {
                // +25.00
                Load.AdjustBetAmount(true, 25);
                Console.WriteLine(Load.BetAmount);
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 552) && SplashKit.MouseX() <= (BoardXOffset() + 646) && SplashKit.MouseY() >= (BoardYOffset() + 309) && SplashKit.MouseY() <= (BoardYOffset() + 333)) {
                // +100.00
                Load.AdjustBetAmount(true, 100);
                Console.WriteLine(Load.BetAmount);
            }

            /* END BET AMOUNT ADJUSTMENTS */

            /* START CORNERS AND SIX_LINE AND BASKET*/

            /* ROW 1 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 0, 3, 2 | TRIO
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.TRIO, new int[] { 0, 3, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 2, 3, 6, 5 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 2, 3, 6, 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 5, 6, 9, 8 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 5, 6, 9, 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 8, 9, 12, 11 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 8, 9, 12, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 11, 12, 15, 14 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 11, 12, 15, 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 14, 15, 17, 18 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 14, 15, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 17, 18, 21, 20 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 17, 18, 21, 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 20, 21, 24, 23 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 20, 21, 24, 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
               // 23, 24, 27, 26 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 23, 24, 27, 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 27, 26, 30, 29 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 27, 26, 30, 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 30, 29, 33, 32 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 30, 29, 33, 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 33, 32, 35, 36 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 33, 32, 35, 36 });
            }
            
            /* ROW 2 */
           
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
	            // 0, 1, 2 | TRIO
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.TRIO, new int[] { 0, 1, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 1, 2, 5, 4 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 1, 2, 5, 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 4, 5, 8, 7 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 4, 5, 8, 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 7, 8, 10, 11 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 7, 8, 10, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 10, 11, 14, 13 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 10, 11, 14, 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 13, 14, 16, 17 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 13, 14, 16, 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 16, 17, 20, 19 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 16, 17, 20, 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 19, 20, 23, 22 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 19, 20, 23, 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 22, 23, 26, 25 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 22, 23, 26, 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 25, 26, 29, 28 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 25, 26, 29, 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 28, 29, 32, 31 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 28, 29, 32, 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 31, 32, 35, 34 | CORNER
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.CORNER, new int[] { 31, 32, 35, 34 });
            }

            /* ROW 3 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
	            // 0, 1, 2, 3 | BASKET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.BASKET, new int[] { 0, 1, 2, 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 1, 2, 3, 4, 5, 6 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 1, 2, 3, 4, 5, 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 4, 5, 6, 7, 8, 9 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 4, 5, 6, 7, 8, 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 7, 8, 9, 10, 11, 12 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 7, 8, 9, 10, 11, 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 10, 11, 12, 13, 14, 15 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 10, 11, 12, 13, 14, 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 13, 14, 15, 16, 17, 18 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 13, 14, 15, 16, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 16, 17, 18, 19, 20, 21 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 16, 17, 18, 19, 20, 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 19, 20, 21, 22, 23, 24 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 19, 20, 21, 22, 23, 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 22, 23, 24, 25, 26, 27 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 22, 23, 24, 25, 26, 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 25, 26, 27, 28, 29, 30 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 25, 26, 27, 28, 29, 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 28, 29, 30, 31, 32, 33 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 28, 29, 30, 31, 32, 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 31, 32, 33, 34, 35, 36 | SIX_LINE
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SIX_LINE, new int[] { 31, 32, 33, 34, 35, 36 });
            }

            /* END CORNERS AND SIX_LINE AND BASKET
            
            
            START STRAIGHTS */

            /* ROW 1 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 10) && SplashKit.MouseX() <= (BoardXOffset() + 56) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
	            // 0 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 0 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
	            // 3 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 6 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 9 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 12 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 15 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 18 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 21 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 24 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 27 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 30 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 33 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 36 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 36 });
            }

            /* ROW 2 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
	            // 2 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 5 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 8 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 11 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 14 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 17 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 20 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 23 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 26 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 29 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 32 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 35 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 35 });
            }

            /* ROW 3 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
	            // 1 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 4 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 7 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 10 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 10 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 13 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 16 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 16 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 19 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 22 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 25 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 28 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 31 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 34 | STRAIGHT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STRAIGHT, new int[] { 34 });
            }

            /* END STRAIGHTS */

            /* START STREETS */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
	            // 1, 2, 3 | STREET
	            RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 1, 2, 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 4, 5, 6 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 4, 5, 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 7, 8, 9 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 7, 8, 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 10, 11, 12 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 10, 11, 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 13, 14, 15 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 13, 14, 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 16, 17, 18 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 16, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 19, 20, 21 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 19, 20, 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 22, 23, 24 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 22, 23, 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 25, 26, 27 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 25, 26, 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 28, 29, 30 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 28, 29, 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 31, 32, 33 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 31, 32, 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 34, 35, 36 | STREET
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.STREET, new int[] { 34, 35, 36 });
            }

            /* END STREETS */

            /* START SPLITS - HORIZONTAL*/

            /* ROW 1 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 0, 3 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 0, 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 3, 6 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 3, 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 6, 9 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 6, 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 9, 12 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 9, 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 12, 15 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 12, 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 15, 18 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 15, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 18, 21 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 18, 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 21, 24 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 21, 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 24, 27 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 24, 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 27, 30 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 27, 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 30, 33 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 30, 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 33, 36 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 33, 36 });
            }

            /* ROW 2 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 0, 2 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 0, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 2, 5 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 2, 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 5, 8 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 5, 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 8, 11 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 8, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 11, 14 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 11, 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 14, 17 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 14, 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 17, 20 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 17, 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 20, 23 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 20, 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 23, 26 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 23, 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 26, 29 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 26, 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 29, 32 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 29, 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 32, 35 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 32, 35 });
            }


            /* ROW 3 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 0, 1 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 0, 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 1, 4 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 1, 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 4, 7 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 4, 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 7, 10 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 7, 10 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 10, 13 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 10, 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 13, 16 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 13, 16 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 16, 19 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 16, 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 19, 22 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 19, 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 22, 25 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 22, 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 25, 28 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 25, 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 28, 31 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 28, 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
                // 31, 34 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 31, 34 });
            }

            /* END SPLITS - HORIZONTAL */

            /* START SPLITS - VERTICAL */

            /* ROW 1 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 3, 2 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 3, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 6, 5 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 6, 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 9, 8 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 9, 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 12, 11 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 12, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 15, 14 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 15, 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 18, 17 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 18, 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 21, 20 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 21, 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 24, 23 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 24, 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 27, 26 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 27, 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 30, 29 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 30, 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 33, 32 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 33, 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 55) && SplashKit.MouseY() <= (BoardYOffset() + 65)) {
                // 36, 35 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 36, 35 });
            }

            /* ROW 2 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 2, 1 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 2, 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 5, 4 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 5, 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 8, 7 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 8, 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 11, 10 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 11, 10 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 14, 13 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 14, 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 17, 16 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 17, 16 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 20, 19 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 20, 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 23, 22 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 23, 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 26, 25 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 26, 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 29, 28 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 29, 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 32, 31 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 32, 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 35, 34 | SPLIT
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.SPLIT, new int[] { 35, 34 });
            }

            /* END SPLITS - VERTICAL */

            /* START ROWS */
            
            if (SplashKit.MouseX() >= (BoardXOffset() + 652) && SplashKit.MouseX() <= (BoardXOffset() + 691) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 | ROW
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.ROW, new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 652) && SplashKit.MouseX() <= (BoardXOffset() + 691) && SplashKit.MouseY() >= (BoardYOffset() + 65) && SplashKit.MouseY() <= (BoardYOffset() + 111)) {
                // 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 | ROW
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.ROW, new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 652) && SplashKit.MouseX() <= (BoardXOffset() + 691) && SplashKit.MouseY() >= (BoardYOffset() + 121) && SplashKit.MouseY() <= (BoardYOffset() + 166)) {
                // 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 | ROW
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.ROW, new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 });
            }

            /* END ROWS */

            /* START COLUMNS */
            
            if (SplashKit.MouseX() >= (BoardXOffset() + 66) && SplashKit.MouseX() <= (BoardXOffset() + 252) && SplashKit.MouseY() >= (BoardYOffset() + 177) && SplashKit.MouseY() <= (BoardYOffset() + 221)) {
                // 1-12 | COLUMN
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.COLUMN, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 261) && SplashKit.MouseX() <= (BoardXOffset() + 447) && SplashKit.MouseY() >= (BoardYOffset() + 177) && SplashKit.MouseY() <= (BoardYOffset() + 221)) {
                // 13-24 | COLUMN
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.COLUMN, new int[] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 457) && SplashKit.MouseX() <= (BoardXOffset() + 642) && SplashKit.MouseY() >= (BoardYOffset() + 177) && SplashKit.MouseY() <= (BoardYOffset() + 221)) {
                // 25-36 | COLUMN
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.COLUMN, new int[] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 });
            }

            /* END COLUMNS */

            /* START BOTTOM ROW OF OUTSIDE BETS */

            if (SplashKit.MouseX() >= (BoardXOffset() + 64) && SplashKit.MouseX() <= (BoardXOffset() + 157) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // 1-18 | ROLL_HALF
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.ROLL_HALF, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 162) && SplashKit.MouseX() <= (BoardXOffset() + 255) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // EVEN | PARITY
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.PARITY, new int[] { 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 259) && SplashKit.MouseX() <= (BoardXOffset() + 353) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // RED | COLOUR
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.COLOUR, new int[] { 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 356) && SplashKit.MouseX() <= (BoardXOffset() + 450) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // BLACK | COLOUR
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.COLOUR, new int[] { 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 455) && SplashKit.MouseX() <= (BoardXOffset() + 548) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // ODD | PARITY
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.PARITY, new int[] { 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 552) && SplashKit.MouseX() <= (BoardXOffset() + 646) && SplashKit.MouseY() >= (BoardYOffset() + 229) && SplashKit.MouseY() <= (BoardYOffset() + 278)) {
                // 19-36 | ROLL_HALF
                RouletteBet RB = new RouletteBet(Load.BetAmount, BetType.ROLL_HALF, new int[] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 });
            }

            /* END BOTTOM ROW OF OUTSIDE BETS */

        }
    }

}