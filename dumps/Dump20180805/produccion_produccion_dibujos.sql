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
-- Table structure for table `produccion_dibujos`
--

DROP TABLE IF EXISTS `produccion_dibujos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produccion_dibujos` (
  `numero_dibujo` varchar(45) NOT NULL,
  `proceso` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL DEFAULT 'Nuevo',
  `calidad` varchar(45) NOT NULL,
  `secuencia` varchar(45) NOT NULL DEFAULT 'Produccion',
  `horas_produccion` decimal(10,3) NOT NULL DEFAULT '0.000',
  `horas_retrabajo` decimal(10,3) NOT NULL DEFAULT '0.000',
  `proyecto` varchar(45) NOT NULL,
  `empleado` varchar(45) NOT NULL,
  PRIMARY KEY (`numero_dibujo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produccion_dibujos`
--

LOCK TABLES `produccion_dibujos` WRITE;
/*!40000 ALTER TABLE `produccion_dibujos` DISABLE KEYS */;
INSERT INTO `produccion_dibujos` VALUES ('111','Maquinado','Pausado','Proceso','Produccion',0.005,0.000,'PR18','produccion'),('4456','Maquinado','Iniciado','Re-trabajo','Produccion',0.032,0.003,'PR19','Maquinado');
/*!40000 ALTER TABLE `produccion_dibujos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:56
