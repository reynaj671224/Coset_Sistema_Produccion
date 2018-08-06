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
-- Table structure for table `ordenes_compra`
--

DROP TABLE IF EXISTS `ordenes_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordenes_compra` (
  `codigo_orden_compra` varchar(45) NOT NULL,
  `provedor_compra` varchar(45) NOT NULL,
  `tipo_moneda_compra` varchar(45) NOT NULL,
  `fecha_orden` varchar(45) NOT NULL,
  `condicion_pago_compra` varchar(45) NOT NULL,
  `realizado_compra` varchar(45) NOT NULL,
  `cotizado_compra` varchar(45) NOT NULL,
  `correo_contacto_compra` varchar(45) NOT NULL,
  `cotizacion_compra` varchar(45) NOT NULL,
  `requisicion` varchar(45) NOT NULL,
  `estado_entrada` varchar(45) NOT NULL DEFAULT 'Abierta',
  `estado_salida` varchar(45) NOT NULL DEFAULT 'Abierta',
  PRIMARY KEY (`codigo_orden_compra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordenes_compra`
--

LOCK TABLES `ordenes_compra` WRITE;
/*!40000 ALTER TABLE `ordenes_compra` DISABLE KEYS */;
INSERT INTO `ordenes_compra` VALUES ('OC00053','jose blanco','Pesos','6/21/2018','Contado','Javier Reyna','Rosario','sfdfd','5678','','	Abierta','Abierta'),('OC00072','jose blanco','Pesos','6/22/2018','Contado','Javier Reyna','Rosario','sfdfd','45678','RQ1234,RQ2345,RQ3456','	Abierta','Abierta'),('OC00073','jose blanco','Pesos','6/22/2018','Contado','Javier Reyna','Javier','123@.com','456788','RQ2345,RQ3456,RQ7654,rq0000','	Abierta','Abierta'),('OC00076','jose blanco','Pesos','6/22/2018','Contado','Javier Reyna','Javier','123@.com','3453','rq456','	Abierta','Abierta'),('OC00077','jose blanco','Pesos','6/22/2018','Contado','Javier Reyna','Javier','123@.com','32234','rq2','	Abierta','Abierta'),('OC00080','jose blanco','Pesos','6/24/2018','Contado','Javier Reyna','Javier','123@.com','qwe','rq','	Abierta','Abierta'),('OC00082','jose blanco','Pesos','6/24/2018','Contado','Javier Reyna','Rosario','sfdfd','5','5','	Abierta','Abierta'),('OC00087','jose blanco','Pesos','6/27/2018','Contado','Javier Reyna','Javier','123@.com','123','RQ23','	Abierta','Abierta'),('OC00093','jose blanco','Dolares','7/1/2018','Contado','Javier Reyna','Rosario','sfdfd','1234','RQ1','	Abierta','Abierta'),('OC00095','jose blanco','Pesos','7/1/2018','Contado','Javier Reyna','Javier','123@.com','1234','RQ12','	Abierta','Abierta'),('OC00096','jose blanco','Pesos','7/4/2018','Contado','Javier Reyna','Rosario','sfdfd','1234','RQ123','	Abierta','Abierta'),('OC00109','jose blanco','Pesos','7/9/2018','Contado','Javier Reyna','Rosario','sfdfd','123','123','	Abierta','Abierta'),('OC00111','Jorge Lozano','Pesos','7/19/2018','Contado','Javier Reyna','Guadalupe','ads','1','1','Parcial','Abierta'),('OC00113','Jorge Lozano','Pesos','7/22/2018','Contado','Javier Reyna','Guadalupe','ads','123','123','Cerrada','Parcial'),('OC00114','Jorge Lozano','Pesos','7/22/2018','Credito','Javier Reyna','Guadalupe','ads','1231','123','Cerrada','Cerrada'),('OC36','jose blanco','Pesos','3/22/2018','Contado','Juan Gonzales 5','Javier','123@.com','12345','','	Abierta','Abierta'),('OC37','jose blanco','Pesos','4/16/2018','Credito','Javier Reyna','Javier','123@.com','456456465','','	Abierta','Abierta'),('OC38','jose blanco','Pesos','4/18/2018','Credito','Javier Reyna','Javier','123@.com','12345','','	Abierta','Abierta'),('OC39','jose blanco','Pesos','4/18/2018','Credito','Javier Reyna','Javier','123@.com','45678','','	Abierta','Abierta');
/*!40000 ALTER TABLE `ordenes_compra` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:05:12
