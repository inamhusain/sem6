
<?php 
  $no1 = 0;
  $no2 = 1;
  echo $no1." ";
  echo $no2." ";
  for($i=0;$i<10;$i++)
  {
 
    $no3 = $no1 + $no2;
    echo $no3." ";
    $no1= $no2;
    $no2 = $no3;
  }
?>
