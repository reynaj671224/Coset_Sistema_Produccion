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
-- Table structure for table `cotizaciones_modificadas`
--

DROP TABLE IF EXISTS `cotizaciones_modificadas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cotizaciones_modificadas` (
  `codigo_cotizacion` varchar(12) NOT NULL,
  `cliente_nombre` varchar(12) DEFAULT NULL,
  `fecha_cotizacion` varchar(12) DEFAULT NULL,
  `fecha_entrega` varchar(12) DEFAULT NULL,
  `atencion_cotizacion` varchar(25) DEFAULT NULL,
  `atencion_copia` varchar(25) DEFAULT NULL,
  `orden_compra` varchar(12) DEFAULT NULL,
  `proyecto` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`codigo_cotizacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotizaciones_modificadas`
--

LOCK TABLES `cotizaciones_modificadas` WRITE;
/*!40000 ALTER TABLE `cotizaciones_modificadas` DISABLE KEYS */;
INSERT INTO `cotizaciones_modificadas` VALUES ('CT12','sdfsfd','2/9/2018','2/9/2018','sdfs','dddfg','78','PR19'),('CT12-1','Toro','2/9/2018','2/9/2018','Oscar Robles','Angel Zapata',NULL,NULL),('CT12-2','Toro','2/9/2018','2/9/2018','Oscar Robles','Angel Zapata','OC15','PR15'),('CT13','Cummings','2/11/2018','2/11/2018','Ramiro Sierra','rosario Robles','OC15','PR14-1'),('CT14','NIDEC','2/11/2018','2/11/2018','ALONSO VALENZUELA','ALONSO VALENZUELA','345354354','PR18'),('CT15','NIDEC12','2/11/2018','3/6/2018','ALONSO VALENZUELA1','ALONSO VALENZUELA1','OC15','PR9');
/*!40000 ALTER TABLE `cotizaciones_modificadas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:05:13
