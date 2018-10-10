// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// Go version

package main

import "fmt"

func main() {
    
    var num int

    fmt.Scan(&num)
    for num != 0 {
        for i := 0; i < num; i++ {
            fmt.Print("1")
        }
        fmt.Println()
        fmt.Scan(&num)
    }
}
