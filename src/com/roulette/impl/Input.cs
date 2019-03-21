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

            /* START CORNERS AND SIX_LINE AND BASKET*/

            /* ROW 1 */

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
            
            /* ROW 2 */
           
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
	            // 0, 1, 2 | TRIO
                RouletteBet RB = new RouletteBet(100, BetType.TRIO, new int[] { 0, 1, 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 1, 2, 5, 4 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 1, 2, 5, 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 4, 5, 8, 7 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 4, 5, 8, 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 7, 8, 10, 11 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 7, 8, 10, 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 10, 11, 14, 13 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 10, 11, 14, 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 13, 14, 16, 17 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 13, 14, 16, 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 16, 17, 20, 19 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 16, 17, 20, 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 19, 20, 23, 22 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 19, 20, 23, 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 22, 23, 26, 25 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 22, 23, 26, 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 25, 26, 29, 28 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 25, 26, 29, 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 28, 29, 32, 31 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 28, 29, 32, 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 111) && SplashKit.MouseY() <= (BoardYOffset() + 121)) {
                // 31, 32, 35, 34 | CORNER
                RouletteBet RB = new RouletteBet(100, BetType.CORNER, new int[] { 31, 32, 35, 34 });
            }

            /* ROW 3 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
	            // 0, 1, 2, 3 | BASKET
                RouletteBet RB = new RouletteBet(100, BetType.BASKET, new int[] { 0, 1, 2, 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 1, 2, 3, 4, 5, 6 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 1, 2, 3, 4, 5, 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 4, 5, 6, 7, 8, 9 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 4, 5, 6, 7, 8, 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 7, 8, 9, 10, 11, 12 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 7, 8, 9, 10, 11, 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 10, 11, 12, 13, 14, 15 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 10, 11, 12, 13, 14, 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 13, 14, 15, 16, 17, 18 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 13, 14, 15, 16, 17, 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 16, 17, 18, 19, 20, 21 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 16, 17, 18, 19, 20, 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 19, 20, 21, 22, 23, 24 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 19, 20, 21, 22, 23, 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 22, 23, 24, 25, 26, 27 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 22, 23, 24, 25, 26, 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 25, 26, 27, 28, 29, 30 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 25, 26, 27, 28, 29, 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 28, 29, 30, 31, 32, 33 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 28, 29, 30, 31, 32, 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 56 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 66 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 167) && SplashKit.MouseY() <= (BoardYOffset() + 177)) {
                // 31, 32, 33, 34, 35, 36 | SIX_LINE
                RouletteBet RB = new RouletteBet(100, BetType.SIX_LINE, new int[] { 31, 32, 33, 34, 35, 36 });
            }

            /* END CORNERS AND SIX_LINE AND BASKET
            
            
            START STRAIGHTS */

            /* ROW 1 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 10) && SplashKit.MouseX() <= (BoardXOffset() + 56) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 167)) {
	            // 0 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 0 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
	            // 3 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 3 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 6 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 6 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 9 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 9 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 12 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 12 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 15 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 15 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 18 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 18 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 21 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 21 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 24 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 24 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 27 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 27 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 30 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 30 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 33 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 33 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 10) && SplashKit.MouseY() <= (BoardYOffset() + 55)) {
                // 36 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 36 });
            }

            /* ROW 2 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
	            // 2 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 2 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 5 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 5 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 8 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 8 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 11 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 11 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 14 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 14 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 17 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 17 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 20 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 20 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 23 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 23 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 26 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 26 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 29 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 29 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 32 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 32 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 75) && SplashKit.MouseY() <= (BoardYOffset() + 120)) {
                // 35 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 35 });
            }

            /* ROW 3 */

            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (0)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (0)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
	            // 1 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 1 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (49)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (49)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 4 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 4 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (98)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (98)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 7 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 7 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (147)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (147)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 10 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 10 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (196)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (196)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 13 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 13 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (245)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (245)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 16 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 16 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (294)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (294)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 19 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 19 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (343)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (343)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 22 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 22 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (392)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (392)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 25 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 25 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (441)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (441)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 28 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 28 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (490)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (490)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 31 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 31 });
            }
            if (SplashKit.MouseX() >= (BoardXOffset() + 66 + (539)) && SplashKit.MouseX() <= (BoardXOffset() + 105 + (539)) && SplashKit.MouseY() >= (BoardYOffset() + 140) && SplashKit.MouseY() <= (BoardYOffset() + 185)) {
                // 34 | STRAIGHT
                RouletteBet RB = new RouletteBet(100, BetType.STRAIGHT, new int[] { 34 });
            }

            /* END STRAIGHTS */


        }
    }

}