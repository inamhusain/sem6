<?php
if($_SERVER['REQUEST_METHOD'] == 'POST')
{
    echo "You write : ".$_POST['text'];
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=\, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="<?php echo $_SERVER['PHP_SELF'];?>" method="POST">
        <input type="text" name="text">
        <input type="submit" value="click" name="submit">
    </form>
</body>
</html>