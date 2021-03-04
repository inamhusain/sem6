<?php 

date_default_timezone_set('Asia/kolkata');
echo date('d l M')."<br>";
$default = date_default_timezone_get();
echo date('h:i:s A')."<br>";
echo $default;
?>