// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// NodeJS version

var content = '';
process.stdin.resume();
process.stdin.on('data', function(buf) { 
    var data = buf.toString().split('');
    data.forEach(function(num){
        content = '';
        for(var i=0; i<num; i++) 
            content += '1'; 
        console.log(content);  
    });
});
