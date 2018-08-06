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
-- Table structure for table `contactos_cliente`
--

DROP TABLE IF EXISTS `contactos_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contactos_cliente` (
  `nombre_contacto` varchar(45) NOT NULL,
  `departamento_contacto` varchar(45) NOT NULL,
  `telefono_oficina_contacto` varchar(45) NOT NULL,
  `extencion_contacto` varchar(45) NOT NULL,
  `telefono_celular_contacto` varchar(45) NOT NULL,
  `correo_e_contacto` varchar(45) NOT NULL,
  `codigo_cliente` varchar(45) NOT NULL,
  `codigo_contacto` int(10) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`codigo_contacto`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contactos_cliente`
--

LOCK TABLES `contactos_cliente` WRITE;
/*!40000 ALTER TABLE `contactos_cliente` DISABLE KEYS */;
INSERT INTO `contactos_cliente` VALUES ('ALONSO VALENZUELA1','sdff1','sdfsdf1','sdf1','sdfs1','sdfsfsd1','C5',62),('sdfs','sdfsdf','sdf','sdfs','sdfs','sdfs','C7',65),('dddfg','dfgdg','dfgd','dfd','dfgd','df','C7',66),('test','test','test','test','test','test','C9',67);
/*!40000 ALTER TABLE `contactos_cliente` ENABLE KEYS */;
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
