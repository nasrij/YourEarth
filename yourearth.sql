-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Dim 24 Avril 2016 à 16:05
-- Version du serveur :  10.1.9-MariaDB
-- Version de PHP :  5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `yourearth`
--

-- --------------------------------------------------------

--
-- Structure de la table `observation`
--

CREATE TABLE `observation` (
  `id` int(11) NOT NULL,
  `image` varchar(100) DEFAULT NULL,
  `description` varchar(2000) DEFAULT NULL,
  `longitude` varchar(15) DEFAULT NULL,
  `latitude` varchar(15) DEFAULT NULL,
  `date` varchar(30) DEFAULT NULL,
  `theme` varchar(20) DEFAULT NULL,
  `nom` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `observation`
--

INSERT INTO `observation` (`id`, `image`, `description`, `longitude`, `latitude`, `date`, `theme`, `nom`) VALUES
(6, 'http://i1.wp.com/listverse.com/wp-content/uploads/2007/10/image-15-tm.jpg', 'A landslide is a disaster involving elements of the ground, including rocks, trees, parts of houses, and anything else which may happen to be swept up. Landslides can be caused by an earthquake, volcanic eruptions, or general instability in the surrounding land. Mudslides or mudflows, are a special case of landslides, in which heavy rainfall causes loose soil on steep terrain to collapse and slide downwards.', '10,64', '35,81', '24/04/2016 ', 'Floods', 'Landslide '),
(7, 'http://i2.wp.com/listverse.com/wp-content/uploads/2007/10/avalanche-tm.jpg', 'An avalanche is a geophysical hazard involving a slide of a large snow or rock mass down a mountainside, caused when a buildup of material is released down a slope, it is one of the major dangers faced in the mountains in winter. As avalanches move down the slope they may entrain snow from the snowpack and grow in size. The snow may also mix with the air and form a powder cloud. An avalanche with a powder cloud is known as a powder snow avalanche. The powder cloud is a turbulent suspension of snow particles that flows as a gravity current.', '10,64', '35,81', '24/04/2016', 'Floods', 'Avalanche'),
(8, 'http://i0.wp.com/listverse.com/wp-content/uploads/2007/10/drought-tm.jpg?resize=300%2C200', 'A drought is an extended period of months or years when a region suffers a severe deficiency in its water supply. Generally, this occurs when a region receives consistently below average rainfall. It can have a substantial impact on the ecosystem and agriculture of the affected region. Although droughts can persist for several years, even a short, intense drought can cause significant damage and harm the local economy.', '10,64', '35,81', '24/04/2016 00:00:00', 'Floods', 'Drought '),
(9, 'http://i0.wp.com/listverse.com/wp-content/uploads/2007/10/drought-tm.jpg?resize=300%2C200', 'A drought is an extended period of months or years when a region suffers a severe deficiency in its water supply. Generally, this occurs when a region receives consistently below average rainfall. It can have a substantial impact on the ecosystem and agriculture of the affected region. Although droughts can persist for several years, even a short, intense drought can cause significant damage and harm the local economy.', '10,64', '35,81', '24/04/2016 00:00:00', 'Industrial accidents', ' Wildfire'),
(10, 'http://i0.wp.com/listverse.com/wp-content/uploads/2007/10/flood6-tm.jpg?resize=300%2C190', 'A flood is an overflow of an expanse of water that submerges land, a deluge. It is usually due to the volume of water within a body of water, such as a river or lake, exceeding the total capacity of the body, and as a result some of the water flows or sits outside of the normal perimeter of the body. It can also occur in rivers, when the strength of the river is so high it flows right out of the river channel , usually at corners or meanders.', '10,64', '35,81', '24/04/2016 00:00:00', 'Flood', 'Flood'),
(11, 'http://i0.wp.com/listverse.com/wp-content/uploads/2007/10/puuoo.jpg', 'A volcanic eruption is the point in which a volcano is active and releases lava and poisonous gasses in to the air. They range from daily small eruptions to extremely infrequent supervolcano eruptions (where the volcano expels at least 1,000 cubic kilometers of material.) Some eruptions form pyroclastic flows, which are high-temperature clouds of ash and steam that can travel down mountainsides at speeds exceeding that of an airliner.', '10,64', '35,81', '24/04/2016', 'Industrial accidents', 'Volcanic eruption'),
(12, 'http://i2.wp.com/listverse.com/wp-content/uploads/2007/10/grady-tornado-330314.jpg', 'Tornadoes are violent, rotating columns of air which can blow at speeds between 50 and 300 mph, and possibly higher. Tornadoes can occur one at a time, or can occur in large tornado outbreaks along squall lines or in other large areas of thunderstorm development. Waterspouts are tornadoes occurring over water in light rain conditions.2. Earthquake WikipediaExpresswayAn earthquake is the result of a sudden release of energy in the Earth’s crust that creates seismic waves. Earthquakes are recorded with a seismometer, also known as a seismograph. The magnitude of an earthquake is conventionally reported on the Richter scale, with magnitude 3 or lower earthquakes being mostly imperceptible and magnitude 7 causing serious damage over large areas. Intensity of shaking is measured on the modified Mercalli scale. At the Earth’s surface, earthquakes manifest themselves by shaking and sometimes displacement of the ground.1. Hurricane WikipediaHurricane Isabel2Hurricanes, tropical cyclones, and typhoons are different names for the same phenomenon: a cyclonic storm system that forms over the oceans. It is caused by evaporated water that comes off of the ocean and becomes a storm. The Coriolis Effect causes the storms to spin, and a hurricane is declared when this spinning mass of storms attains a wind speed greater than 74 mph. Hurricane is used for these phenomena in the Atlantic and eastern Pacific Oceans, tropical cyclone in the Indian, and typhoon in the western Pacific.This article is licensed under the . It uses material from the Wikipedia articles: and those mentioned in the body of the article itself.\r\nTechnorati Tags: disasters, nature\r\n', '10,64', '35,81', '24/04/2016', 'Tornado', 'Tornado'),
(13, NULL, 'example', '10,64', '35,81', '24/04/2016 00:00:00', 'Choisir un theme', 'example');

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `pseudo` varchar(100) NOT NULL,
  `sexe` varchar(15) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`id`, `pseudo`, `sexe`, `telephone`, `email`, `password`) VALUES
(3, 'nn', 'Homme', '6666', 'ess.nasri@yahoo.fr', '0a5b3913cbc9a9092311630e869b4442');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `observation`
--
ALTER TABLE `observation`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `observation`
--
ALTER TABLE `observation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
