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

        Console.Write($"You have placed a ${betAmount} on {type.ToString()}, you need ");
        for (int x = 0; x < surrNum.Length; x++) {
            if (surrNum.Length > 1 && surrNum.Length != (x + 1)) {
                Console.Write(surrNum[x] + ", ");
            } else {
                Console.Write(surrNum[x] + " ");    
            }
        }
            
        Console.Write("to win...\n");

        Console.WriteLine($"The roll is... {_roll}.");

        handleBet(type);
    }

    private void handleBet(BetType type) {
        for (int i = 0; i < _surroundingNumbers.Length; i++) {
            if (_surroundingNumbers[i] == _roll) {
                _payOut = _betAmount * RouletteDependencies.betMultiplier(type);
                Console.WriteLine($"Congratulations, you have won ${_payOut} on your ${_betAmount} bet!");
                return;
            } else if (_surroundingNumbers[i] != _roll) {
                Console.WriteLine($"Sorry, you have lost ${_betAmount}.");
            }
        }
    }

}