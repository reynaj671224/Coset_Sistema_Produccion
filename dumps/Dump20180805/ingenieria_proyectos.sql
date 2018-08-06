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
-- Table structure for table `proyectos`
--

DROP TABLE IF EXISTS `proyectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proyectos` (
  `codigo_proyecto` varchar(45) NOT NULL,
  `nombre_proyecto` varchar(45) NOT NULL,
  `modelo_proyecto` varchar(45) NOT NULL,
  `serie_proyecto` varchar(45) NOT NULL,
  `codigo_cotizacion` varchar(45) NOT NULL,
  `codigo_orden_compra` varchar(45) NOT NULL,
  `fecha_inicio` varchar(45) NOT NULL,
  `fecha_entrega` varchar(45) NOT NULL,
  `codigo_cliente` varchar(45) NOT NULL,
  `nombre_cliente` varchar(45) NOT NULL,
  `ingeniero_coset_proyecto` varchar(45) NOT NULL,
  `ubicacion_dibujos` varchar(80) NOT NULL,
  `ingeniero_cliente_proyecto` varchar(45) NOT NULL,
  `sub_proyecto` varchar(2) NOT NULL,
  PRIMARY KEY (`codigo_proyecto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proyectos`
--

LOCK TABLES `proyectos` WRITE;
/*!40000 ALTER TABLE `proyectos` DISABLE KEYS */;
INSERT INTO `proyectos` VALUES ('PR00022','test','2342','234','CT00028','34234','6/24/2018','6/24/2018','C5','NIDEC1','Juan Gonzales 5','','ALONSO VALENZUELA1','0'),('PR00022-1','t','78','5','CT00029','7890','6/24/2018','6/24/2018','C5','NIDEC1','Juan Gonzales 5','','ALONSO VALENZUELA1','1'),('PR00023','test','4567','1','CT00028','1234','6/24/2018','6/24/2018','C5','NIDEC1','Juan Gonzales 5','','ALONSO VALENZUELA1','0'),('PR00024','test','','','CT00028','','7/22/2018','7/22/2018','C5','NIDEC1','Juan Gonzales 5','','ALONSO VALENZUELA1','0'),('PR18','test','34535','345354','CT14','345354354','3/21/2018','3/21/2018','C5','NIDEC1','Juan Gonzales 5','','ALONSO VALENZUELA1','0'),('PR19','prueba','8765','5','CT12','78','5/23/2018','5/23/2018','C5','NIDEC1','Saul Romero','','ALONSO VALENZUELA1','0');
/*!40000 ALTER TABLE `proyectos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:57
