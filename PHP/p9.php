<?php
$arr1 = array(
 array(1, 2, 3),
 array(5, 7, 3),
 array(6, 2, 5),
);
$arr2 = array(
 array(1, 2, 3),
 array(6, 5, 4),
 array(7, 8, 9),
);
$arr3 = array(
 array(0, 0, 0),
 array(0, 0, 0),
 array(0, 0, 0),
);

for($i=0; $i<3; $i++)
{
    for($j=0; $j<3; $j++)
    {
        for($k=0; $k<3; $k++)
        {
            $arr3[$i][$j] = $arr3[$i][$j] + $arr1[$i][$k] * $arr2[$k][$j];
        }
    }
}

echo "<br>Matrix Multiplication (A x B): <br>";
for($i=0; $i<3; $i++)
{
 for($j=0; $j<3; $j++)
  echo $arr3[$i][$j] . " ";
 echo "<br>";
}
?>