using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RouletteRoll {
    private int _roll, _betAmount, _userID;
    private string _betType;

    // bet properties
    private string _parity = "odd", _colour = "black", _column, _rollHalf;


    public RouletteRoll() {
        Random rnd = new Random();
        _roll = rnd.Next(0, 36);
    }

    public int getRoll() {
        return _roll;
    }

    public string determineColour() {
        if (_roll == 0) {
            return "green";
        }
        for (int i = 0; i < RouletteDependencies.RedNumbers.Length; i++) {
            if (_roll == RouletteDependencies.RedNumbers[i])
                return "red";
        }
        return "black";
    }

    public string determineParity() {
        if (_roll == 0) {
            return null;
        }        
        if (_roll % 2 == 0) {
            return "even";
        }
        return "odd";
    }

    public string determineColumn() {
        if (_roll >= 1 && _roll <= 12) {
           return "1-12";
        } else if (_roll >= 13 && _roll <= 24) {
            return "13-24";
        } else if (_roll >= 25 && _roll <= 36) {
            return "25-36";
        }
        return null;
    }

    public string determineHalf() {
        if (_roll >= 1 && _roll <= 18) {
            return "1-18";
        } else if (_roll >= 19 && _roll <= 36) {
            return "19-36";
        }
        return null;
    }



}