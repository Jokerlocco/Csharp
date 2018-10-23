// Jorge Calzada Asenjo
// Challenge 1.12: Pyramid of marbles
// Go 1.11.1 version

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

package main

import "fmt"

func main() {
	var cases int

	fmt.Scanf("%d", &cases)

	for i := 0; i < cases; i++ {
		var height, totalPyramid int64

		fmt.Scanf("%d", &height)

		totalPyramid = (height * (height + 1) * (height + 2)) / 6

		fmt.Println(totalPyramid)
	}
}
