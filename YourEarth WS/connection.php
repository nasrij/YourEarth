<?PHP
error_reporting(0);
$server_name = "localhost";
$user_name="root";
$password = "";

$con = mysql_connect($server_name , $user_name, $password) or die('Server Error :' .mysql_error());

$database_name = "yourearth";
mysql_select_db($database_name) or die("DB Error : Enable to select DataBase");
mysql_query("SET NAMES 'utf8'");

?>