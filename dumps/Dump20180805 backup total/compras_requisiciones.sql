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
-- Table structure for table `requisiciones`
--

DROP TABLE IF EXISTS `requisiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requisiciones` (
  `codigo_requisicion` varchar(45) NOT NULL,
  `requisitor_requisicion` varchar(45) NOT NULL,
  `diriguido_requisicion` varchar(45) NOT NULL,
  `fecha_requisicion` varchar(45) NOT NULL,
  `proveedor_asignado` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_requisicion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requisiciones`
--

LOCK TABLES `requisiciones` WRITE;
/*!40000 ALTER TABLE `requisiciones` DISABLE KEYS */;
INSERT INTO `requisiciones` VALUES ('RQ00044','cheque Rosas','Javier Reyna','6/24/2018','Asignado'),('RQ00049','cheque Rosas','Javier Reyna','6/27/2018','Asignado'),('RQ00050','cheque Rosas','Javier Reyna','6/27/2018','Asignado'),('RQ00053','cheque Rosas','Javier Reyna','7/18/2018','Asignado'),('RQ00055','cheque Rosas','Javier Reyna','7/18/2018','Asignado'),('RQ00062','cheque Rosas','Javier Reyna','7/18/2018','Asignado'),('RQ00064','cheque Rosas','Javier Reyna','7/18/2018','Asignado'),('RQ00065','cheque Rosas','Javier Reyna','7/18/2018','Asignado'),('RQ00066','Saul Romero','Javier Reyna','7/31/2018','Asignado'),('RQ10','Juan Gonzales 5','Juan Gonzales 5','3/21/2018','Asignado'),('RQ11','Javier Reyna','Ulises','3/21/2018','No_asignado'),('RQ12','Juan Gonzales 5','Javier Reyna','3/21/2018','Asignado'),('RQ13','Javier Reyna','Ulises','3/21/2018','Asignado'),('RQ14','Juan Gonzales 5','Ulises','3/21/2018','Asignado'),('RQ15','Javier Reyna','Ulises','3/22/2018','Asignado'),('RQ16','Javier Reyna','Ulises','3/22/2018','No_asignado'),('RQ17','Javier Reyna','Ulises','3/22/2018','Asignado'),('RQ18','Ulises','Javier Reyna','4/5/2018','Asignado'),('RQ19','Saul Romero','Javier Reyna','4/6/2018','Asignado'),('RQ20','Saul Romero','Javier Reyna','4/6/2018','Asignado'),('RQ21','Saul Romero','Javier Reyna','4/11/2018','Asignado'),('RQ22','Saul Romero','Javier Reyna','4/16/2018','Asignado'),('RQ23','Saul Romero','Javier Reyna','4/18/2018','Asignado'),('RQ24','Saul Romero','Javier Reyna','4/18/2018','Asignado'),('RQ25','Ulises','Javier Reyna','4/22/2018','Asignado'),('RQ26','Saul Romero','Javier Reyna','4/22/2018','Asignado'),('RQ27','Saul Romero','Javier Reyna','4/22/2018','Asignado'),('RQ28','Saul Romero','Javier Reyna','4/26/2018','Asignado'),('RQ29','Juan Gonzales 5','Javier Reyna','4/26/2018','Asignado'),('RQ30','cheque Rosas','Javier Reyna','6/10/2018','Asignado'),('RQ31','cheque Rosas','Javier Reyna','6/10/2018','Asignado'),('RQ32','cheque Rosas','Javier Reyna','6/10/2018','Asignado'),('RQ33','cheque Rosas','Javier Reyna','6/10/2018','Asignado'),('RQ34','cheque Rosas','Javier Reyna','6/19/2018','Asignado'),('RQ35','cheque Rosas','Javier Reyna','6/20/2018','Asignado'),('RQ40','cheque Rosas','Javier Reyna','6/24/2018','Asignado'),('RQ42','cheque Rosas','Javier Reyna','6/24/2018','Asignado'),('RQ9','Javier Reyna','Juan Gonzales 5','3/21/2018','No_asignado');
/*!40000 ALTER TABLE `requisiciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:41
