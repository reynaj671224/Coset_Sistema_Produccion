CREATE DATABASE  IF NOT EXISTS `ingenieria` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ingenieria`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: ingenieria
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
-- Table structure for table `dibujos_proyecto`
--

DROP TABLE IF EXISTS `dibujos_proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dibujos_proyecto` (
  `cantidad_dibujos` varchar(45) NOT NULL,
  `numero_dibujo` varchar(45) NOT NULL,
  `descripcion_dibujo` varchar(70) NOT NULL,
  `proceso` varchar(45) NOT NULL,
  `tiempo_estimado_horas` varchar(45) NOT NULL,
  `codigo_proyecto` varchar(45) NOT NULL,
  `codigo_dibujo` int(10) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codigo_dibujo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dibujos_proyecto`
--

LOCK TABLES `dibujos_proyecto` WRITE;
/*!40000 ALTER TABLE `dibujos_proyecto` DISABLE KEYS */;
INSERT INTO `dibujos_proyecto` VALUES ('2','111','qweqeqew','Maquinado','45','PR18',1),('3','4456','test','Maquinado','23','PR19',2),('2','3456','Placa Acero 6x88','Maquinado','80','PR18',3),('20','5678','Cadena de tiempo','Maquinado','89','PR18',4),('5','7777','test','Maquinado','67','PR18',5),('1','1','1','Maquinado','56','PR00022',6),('1','2345','wrwerwerwerwre','Maquinado','56','PR00023',7),('3','4354','fdsgsdfg','Maquinado','67','PR00023',8),('3','345','354','Maquinado','90','PR00023',10),('1','1','1','Maquinado','45','PR00023',11),('2','2','2','Maquinado','2','PR00022',12),('1','345','ertetr','Maquinado','76','PR00022-1',13);
/*!40000 ALTER TABLE `dibujos_proyecto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:43
