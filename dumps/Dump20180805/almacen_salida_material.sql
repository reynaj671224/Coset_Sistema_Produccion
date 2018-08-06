CREATE DATABASE  IF NOT EXISTS `almacen` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `almacen`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: almacen
-- ------------------------------------------------------
-- Server version	5.6.39-log

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
-- Table structure for table `salida_material`
--

DROP TABLE IF EXISTS `salida_material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salida_material` (
  `codigo_salida` int(11) NOT NULL AUTO_INCREMENT,
  `proyecto` varchar(45) NOT NULL,
  `fecha` varchar(45) NOT NULL,
  `codigo_material` varchar(45) NOT NULL,
  `codigo_proveedor_material` varchar(45) NOT NULL,
  `descripcion_material` varchar(80) NOT NULL,
  `nombre_empleado` varchar(45) NOT NULL,
  `cantidad_material` int(11) NOT NULL,
  `orden_compra` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_salida`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salida_material`
--

LOCK TABLES `salida_material` WRITE;
/*!40000 ALTER TABLE `salida_material` DISABLE KEYS */;
INSERT INTO `salida_material` VALUES (52,'PR18','8/1/2018','AG00004','SVC-EFL-010','CABLE ENCODER','Javier Reyna',5,'OC00114'),(53,'PR18','8/1/2018','AG00009','DDS2-330-DHGRY','DESCONECTADOR','Javier Reyna',5,'OC00114'),(58,'PR18','8/1/2018','AG00004','SVC-EFL-010','CABLE ENCODER','Saul Romero',5,'OC00114'),(59,'PR18','8/1/2018','AG00009','DDS2-330-DHGRY','DESCONECTADOR','Saul Romero',5,'OC00114');
/*!40000 ALTER TABLE `salida_material` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:54
