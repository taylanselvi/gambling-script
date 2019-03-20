using System;

public class RouletteBet {

    private int _betAmount;
    private int[] _surroundingNumbers;
    private BetType _type;

    public RouletteBet(int betAmount, BetType type, int[] surrNum) {
        _betAmount = betAmount;
        _type = type;
        _surroundingNumbers = surrNum;

        for (int x = 0; x < _surroundingNumbers.Length; x++) {
            Console.WriteLine(_surroundingNumbers[x]);
        }
    }

    private void handleBetType(BetType type) {
        if (type == BetType.STRAIGHT) {
            
        } else if (type == BetType.SPLIT) {
            
        } else if (type == BetType.STREET) {
           
        } else if (type == BetType.SIX_LINE) {
            
        } else if (type == BetType.CORNER) {
            
        } else if (type == BetType.TRIO) {
           
        } else if (type == BetType.BASKET) {
            
        } else if (type == BetType.COLUMN) {
            
        }
    }

}