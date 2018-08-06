CREATE DATABASE  IF NOT EXISTS `compras` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `compras`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: compras
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
-- Table structure for table `partidas_oredenes_compra`
--

DROP TABLE IF EXISTS `partidas_oredenes_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partidas_oredenes_compra` (
  `codigo_partida` int(10) NOT NULL AUTO_INCREMENT,
  `codigo_orden_compra` varchar(45) NOT NULL,
  `partida_compra` varchar(45) NOT NULL,
  `material_compra` varchar(45) NOT NULL,
  `cantidad_compra` varchar(45) NOT NULL,
  `parte_compra` varchar(45) NOT NULL,
  `descripcion_compra` varchar(100) NOT NULL,
  `unidad_medida` varchar(45) NOT NULL,
  `proyecto_compra` varchar(45) NOT NULL,
  `precio_unitario` varchar(45) NOT NULL,
  `total_compra` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_partida`)
) ENGINE=InnoDB AUTO_INCREMENT=122 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidas_oredenes_compra`
--

LOCK TABLES `partidas_oredenes_compra` WRITE;
/*!40000 ALTER TABLE `partidas_oredenes_compra` DISABLE KEYS */;
INSERT INTO `partidas_oredenes_compra` VALUES (100,'OC00087','1','AG1078','3','541333','CABLE CONEXION NEBU-M8G3-2.5-LE3 60V','PIEZA','PR18','67.00','201.00'),(102,'OC00087','2','AG1002','1','N/A','ALUMINIO Ø4 X 10 X12 X12','PIEZA','PR18','98.00','98.00'),(103,'OC00087','3','AG940','3','7000-14521-0000000','CONECTOR ETHERNET M12 4 POLOS AUTOMATIONDIRECTI','PIEZA','PR18','678.00','2034.00'),(104,'OC00093','1','AG1124','3','TY6547','Computadora Industrial','EA','PR18','56.00','168.00'),(105,'OC00095','1','AG1002','5','N/A','ALUMINIO Ø4 X 10 X 10 X 10','PIEZA','PR18','89.00','445.00'),(106,'OC00096','1','AG00991','2','na','aluminio tuerca','PIEZA','PR18','789.00','1578.00'),(107,'OC00109','1','AG00004','14','SVC-EFL-010','CABLE ENCODER','PIEZA','PR18','567.00','567.00'),(109,'OC00109','2','AG00009','40','DDS2-330-DHGRY','DESCONECTADOR','PIEZA','PR00022','567.00','1701.00'),(113,'OC00111','1','AG00009','10','DDS2-330-DHGRY','DESCONECTADOR','PIEZA','PR19','908.00','908.00'),(118,'OC00113','1','AG00009','1','DDS2-330-DHGRY','DESCONECTADOR','PIEZA','PR00022','656.00','656.00'),(119,'OC00113','2','AG00004','4','SVC-EFL-010','CABLE ENCODER','PIEZA','PR19','678.00','2712.00'),(120,'OC00114','1','AG00004','10','SVC-EFL-010','CABLE ENCODER','PIEZA','PR00022','456.00','4560.00'),(121,'OC00114','2','AG00009','10','DDS2-330-DHGRY','DESCONECTADOR','PIEZA','PR00023','4654.00','46540.00');
/*!40000 ALTER TABLE `partidas_oredenes_compra` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:40
