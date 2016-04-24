<?PHP  
error_reporting(0);
include_once("connection.php");
$r='0';
if (isset($_POST['pseudo']) && isset($_POST['password']) ) {
$login=$_POST['pseudo'];
$password = md5($_POST['password']);
$result = mysql_query("select *  from user where (pseudo='$login' or email='$login') and password='$password' ");
	while ($row = mysql_fetch_assoc($result)) {
		$output=$row;
		print (json_encode($output));

	}

}
//echo $r;

?>
