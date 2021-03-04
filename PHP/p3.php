<?php 
  $no = 1;
  $no1 = 0;
  $no2 = 1;
  echo $no1." ";
  for($i=0;$i<10;$i++)
  {
    echo $no." ";
    $no = $no1 + $no2;
    $no1= $no2;
    $no2 = $no;
  }
?>