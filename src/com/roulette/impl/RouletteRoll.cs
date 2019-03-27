using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RouletteRoll {
    private int _roll;
    private PastRolls _past;


    public RouletteRoll() {
        Random rnd = new Random();
        _roll = rnd.Next(0, 36);

        _past = new PastRolls(_roll);
        PastRolls.rolling = true;
        PastRolls.isRolled = true;
        PastRolls.DisplayList();
    }

    public void ChangeRolling(bool rolling) {
        PastRolls.rolling = rolling;
    }

    public int GetRoll() {
        return _roll;
    }

    public int DetermineColour() {
        for (int i = 0; i < RouletteDependencies.RedNumbers.Length; i++) {
            if (_roll == RouletteDependencies.RedNumbers[i]) {
                return 1;
            }
        }
        return 2;
    }

    public int DetermineParity() {
        if (_roll == 0) {
            return -1;
        }        
        if (_roll % 2 == 0) {
            return 1;
        }
        return 2;
    }

    public string DetermineColumn() {
        if (_roll >= 1 && _roll <= 12) {
           return "1-12";
        } else if (_roll >= 13 && _roll <= 24) {
            return "13-24";
        } else if (_roll >= 25 && _roll <= 36) {
            return "25-36";
        }
        return null;
    }

    public string DetermineHalf() {
        if (_roll >= 1 && _roll <= 18) {
            return "1-18";
        } else if (_roll >= 19 && _roll <= 36) {
            return "19-36";
        }
        return null;
    }



}