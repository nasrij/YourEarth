<?PHP  
error_reporting(0);
include_once("connection.php");
$r='0';
$message = "Utilisateur Existe deja";
if (isset($_POST['name']) && isset($_POST['description']) && isset($_POST['theme']) && isset($_POST['date']) && isset($_POST['latitude']) && isset($_POST['longitude'])  ) {
$name=$_POST['name'];
$des = $_POST['description'];
$theme = $_POST['theme'];
$date = $_POST['date'];
$latitude = $_POST['latitude'];
$longitude = $_POST['longitude'];
//$image = $_POST['image'];
//$img = dump($image);

		mysql_query("INSERT INTO `observation`(  `description`, `longitude`, `latitude`, `date`, `theme`, `nom`) VALUES ('$des','$longitude','$latitude','$date','$theme','$name')");
		$message = "Utilisateur Ajouter";
$r='1';
	

}
echo $r;

?>
