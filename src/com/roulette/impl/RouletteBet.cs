using System;

public class RouletteBet {

    private double _betAmount, _payOut;
    private int[] _surroundingNumbers;
    private BetType _type;
    private int _roll;

    public RouletteBet(double betAmount, BetType type, int[] surrNum) {
        _betAmount = betAmount;
        _type = type;
        _surroundingNumbers = surrNum;

        RouletteRoll roll = new RouletteRoll();
        _roll = roll.getRoll();

        Console.WriteLine(_roll);

        handleBet(type);
    }

    private void handleBet(BetType type) {
        for (int i = 0; i < _surroundingNumbers.Length; i++) {
            if (_surroundingNumbers[i] == _roll) {
                _payOut = _betAmount + (_betAmount * RouletteDependencies.betMultiplier(type));
            }
        }
    }

}