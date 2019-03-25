using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RouletteRoll {
    private int _roll;


    public RouletteRoll() {
        Random rnd = new Random();
        _roll = rnd.Next(0, 36);

        PastRolls _past = new PastRolls(_roll);
        _past.displayList();
    }

    public int getRoll() {
        return _roll;
    }

    public int determineColour() {
        if (_roll == 0) {
            return 0;
        }
        for (int i = 0; i < RouletteDependencies.RedNumbers.Length; i++) {
            if (_roll == RouletteDependencies.RedNumbers[i])
                return 1;
        }
        return 2;
    }

    public int determineParity() {
        if (_roll == 0) {
            return -1;
        }        
        if (_roll % 2 == 0) {
            return 1;
        }
        return 2;
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