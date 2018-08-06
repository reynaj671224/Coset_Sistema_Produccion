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
  PRIMARY KEY (`codigo_salida`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salida_material`
--

LOCK TABLES `salida_material` WRITE;
/*!40000 ALTER TABLE `salida_material` DISABLE KEYS */;
INSERT INTO `salida_material` VALUES (1,'PR77','28/05/2018','AG1085','IR2020-F02BG-A','REGULADOR DE PRECISION C/MAN','Ruben Adrian Garcia Rodriguez',3),(2,'PR77','28/05/2018','AG1086','KQ2H04-U02A','CONEXION RAPIDA DE BRONCE MACHO','Ruben Adrian Garcia Rodriguez',10),(3,'PR77','28/05/2018','AG1087','SS5Y5-10SEA-12B-C6','MANIFOLD P/SY5000','Ruben Adrian Garcia Rodriguez',1),(4,'PR77','28/05/2018','AG1088','SY5300-5U1 ','VALVULA SOLENOIDE','Ruben Adrian Garcia Rodriguez',4),(5,'PR77','28/05/2018','AG1089','AN20-C10','SILENCIADOR','Ruben Adrian Garcia Rodriguez',2),(6,'PR77','28/05/2018','AG1091','AS1201F-M5-04A','REGULADOR DE CAUDAL','Ruben Adrian Garcia Rodriguez',30),(7,'PR77','28/05/2018','AG1092','AS2201F-U01-06 ','REGULADOR DE CAUDAL 6MM-1/8','Ruben Adrian Garcia Rodriguez',10),(8,'PR77','28/05/2018','AG1093','AS1201F-U02-06 ','REGULADOR DE CAUDAL 6MM-1/4','Ruben Adrian Garcia Rodriguez',10),(9,'PR77','28/05/2018','AG1094','KQ2R04-06A','CONEXION PLASTICA REDUCCION','Ruben Adrian Garcia Rodriguez',10),(10,'PR77','28/05/2018','AG1095','SY5400-5U1','VALVULA SOLENOIDE','Ruben Adrian Garcia Rodriguez',8),(11,'PR4','29/05/2018','AG1101','RH48','RESISTENCIA PARA DOBLAR LEXAN','Arturo Estrada',1),(12,'PR1','06/06/2018','AG1066','AT-167','DISCO DE CORTE METALICO 7-14\" X 5/8\" X 4O PARA ALUMINIO','Francisco Trevizo Rodriguez',1),(13,'PR1','06/06/2018','AG1088','SY5300-5U1 ','VALVULA SOLENOIDE','Marcelo Estrada Montijo',2),(14,'PR17','06/06/2018','AG1057','LV0600V3','RUEDA NIVELADORA GRANDE M-1','Marcelo Estrada Montijo',2);
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

-- Dump completed on 2018-08-05  9:05:00
