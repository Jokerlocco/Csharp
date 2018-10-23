// Jorge Calzada Asenjo
// Challenge 471: Looking for the puncture
// Swift 4.2 version

/*
    If you put a wheel with a puncture in water, knowing the angle at
    which we put it and where the hole is, calculate where it would be
    better to turn or if it would not matter.
*/

/*
    Example of input
    3
    90
    91
    0
    359
    0
    180


    Example of output
    ASCENDENTE
    DESCENDENTE
    DA IGUAL
*/

import Foundation

let cases : ULONG = ULONG(readLine()!)!

for _ in 1...cases {
    let startingAngle : Int = Int(readLine()!)!
    let puncture : Int = Int(readLine()!)!
    let diff : Int = Int(startingAngle - puncture)

    if (diff == 0 || diff == -180 || diff == 180) {
        print("DA IGUAL");
    } else if ((diff < 0 && diff > -180) || (diff > 180)) {
        print("ASCENDENTE");
    } else {
        print("DESCENDENTE");
    }

}
