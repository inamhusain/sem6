<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=\, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="" method="POST">
        <input type="text" name="text">
        <input type="submit" value="click" name="submit">
        <?php 
            echo "<br>";
            if(isset($_POST['submit']))
            {
                $txt = $_POST['text'];
                switch($txt)
                {
                    case 1:
                        echo "Mon";
                        break;
                    case 2:
                        echo "Tue";
                        break;
                    case 3:
                        echo "Wed";
                        break;
                    case 4:
                        echo "Tues";
                        break;
                    case 5:
                        echo "Fri";
                        break;
                    case 6:
                        echo "Sat";
                        break;
                    case 7:
                        echo "Sun"; 
                        break;
                    default:
                        echo "not valid";
                }
            }
        ?>  
    </form>
</body>
</html>