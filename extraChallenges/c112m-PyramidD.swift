// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// Swift 4.2 version

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

import Foundation

let cases : Int = Int(readLine()!)!

for _ in 0..<cases {
    let height : UInt64 = UInt64(readLine()!)!

    let totalPyramid : UInt64 = (height * (height + 1) * (height + 2)) / 6

    print(totalPyramid)
}
