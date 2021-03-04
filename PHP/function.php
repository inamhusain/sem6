<?php 
$x=10;
$y=5;
function a()
{
    global   $x,$y;
    $y = $x+$y;
}
function test()
{
    static $x=0;
    echo $x."<br>";
    $x++;
}
test();
test();
test();
a();
echo $y;
?>