// Jorge Calzada Asenjo
// Challenge 471: Looking for the puncture
// JavaScript version (for web browser console)

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

var cases = prompt();

for (var i = 0; i < cases; i++) {
    startingAngle = prompt();
    puncture = prompt();
    diff = startingAngle - puncture;

    if (diff == 0 || diff == -180 || diff == 180)
        console.log("DA IGUAL");
    else if ((diff < 0 && diff > -180) || (diff > 180))
        console.log("ASCENDENTE");
    else
        console.log("DESCENDENTE");
}
