using System;
using SplashKitSDK;
using System.Collections.Generic;

public class RouletteDependencies {

    public static readonly int[] RedNumbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
    public static readonly int BoardXOffset = 37, BoardYOffset = 127;
    public static List<int> PastRolls = new List<int>();

    public static double BetMultiplier(BetType type) {
        if (type == BetType.STRAIGHT) {
            return 35.0;
        } else if (type == BetType.SPLIT) {
            return 17.0;
        } else if (type == BetType.STREET) {
            return 11.0;
        } else if (type == BetType.SIX_LINE) {
            return 5.0;
        } else if (type == BetType.CORNER) {
            return 8.0;
        } else if (type == BetType.TRIO) {
            return 11.0;
        } else if (type == BetType.BASKET) {
            return 6.0;
        } else if (type == BetType.COLUMN) {
            return 2.0;
        } else if (type == BetType.ROW) {
            return 2.0;
        }
        return 1.0;
    }

}