<?php 
    error_reporting(0);
?>
<form action="" method="POST">
    <input type="text" name="text" maxlength="5">
    <input type="submit" value="click">
    <?php 
    $no = 0;
    $no = $_POST['text'];
    $i=0;
    $sum=0;
    for($i=1;$i<=$no;$i++)
    {
        $sum = $sum + $i;
    }
    echo "<br>SUM of (".$no.") NO = ".$sum."<br>";
?>
</form>

