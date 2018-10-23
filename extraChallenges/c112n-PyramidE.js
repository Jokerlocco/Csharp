// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// JavaScript version (for web browser console)

/*
    To calculate how many marbles form a pyramid with triangular base knowing
    the height of the pyramid.
*/

/*
    Example of input
    4
    1
    2
    3
    4


    Example of output
    1
    4
    10
    20
*/

var cases = prompt();

for (var i = 0; i < cases; i++) {
    height = prompt();
    totalPyramid = (height * (height + 1) * (height + 2)) / 6;
    console.log(totalPyramid);
}
