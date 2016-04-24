<?PHP  
error_reporting(0);
include_once("connection.php");
if(isset($_GET['search'])){
	$search = $_GET['search'];
$result = mysql_query("select * from observation where description like '%$search%' or theme like'%$search%' or nom = '%$search%' ");

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
}

?>