// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// Kotlin version

fun main(args: Array<String>) {
    var num:Int = readLine()!!.toInt()
    while (num != 0) {
        for (i in 1..num) {
            print("1")
        }
        println()
        num = readLine()!!.toInt()
    }
}
