// Jorge Calzada Asenjo
// Go 1.11.1
// Challenge 1.04 - The Buffer
/*
   How many men can use wall-mounted urinals at the same time without breaking
   the rule that one must always leave a buffer between a urinal and other
   urinal.
*/

/*
   Example of entry:
   5
   1
   2
   3
   4
   5

   Output for that example:
   1
   1
   2
   2
   3
*/

package main

import (
    "bufio"
    "fmt"
    "os"
    "strconv"
    "strings"
)

func main() {

    reader := bufio.NewReader(os.Stdin)

    instanceCounterGross, _ := reader.ReadString('\n')
    instanceCounterClean, _ := strconv.Atoi(strings.TrimRight(instanceCounterGross, "\r\n"))

    for i := 0; i < instanceCounterClean; i++ {
        numberUrinalsGross, _ := reader.ReadString('\n')
        numberUrinalsClean, _ := strconv.Atoi(strings.TrimRight(numberUrinalsGross, "\r\n"))

        result := numberUrinalsClean/2 + (numberUrinalsClean % 2)

        fmt.Println(result)

    }
}
