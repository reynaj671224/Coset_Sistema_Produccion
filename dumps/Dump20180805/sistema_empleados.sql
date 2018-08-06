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
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `codigo_empleado` varchar(45) NOT NULL,
  `nombre_empleado` varchar(45) NOT NULL,
  `fecha_ingreso_empleado` varchar(45) NOT NULL,
  `puesto` varchar(45) NOT NULL,
  `costo_semana_empleado` varchar(10) NOT NULL,
  `costo_hora_empleado` varchar(10) NOT NULL,
  `tipo_empleado` varchar(20) NOT NULL,
  `nombre_usuario_empleado` varchar(45) NOT NULL,
  `clave_usuario_empleado` varchar(45) NOT NULL,
  `correo_electonico` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_empleado`),
  UNIQUE KEY `codigo_empleado_UNIQUE` (`codigo_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES ('1234','Juan Gonzales 5','2/11/2018','Ingeniero5','45674','1014.98','Administrativo','gonzalesj','r','juangomzales@coset.com'),('3242342','Javier Reyna','2/24/2018','imge','2434','54.09','Admin-Compras','reynaj','r','asdadada@yaho.com'),('34535','Ulises','2/28/2018','sadadad','435','9.67','Administrativo','Carrilou','r','sdfsdfsdf'),('34543','produccion','4/10/2018','35345','67','1.49','Produccion','test','r','wewerwre8900'),('45647','Maquinado','7/2/2018','tecnico','12.4','.28','Produccion','maq','123','etrert@tre.com'),('567','Saul Romero','2/16/2018','werwer','566','12.58','Ingenieria','romeros','r','sfdsfdsfds'),('5757','cheque Rosas','2/24/2018','sdfsfd','43535','967.44','Almacen','rosasc','r','sdfsfdsf');
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:59
