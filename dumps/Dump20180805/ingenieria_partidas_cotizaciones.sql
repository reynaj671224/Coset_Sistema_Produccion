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
-- Table structure for table `partidas_cotizaciones`
--

DROP TABLE IF EXISTS `partidas_cotizaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partidas_cotizaciones` (
  `numero_partida` varchar(20) NOT NULL,
  `cantidad_partida` varchar(20) NOT NULL,
  `parte_partida` varchar(45) NOT NULL,
  `descripcion_partida` varchar(100) NOT NULL,
  `precio_partida` varchar(45) NOT NULL,
  `importe_partida` varchar(45) NOT NULL,
  `codigo_cotizacion` varchar(45) NOT NULL,
  `codigo_partida` int(10) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codigo_partida`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidas_cotizaciones`
--

LOCK TABLES `partidas_cotizaciones` WRITE;
/*!40000 ALTER TABLE `partidas_cotizaciones` DISABLE KEYS */;
INSERT INTO `partidas_cotizaciones` VALUES ('1','34','2342','23424234','78','90.48','CT10-1',20),('1','3','34345wewr','1','56','64.96','CT12',34),('1','3','34345wewr','sfsfdsdfsdfsfdsfdsfdsfdsfdsdfsdfsddf','560','649.6','CT12-1',35),('2','3','345erte','ertertertetretrer','1000','1160','CT12',36),('1','3','34345wewr','sfsfdsdfsdfsfdsfdsfdsfdsfdsdfsdfsddf','560','649.6','CT12-2',37),('2','3','345erte','ertertertetretrer','100','116','CT12-2',38),('1','1','223423ertet','Maquina Para fabricar tapas de refrescos','1546','1793.36','CT13',39),('2','1','t464456','Software para controlar la maquina','2000','2320','CT13',40),('1','1','1','FABRICACION DE MECANISMO PARA PRUEBA DE JALON EN MAGNETO KEYPER','12635','14656.6','CT14',41),('12','22','32','FABRICACION DE MECANISMO PARA PRUEBA DE JALON EN MAGNETO KEYPER2','34322','39813.52','CT15',42),('1','3','456','23','34.00','39.44','CT00028',43),('1','3','345','ewrwer','56.00','64.96','CT00029',45),('2','6','6','6','6.00','6.96','CT00028',59),('3','8','8','8','8.00','9.28','CT00028',63),('4','7','7','7','7.00','8.12','CT00028',65),('5','7','7','7','7.00','8.12','CT00028',66),('1','3','456','23','34.00','39.44','CT00028',67),('2','6','6','6','6.00','6.96','CT00028',68),('3','8','8','8','8.00','9.28','CT00028',69),('4','7','7','7','7.00','8.12','CT00028',70),('5','7','7','7','7.00','8.12','CT00028',71);
/*!40000 ALTER TABLE `partidas_cotizaciones` ENABLE KEYS */;
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
