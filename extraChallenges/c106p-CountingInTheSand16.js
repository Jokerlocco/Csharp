
// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// Javascript version (for web browsers console)

var num = prompt();
while (num!=0)
{
    var answer = "";
    for(var i=0; i<num; i++) 
        answer += "1";
    console.log(answer);
    
    num = prompt();
}
