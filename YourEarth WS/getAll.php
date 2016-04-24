<?PHP  
error_reporting(0);
include_once("connection.php");
$result = mysql_query("select * from user");

if(isset($_GET['format']) && $_GET['format'] == "json"){
	while ($row = mysql_fetch_assoc($result)) {
		$output[]=$row;
	}
	print (json_encode($output));
}else
	if(isset($_GET['format']) && $_GET['format'] == "json_wp"){
		while ($row = mysql_fetch_assoc($result)) {
			$output[]=$row;
		}
		echo "{\"item\":";
		print(json_encode($output));
		echo "}";
	}
	else
	{

}

?>