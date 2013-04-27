-- MySQL dump 10.13  Distrib 5.5.9, for Win32 (x86)
--
-- Host: localhost    Database: careerdb
-- ------------------------------------------------------
-- Server version	5.5.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `careerdb`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `careerdb` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `careerdb`;

--
-- Table structure for table `details`
--

DROP TABLE IF EXISTS `details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `details` (
  `id` varchar(45) NOT NULL,
  `presentdate` varchar(45) DEFAULT 'Not Available',
  `name` varchar(45) DEFAULT 'Not Available',
  `address` varchar(45) DEFAULT 'Not Available',
  `adresscont` varchar(45) DEFAULT 'Not Available',
  `city` varchar(45) DEFAULT 'Not Available',
  `state` varchar(45) DEFAULT 'Not Available',
  `zip` varchar(45) DEFAULT 'Not Available',
  `phone` varchar(45) DEFAULT 'Not Available',
  `fax` varchar(45) DEFAULT 'Not Available',
  `website` varchar(45) DEFAULT 'Not Available',
  `emailconvention` varchar(45) DEFAULT 'Not Available',
  `datasource` varchar(45) DEFAULT 'Not Available',
  `status` varchar(45) DEFAULT 'Not Available',
  `facility` varchar(45) DEFAULT 'Not Available',
  `uniquecntctid` varchar(45) DEFAULT 'Not Available',
  `firstmame` varchar(45) DEFAULT 'Not Available',
  `lastname` varchar(45) DEFAULT 'Not Available',
  `position` varchar(45) DEFAULT 'Not Available',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `details`
--

LOCK TABLES `details` WRITE;
/*!40000 ALTER TABLE `details` DISABLE KEYS */;
INSERT INTO `details` VALUES ('41391.8302403241','2013-04-27 00:00:00','dgs','gsdgdsgs','dgdsgdsgds','','','gdsg','','dsgsd','','gdsgdsgdsg','','','','sdgsdg','','','');
/*!40000 ALTER TABLE `details` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-04-27 20:08:49
