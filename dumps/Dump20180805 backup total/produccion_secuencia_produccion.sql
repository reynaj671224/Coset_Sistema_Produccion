CREATE DATABASE  IF NOT EXISTS `produccion` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `produccion`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: produccion
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
-- Table structure for table `secuencia_produccion`
--

DROP TABLE IF EXISTS `secuencia_produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `secuencia_produccion` (
  `codigo` int(10) NOT NULL AUTO_INCREMENT,
  `numero_dibujo` varchar(45) NOT NULL,
  `empleado` varchar(45) NOT NULL,
  `inicio_proceso` varchar(45) NOT NULL,
  `final_proceso` varchar(45) NOT NULL,
  `proceso` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `calidad` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `secuencia_produccion`
--

LOCK TABLES `secuencia_produccion` WRITE;
/*!40000 ALTER TABLE `secuencia_produccion` DISABLE KEYS */;
INSERT INTO `secuencia_produccion` VALUES (1,'111','produccion','6/25/2018 7:28:37 PM','6/25/2018 7:28:56 PM','Maquinado','pausado','Proceso'),(2,'4456','produccion','7/2/2018 7:42:19 PM','7/2/2018 7:43:03 PM','Maquinado','pausado','Proceso'),(3,'4456','produccion','7/2/2018 7:54:57 PM','7/2/2018 7:55:17 PM','Maquinado','pausado','Proceso'),(4,'4456','Maquinado','7/2/2018 7:55:40 PM','7/2/2018 7:55:52 PM','Maquinado','pausado','Proceso'),(5,'4456','produccion','7/2/2018 7:56:07 PM','7/2/2018 7:56:24 PM','Maquinado','pausado','Proceso'),(6,'4456','Maquinado','7/2/2018 7:56:43 PM','7/2/2018 7:57:03 PM','Maquinado','Terminado','Proceso'),(7,'4456','produccion','7/2/2018 7:58:12 PM','7/2/2018 7:58:24 PM','Maquinado','pausado','Re-trabajo'),(8,'4456','Maquinado','7/2/2018 7:58:35 PM','','Maquinado','Iniciado','Re-trabajo');
/*!40000 ALTER TABLE `secuencia_produccion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:42
