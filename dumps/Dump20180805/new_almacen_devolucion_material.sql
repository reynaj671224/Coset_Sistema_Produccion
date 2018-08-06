CREATE DATABASE  IF NOT EXISTS `new_almacen` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `new_almacen`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: new_almacen
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
-- Table structure for table `devolucion_material`
--

DROP TABLE IF EXISTS `devolucion_material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devolucion_material` (
  `codigo_devolucion` int(11) NOT NULL AUTO_INCREMENT,
  `proyecto` varchar(45) NOT NULL,
  `fecha` varchar(45) NOT NULL,
  `codigo_material` varchar(45) NOT NULL,
  `codigo_proveedor_material` varchar(45) NOT NULL,
  `motivo_devolucion` varchar(80) NOT NULL,
  `nombre_empleado` varchar(45) NOT NULL,
  `cantidad_material` int(11) NOT NULL,
  `descripcion_material` varchar(80) NOT NULL,
  PRIMARY KEY (`codigo_devolucion`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucion_material`
--

LOCK TABLES `devolucion_material` WRITE;
/*!40000 ALTER TABLE `devolucion_material` DISABLE KEYS */;
INSERT INTO `devolucion_material` VALUES (5,'PR1','24/04/2018','AG991','na','prueba de devolucion','Javier Reyna',1,'aluminio tuerca');
/*!40000 ALTER TABLE `devolucion_material` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:05:00
