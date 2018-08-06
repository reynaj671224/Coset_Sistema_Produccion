CREATE DATABASE  IF NOT EXISTS `sistema` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sistema`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: sistema
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
-- Table structure for table `control_folio`
--

DROP TABLE IF EXISTS `control_folio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `control_folio` (
  `foilio_clientes` varchar(45) NOT NULL,
  `folio_proveedores` varchar(45) NOT NULL,
  `folio_ot` varchar(45) NOT NULL,
  `folio_cotizaciones` varchar(45) NOT NULL,
  `foilio_oc` varchar(45) NOT NULL,
  `folio_proyectos` varchar(45) NOT NULL,
  `folio_materiales` varchar(45) NOT NULL,
  `control_folio` varchar(45) NOT NULL,
  `folio_procesos` varchar(45) NOT NULL,
  `folio_requisiciones` varchar(45) NOT NULL,
  PRIMARY KEY (`control_folio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `control_folio`
--

LOCK TABLES `control_folio` WRITE;
/*!40000 ALTER TABLE `control_folio` DISABLE KEYS */;
INSERT INTO `control_folio` VALUES ('C00011','P00013','OT00001','CT00030','OC00115','PR00025','AG01131','1','PC00006','RQ00067');
/*!40000 ALTER TABLE `control_folio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:44
