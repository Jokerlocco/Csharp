<?php
// Challenge 1.06 - Counting in the sand (acepta 369)
// Counting in base 1
// PHP version

$num = readline();
while($num)
{
    for($i = 0; $i < $num; $i++)
        echo("1");
    echo("\n");
    $num = readline();
}
?>
