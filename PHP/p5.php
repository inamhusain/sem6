
    <form action="p5.php" method="POST">
     <input type="text" name="firstname" placeholder="First Name" pattern="[A-Za-z]+" title="Please Enter only Alphabets" required><br>
     <input type="text" name="lastname" placeholder="Last Name" pattern="[A-Za-z]+" title="Please Enter only Alphabets" required><br><br>
     <input type="submit" name="submit"><br><br><hr">
    </form>
    <?php if (isset($_POST['submit'])){
    echo "Your First Name is : ".$_POST['firstname'];
    echo "<br>Your Last name is : ".$_POST['lastname'];
} ?>
