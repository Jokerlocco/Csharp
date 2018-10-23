// Jorge Calzada Asenjo
// Challenge 471: Looking for the puncture
// Go 1.11.1 version

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

package main

import "fmt"

func main() {
    var cases uint64
    var startingAngle, puncture uint16
    var diff int16

    fmt.Scanf("%d", &cases)

    var i uint64 = 0

    for i < cases {
        fmt.Scanf("%d", &startingAngle)
        fmt.Scanf("%d", &puncture)

        diff = int16(startingAngle - puncture)

        if diff == 0 || diff == -180 || diff == 180 {
            fmt.Println("DA IGUAL")
        } else if (diff < 0 && diff > -180) || (diff > 180) {
            fmt.Println("ASCENDENTE")
        } else {
            fmt.Println("DESCENDENTE")
        }
        i++
    }
}
