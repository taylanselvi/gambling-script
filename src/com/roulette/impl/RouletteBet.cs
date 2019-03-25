using System;
using SplashKitSDK;

public class RouletteBet {

    private double _betAmount, _payOut;
    private int[] _surroundingNumbers;
    private BetType _type;
    private int _roll;
    private RouletteRoll _rouletteRoll;
    private static Load _user = Loader.MainPlayer;

    public RouletteBet(double betAmount, BetType type, int[] surrNum) {
        _betAmount = betAmount;
        _type = type;
        _surroundingNumbers = surrNum;

        if (_user.balance() < _betAmount) {
            Console.WriteLine($"You don't have enough funds to do the ${_betAmount} bet. - {_type.ToString()}");
            return;
        }

        _rouletteRoll = new RouletteRoll();
        _roll = _rouletteRoll.getRoll();

        _user.balanceAdjust(false, _betAmount);
        Console.Write($"You have placed a ${betAmount} on {type.ToString().ToLower()}, you need ");
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
        if(type == BetType.PARITY) {
            if (_rouletteRoll.determineParity() == _surroundingNumbers[0]) {
                _payOut = (_betAmount * RouletteDependencies.betMultiplier(type));
                Console.WriteLine($"Congratulations, you have won ${_payOut} on your ${_betAmount} bet!");
                _user.balanceAdjust(true, _payOut + _betAmount);
                return;
            }
        } else if(type == BetType.COLOUR) {
            if (_rouletteRoll.determineColour() == _surroundingNumbers[0]) {
                _payOut = (_betAmount * RouletteDependencies.betMultiplier(type));
                Console.WriteLine($"Congratulations, you have won ${_payOut} on your ${_betAmount} bet!");
                _user.balanceAdjust(true, _payOut + _betAmount);
                return;
            }
        } else {
            for (int i = 0; i < _surroundingNumbers.Length; i++) {
                if (_surroundingNumbers[i] == _roll) {
                    _payOut = (_betAmount * RouletteDependencies.betMultiplier(type));
                    Console.WriteLine($"Congratulations, you have won ${_payOut} on your ${_betAmount} bet!");
                    _user.balanceAdjust(true, _payOut + _betAmount);
                    return;
                }
            }
        }
        Console.WriteLine($"Sorry, you have lost ${_betAmount}.");
    }

}