// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// Rust version

use std::io;

fn main() {

    let mut numStr = String::new();
    io::stdin().read_line(&mut numStr);
    let mut num : i32 = numStr.trim().parse().unwrap();

    while num != 0 {
        for i in 0..num {
            print!("1");
        }
        println!();

        numStr = String::new();
        io::stdin().read_line(&mut numStr);
        num = numStr.trim().parse().unwrap();
    }
}
