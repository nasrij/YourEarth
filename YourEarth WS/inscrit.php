<?PHP  
error_reporting(0);
include_once("connection.php");
$r='0';
$message = "Utilisateur Existe deja";
if (isset($_POST['pseudo']) && isset($_POST['sexe']) && isset($_POST['tel']) && isset($_POST['email']) && isset($_POST['password'])  ) {
$login=$_POST['pseudo'];
$sexe = $_POST['sexe'];
$tel = $_POST['tel'];
$email = $_POST['email'];
$password = md5($_POST['password']);

$result = mysql_query("select pseudo  from user where (pseudo='$login' or email='$email') ");
	while ($row = mysql_fetch_assoc($result)) {
		$r ='1';
	}
	if($r == '0')
	{
		mysql_query("INSERT INTO `user` ( `pseudo`, `sexe`, `telephone`, `email`, `password`) VALUES ( '$login', '$sexe', '$tel', '$email', '$password'); ");
		$message = "Utilisateur Ajouter";

	}

}
echo $r;

?>
