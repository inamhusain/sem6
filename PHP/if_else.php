<?php 
$no1 = 10;
$no2 = 5;
$no3 = 90;

if($no1 > $no2 && $no1 > $no3)
{
        echo "big value = ".$no3;
}
elseif($no2>$no3)
{
    echo "big value = ".$no2;
}
else
{
    echo "big value = ".$no3;
}
?>