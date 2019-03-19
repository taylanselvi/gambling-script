using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RouletteRoll {
    private int _roll, _betAmount, _userID;
    private string _betType;

    // bet properties
    private string _parity = "odd", _colour = "black", _column, _rollHalf;


    public RouletteRoll(int userID, int betAmount, string betType) {
        _userID = userID;
        _betAmount = betAmount;
        _betType = betType;

        Random rnd = new Random();
        _roll = rnd.Next(0, 36);

        determineColour();
        determineParity();
        determineColumn();
        determineHalf();
    }

    public void determineColour() {
        if (_roll == 0) {
            _colour = "green";
            return;
        }
        for (int i = 0; i < RouletteDependencies.RedNumbers.Length; i++) {
            if (_roll == RouletteDependencies.RedNumbers[i])
                _colour = "red";
        }
    }

    public void determineParity() {
        if (_roll == 0) {
            _parity = "zero";
            return;
        }        
        if (_roll % 2 == 0)
            _parity = "even";
    }

    public void determineColumn() {
        if (_roll == 0) {
            _column = "zero";
            return;
        }
        if (_roll >= 1 && _roll <= 12) {
            _column = "1-12";
        } else if (_roll >= 13 && _roll <= 24) {
            _column = "13-24";
        } else if (_roll >= 25 && _roll <= 36) {
            _column = "25-36";
        }
    }

    public void determineHalf() {
        if (_roll == 0) {
            _rollHalf = "zero";
            return;
        }
        if (_roll >= 1 && _roll <= 18) {
            _rollHalf = "1-18";
        } else if (_roll >= 19 && _roll <= 36) {
            _rollHalf = "19-36";
        }
    }

    public double betMultiplier(string type) {
        if (type.ToLower() == "straight") {
            return 35.0;
        } else if (type.ToLower() == "split") {
            return 17.0;
        } else if (type.ToLower() == "street") {
            return 11.0;
        } else if (type.ToLower() == "six_line") {
            return 5.0;
        } else if (type.ToLower() == "corner") {
            return 8.0;
        } else if (type.ToLower() == "trio") {
            return 11.0;
        } else if (type.ToLower() == "basket") {
            return 6.0;
        } else if (type.ToLower() == "column") {
            return 2.0;
        }
        return 1.0;
    }



}