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
-- Table structure for table `movimientos_autos`
--

DROP TABLE IF EXISTS `movimientos_autos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `movimientos_autos` (
  `codigo_movimiento` int(11) NOT NULL AUTO_INCREMENT,
  `salida_hora` varchar(45) NOT NULL,
  `salida_fecha` varchar(45) NOT NULL,
  `entrada_hora` varchar(45) NOT NULL,
  `entrada_fecha` varchar(45) NOT NULL,
  `auto_descripcion` varchar(45) NOT NULL,
  `nombre_visita` varchar(45) NOT NULL,
  `nombre_contacto` varchar(45) NOT NULL,
  `empleados` varchar(200) NOT NULL,
  `status` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_movimiento`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos_autos`
--

LOCK TABLES `movimientos_autos` WRITE;
/*!40000 ALTER TABLE `movimientos_autos` DISABLE KEYS */;
INSERT INTO `movimientos_autos` VALUES (15,'07:52:15 a.m.','19/05/2018','07:53:55 a.m.','19/05/2018','COROLLA','LEAR','MARTIN CHAIREZ','Juan Miguel Gonzalez Aldana:R,Alfredo Damian Arellano Valenzuela:A,Juan Alberto Frausto Rojas:A,','Entregado'),(16,'08:54:08 a.m.','19/05/2018','09:01:17 a.m.','19/05/2018','SENTRA','alfa','juan','Francisco Trevizo Rodriguez:R,Juan Alberto Frausto Rojas:A,Jose Manuel Ulises Carrillo Garcia:A,Javier Reyna:A,','Entregado'),(17,'11:38:58 a.m.','19/05/2018','11:44:13 a.m.','19/05/2018','CHEVROLET SPARK 2','VALEO JUAREZ','BRAYAN DE LA O','Juan Miguel Gonzalez Aldana:R,Alfredo Damian Arellano Valenzuela:A,','Entregado'),(18,'11:15:58 a.m.','21/05/2018','11:19:01 a.m.','21/05/2018','CHEVROLET SPARK 3','CASA DE REBECA','REBECA','Juan Alberto Frausto Rojas:R,Juan Cristino Hernandez Torres:A,','Entregado'),(19,'11:19:16 a.m.','21/05/2018','','','CHEVROLET SPARK 3','NIDEC','MAURICIO JIMENEZ','Juan Miguel Gonzalez Aldana:R,','Usando'),(20,'08:42:13 a.m.','22/05/2018','12:03:26 p.m.','22/05/2018','COROLLA','MADE CENTRO','VENTAS','Juan Miguel Gonzalez Aldana:R,Alfredo Damian Arellano Valenzuela:A,','Entregado'),(21,'09:33:51 a.m.','22/05/2018','03:27:03 p.m.','22/05/2018','CHEVROLET AVEO','CONTINENTAL CHIMENEAS','RAMON PARADA','Omar Barraza Alvarez:R,','Entregado'),(22,'02:52:38 p.m.','22/05/2018','04:07:07 p.m.','22/05/2018','SPARK 1','ZF','ALBERTO CHAVEZ','Carlos Jesus Chavez Castro:R,','Entregado'),(23,'04:03:57 p.m.','22/05/2018','04:49:34 p.m.','22/05/2018','COROLLA','SMC','JESUS HUMBERTO ZUÑIGA','Marcelo Estrada Montijo:R,','Entregado'),(24,'07:50:43 a.m.','23/05/2018','08:52:53 a.m.','23/05/2018','SPARK 1','CRITIKON','CRUZ ADAME','Juan Cristino Hernandez Torres:R,','Entregado'),(25,'08:30:44 a.m.','24/05/2018','04:16:08 p.m.','24/05/2018','COROLLA','JEMSA','VENDOR','Juan Miguel Gonzalez Aldana:R,','Entregado'),(26,'09:16:19 a.m.','24/05/2018','09:59:54 a.m.','24/05/2018','SPARK 1','CRITIKON','A ALEMAN','Juan Cristino Hernandez Torres:R,','Entregado'),(27,'10:01:35 a.m.','24/05/2018','11:44:06 a.m.','24/05/2018','SPARK 1','MOSTRADOR','BALEROD','Carlos Jesus Chavez Castro:R,','Entregado'),(28,'02:10:30 p.m.','24/05/2018','03:27:25 p.m.','24/05/2018','SPARK 1','BALEROS DE JUAREZ','MOSTRADOR','Carlos Jesus Chavez Castro:R,','Entregado'),(29,'02:33:51 p.m.','24/05/2018','07:10:41 p.m.','24/05/2018','SPARK 2','CONTINENTAL CHIMENEAS','ERNESTO FUENTES','Omar Barraza Alvarez:R,','Entregado'),(30,'03:00:30 p.m.','24/05/2018','05:54:25 p.m.','24/05/2018','SENTRA','CONTINENTAL AEROPUERTO','MANUEL GRAJEDA','Felipe Alberto Aguayo Gallegos:R,','Entregado'),(31,'10:59:34 a.m.','25/05/2018','11:53:50 a.m.','25/05/2018','SENTRA','CRITIKON','FCO RODRIGUEZ','Juan Cristino Hernandez Torres:R,','Entregado'),(32,'02:26:08 p.m.','25/05/2018','03:20:03 p.m.','25/05/2018','SPARK 1','CRITIKON','A ALEMAN','Juan Cristino Hernandez Torres:R,','Entregado'),(33,'02:35:28 p.m.','25/05/2018','02:40:17 p.m.','25/05/2018','COROLLA','EATON','CELIA CRUZ','Omar Barraza Alvarez:R,','Entregado'),(34,'02:40:36 p.m.','25/05/2018','03:50:29 p.m.','25/05/2018','SENTRA','EATON','CELIA CRUZ','Omar Barraza Alvarez:R,','Entregado'),(35,'07:42:56 a.m.','26/05/2018','09:23:11 a.m.','26/05/2018','COROLLA','CAJA','PERSONAL','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(36,'08:23:43 a.m.','26/05/2018','07:34:24 a.m.','28/05/2018','FRONTIER','LEAR','MARTIN CHAIREZ','Carlos Jesus Chavez Castro:R,','Entregado'),(37,'08:30:04 a.m.','28/05/2018','09:00:37 a.m.','05/06/2018','SENTRA','PERSONAL','PERSONAL','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(38,'02:58:59 p.m.','28/05/2018','04:23:20 p.m.','28/05/2018','COROLLA','GEMSA','MOSTRADOR','Juan Miguel Gonzalez Aldana:R,','Entregado'),(39,'03:07:02 p.m.','28/05/2018','07:33:46 a.m.','29/05/2018','SPARK 1','CONTINENTAL CHIMENEAS','ADRIAN  RUBIO','Ruben Adrian Garcia Rodriguez:R,','Entregado'),(40,'07:19:44 p.m.','28/05/2018','09:33:56 a.m.','29/05/2018','CHEVROLET AVEO','PERSONAL','PERSONAL','Juan Alberto Frausto Rojas:R,','Entregado'),(41,'09:34:22 a.m.','29/05/2018','02:11:13 p.m.','29/05/2018','COROLLA','LEAR','ISMAEL PEREZ','Juan Alberto Frausto Rojas:R,','Entregado'),(42,'09:35:50 p.m.','29/05/2018','04:55:07 p.m.','29/05/2018','CHEVROLET AVEO','LEAR','ISMAEL PEREZ','Juan Alberto Frausto Rojas:R,','Entregado'),(43,'02:16:16 p.m.','29/05/2018','05:07:28 p.m.','29/05/2018','COROLLA','CRITIKON','BARRON','Ruben Adrian Garcia Rodriguez:R,','Entregado'),(44,'04:18:50 p.m.','29/05/2018','06:07:39 p.m.','29/05/2018','SPARK 1','LEAR','MARTIN CHAIREZ','Carlos Jesus Chavez Castro:R,','Entregado'),(45,'11:15:39 a.m.','30/05/2018','11:36:39 a.m.','30/05/2018','SPARK 1','SMC','JESUS HUMBERTO ZUÑIGA','Felipe Alberto Aguayo Gallegos:R,','Entregado'),(46,'11:35:23 a.m.','30/05/2018','01:59:20 p.m.','30/05/2018','COROLLA','DOCTOR','PERSONAL','Juan Miguel Gonzalez Aldana:R,','Entregado'),(47,'12:17:05 p.m.','30/05/2018','03:14:08 p.m.','30/05/2018','SPARK 1','EATON','ANTONIO GONZALEZ','Carlos Jesus Chavez Castro:R,','Entregado'),(48,'02:46:29 p.m.','30/05/2018','07:53:48 p.m.','30/05/2018','COROLLA','LEAR','ISMAEL','Juan Alberto Frausto Rojas:R,','Entregado'),(49,'07:55:55 p.m.','30/05/2018','02:31:21 p.m.','06/06/2018','COROLLA','PERSONAL','PERSONAL','Juan Miguel Gonzalez Aldana:R,','Entregado'),(50,'09:55:41 a.m.','31/05/2018','12:16:30 p.m.','31/05/2018','SPARK 3','LEAR','ANTONIO URIBE','Ruben Adrian Garcia Rodriguez:R,','Entregado'),(51,'03:35:31 p.m.','31/05/2018','06:16:43 p.m.','31/05/2018','SPARK 1','IDESA','MOSTRADOR','Juan Alberto Frausto Rojas:R,','Entregado'),(52,'11:02:29 a.m.','01/06/2018','04:12:46 p.m.','01/06/2018','SPARK 1','IDESA','MOSTRADOR','Juan Alberto Frausto Rojas:R,','Entregado'),(53,'09:15:41 a.m.','02/06/2018','09:58:54 a.m.','02/06/2018','CHEVROLET AVEO','PERSONAL','PERSONAL','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(54,'08:18:57 a.m.','05/06/2018','08:41:41 a.m.','05/06/2018','SPARK 1','CRITIKON','A ALEMAN','Juan Cristino Hernandez Torres:R,','Entregado'),(55,'09:45:27 a.m.','05/06/2018','07:37:37 a.m.','06/06/2018','CHEVROLET AVEO','CONTINENTAL CHIMENEAS','ERNESTO FUENTES','Omar Barraza Alvarez:R,','Entregado'),(56,'09:55:12 a.m.','05/06/2018','02:35:21 p.m.','05/06/2018','SPARK 1','STRATTEC','JAIME MARTINEZ','Carlos Jesus Chavez Castro:R,','Entregado'),(57,'11:21:35 a.m.','05/06/2018','12:31:10 p.m.','05/06/2018','SENTRA','STEREN','MOSTRADOR','Juan Alberto Frausto Rojas:R,','Entregado'),(58,'11:29:12 a.m.','05/06/2018','12:34:21 p.m.','05/06/2018','SPARK 2','VALEO JUAREZ','REYNA MORENO','Marcelo Estrada Montijo:R,','Entregado'),(59,'03:10:09 p.m.','05/06/2018','06:16:17 p.m.','05/06/2018','SPARK 1','CONTINENTAL CHIMENEAS','ADRIAN  RUBIO','Entoem Pizarro Bustamante:R,','Entregado'),(60,'03:15:35 p.m.','05/06/2018','04:43:53 p.m.','05/06/2018','RANGER','CONTINENTAL AEROPUERTO','TERE GARCIA','Felipe Alberto Aguayo Gallegos:R,','Entregado'),(61,'09:00:20 a.m.','06/06/2018','03:28:06 p.m.','06/06/2018','RANGER','CASA DE REBECA','REBECA','Roberto Pedroza Serrano:R,','Entregado'),(62,'09:10:10 a.m.','06/06/2018','09:56:53 a.m.','06/06/2018','SPARK 2','COMPRAS','MOSTRADOR','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(63,'09:20:52 a.m.','06/06/2018','11:25:06 a.m.','06/06/2018','SPARK 3','CRITIKON','A ALEMAN','Juan Cristino Hernandez Torres:R,','Entregado'),(64,'10:28:10 a.m.','06/06/2018','03:26:07 p.m.','11/06/2018','SPARK 2','CONTINENTAL CHIMENEAS','ERNESTO FUENTES','Omar Barraza Alvarez:R,','Entregado'),(65,'12:00:14 p.m.','06/06/2018','03:26:54 p.m.','11/06/2018','CHEVROLET AVEO','VALEO JUAREZ','EDWIN ORONA','Marcelo Estrada Montijo:R,','Entregado'),(66,'01:05:59 p.m.','06/06/2018','02:33:17 p.m.','06/06/2018','SENTRA','OASA','MOSTADOR','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(67,'04:01:20 p.m.','11/06/2018','08:22:35 a.m.','12/06/2018','SPARK 3','LEAR','MARTIN CHAIREZ','Carlos Jesus Chavez Castro:R,','Entregado'),(68,'09:20:42 a.m.','12/06/2018','11:46:26 a.m.','12/06/2018','CHEVROLET AVEO','CRROL','SAUL','Alfredo Damian Arellano Valenzuela:R,','Entregado'),(69,'09:54:38 a.m.','12/06/2018','02:21:03 p.m.','12/06/2018','SENTRA','VALEO JUAREZ','EDWIN ORONA','Marcelo Estrada Montijo:R,','Entregado'),(70,'09:58:06 a.m.','12/06/2018','03:19:28 p.m.','12/06/2018','SPARK 2','LEAR','MARTIN CHAIREZ','Ruben Adrian Garcia Rodriguez:R,','Entregado'),(71,'10:08:22 a.m.','12/06/2018','03:49:21 p.m.','12/06/2018','SPARK 3','LEAR','ISMAEL PEREZ','Omar Barraza Alvarez:R,','Entregado'),(72,'10:34:20 a.m.','12/06/2018','01:30:05 p.m.','12/06/2018','FRONTIER','ZF','ALBERTO CHAVEZ','Carlos Jesus Chavez Castro:R,','Entregado'),(73,'02:15:18 p.m.','14/06/2018','04:35:53 p.m.','14/06/2018','SPARK 2','VALEO JUAREZ','HECTOR HERRERA','Marcelo Estrada Montijo:R,','Entregado');
/*!40000 ALTER TABLE `movimientos_autos` ENABLE KEYS */;
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
