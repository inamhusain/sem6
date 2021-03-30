<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<center>
    <form action="" method="POST">
    <input type="text" name="name" placeholder="Student Name"> 
    <input type="text" name="s1" placeholder="Subject 1 Marks">
    <input type="text" name="s2" placeholder="Subject 2 Marks">
    <input type="text" name="s3" placeholder="Subject 3 Marks">
    <input type="text" name="s4" placeholder="Subject 4 Marks">
    <input type="text" name="s5" placeholder="Subject 5 Marks">
    <input type="submit" value="SUBMIT" name="submit">
    </form>
    <?php 
if(isset($_POST['submit']))
{
    $name=$_POST['name'];
    $s1=$_POST['s1'];
    $s2=$_POST['s2'];
    $s3=$_POST['s3'];
    $s4=$_POST['s4'];
    $s5=$_POST['s5'];
    $gt = $s1+$s2+$s3+$s4+$s5;
    $per = $gt/5;
    $grade;
    if($per>=80)
    {
        $grade = "Distinction";
    }
    else if($per>=65)
    {
        $grade = "First Class";
    }
    else if($per>=45)
    {
        $grade = "Second Class";
    }
    else if($per>=35)
    {
        $grade = "Third Class";
    }
    else
    {
        $grade = "FAIL";
    }
?>
<p>Student Name : <?php echo $name;?></p>
        <table>
            <tr>
                <th>Subject 1 &nbsp;</th>
                <th> Subject 2 &nbsp;</th>
                <th> Subject 3 &nbsp; </th>
                <th> Subject 4 &nbsp;</th>
                <th> Subject 5</th>
            </tr>
            <tr>
                <td style="text-align: center;"><?php echo $s1;?></td>
                <td style="text-align: center;"><?php echo $s2;?></td>
                <td style="text-align: center;"><?php echo $s3;?></td>
                <td style="text-align: center;"><?php echo $s4;?></td>
                <td style="text-align: center;"><?php echo $s5;?></td>
                
            </tr>
            <tr>
                <th> </th>
                <th>Grand Total</th>
                <th>Grade</th>
                <th>per (%)</th>
                <th> </th>
            </tr>
            <tr>
                <td style="text-align: center;"> </td>
                <td style="text-align: center;"><?php echo $gt;?></td>
                <td style="text-align: center;"><?php echo $grade;?></td>
                <td style="text-align: center;"><?php echo $per."%";?></td>
                <td style="text-align: center;"> </td>
            </tr>
        </table>
    <?php
}
?>
</center>
</body>
</html>

