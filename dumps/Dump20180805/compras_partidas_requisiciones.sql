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
-- Table structure for table `partidas_requisiciones`
--

DROP TABLE IF EXISTS `partidas_requisiciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partidas_requisiciones` (
  `codigo_partida` int(10) NOT NULL AUTO_INCREMENT,
  `codigo_requisicion` varchar(45) NOT NULL,
  `partida_requisicion` varchar(45) NOT NULL,
  `cantidad_requisicion` varchar(45) NOT NULL,
  `descripcion_requisicion` varchar(100) NOT NULL,
  `unidad_medida` varchar(45) NOT NULL,
  `proyecto_requisicion` varchar(45) NOT NULL,
  `proveedor_requisicion` varchar(45) NOT NULL,
  `numero_parte` varchar(45) NOT NULL,
  `orden_compra_asignada` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_partida`)
) ENGINE=InnoDB AUTO_INCREMENT=159 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidas_requisiciones`
--

LOCK TABLES `partidas_requisiciones` WRITE;
/*!40000 ALTER TABLE `partidas_requisiciones` DISABLE KEYS */;
INSERT INTO `partidas_requisiciones` VALUES (40,'RQ13','1','3','tornillo','EA','4355','jose blanco','3456','OC36'),(41,'RQ13','2','5','relleno','EA','8754','Jorge Lozano','6789','No_Asignada'),(42,'RQ14','1','3','2342432','ea','PR18','jose blanco','334234','OC36'),(43,'RQ15','1','1','tornillo','ea','PR18','casa','SA3456','No_Asignada'),(44,'RQ15','2','2','plc','ea','PR18','Jorge Lozano','YTU765','No_Asignada'),(45,'RQ15','3','4','PLASTICO','ROLLO','PR18','jose blanco','SET456','OC36'),(46,'RQ15','1','1','tornillo','ea','PR18','casa','SA3456','No_Asignada'),(47,'RQ15','2','2','plc','ea','PR18','Jorge Lozano','YTU765','No_Asignada'),(48,'RQ15','3','4','PLASTICO','ROLLO','PR18','jose blanco','SET456','OC36'),(49,'RQ15','4','5','BASE ESTERO','EA','PR18','casa','RTY45','No_Asignada'),(50,'RQ15','5','4','BATERIA','EA','PR18','jose blanco','RTY678','No_Asignada'),(51,'RQ16','1','1','1','1','PR18','','1','No_Asignada'),(52,'RQ16','2','2','2','2','PR18','','2','No_Asignada'),(53,'RQ16','3','3','3','3','PR18','','3','No_Asignada'),(54,'RQ17','1','2','234243243243','ea','PR18','casa','ert45','No_Asignada'),(55,'RQ17','2','3','333','33','PR18','casa','333','No_Asignada'),(56,'RQ17','3','4','44','44','PR18','Jorge Lozano','444','No_Asignada'),(57,'RQ17','4','5','555','55','PR18','casa','555','No_Asignada'),(58,'RQ17','5','5','555','55','PR18','jose blanco','55','No_Asignada'),(59,'RQ17','6','56','er','56','PR18','Jorge Lozano','789','No_Asignada'),(60,'RQ18','1','4','Piston Neumatico','EA','PR18','jose blanco','TYR6543','No_Asignada'),(61,'RQ18','2','3','Tornilo de hombro','EA','PR18','Jorge Lozano','AS1234','No_Asignada'),(62,'RQ18','3','2','Sensor Capacitivo','EA','PR18','casa','YUT6543','No_Asignada'),(63,'RQ19','1','2','?','EA','PR18','TEST','TGR567','No_Asignada'),(64,'RQ19','1','1','Tornilo de hombro','EA','PR18','TEST','AS1234','No_Asignada'),(65,'RQ19','2','2','sensor capacitivo','EA','PR18','TEST','GFTR543','No_Asignada'),(66,'RQ20','1','4','Tornilo de hombro','EA','PR18','casa','AS1234','No_Asignada'),(67,'RQ21','1','3','TORNILLO DE HOMBRO','EA','PR18','jose blanco','TRE5678','OC38'),(71,'RQ21','3','4','TORNILLO DE HOMBRO','EA','PR18','TEST','TRE5678','OC38'),(72,'RQ21','4','4','TORNILLO DE HOMBRO','EA','PR18','TEST','TRE5678','OC38'),(73,'RQ21','5','1','TORNILLO DE HOMBRO','EA','PR18','TEST','TRE5678','OC38'),(75,'RQ22','1','2','TORNILLO DE HOMBRO','EA','PR18','jose blanco','TRE5678','OC37'),(76,'RQ22','2','3','sensor inductivo','ea','PR18','Jorge Lozano','5678','No_Asignada'),(77,'RQ23','1','2','Piston Neumatico','EA','PR18','TEST','TYUJ78','No_Asignada'),(78,'RQ23','2','3','TORNILLO DE HOMBRO','EA','PR18','jose blanco','TRE5678','OC38'),(86,'RQ23','3','2','PLC Simmens','EA','PR18','Jorge Lozano','GHH65','No_Asignada'),(87,'RQ24','1','12','Piston Neumatico','EA','PR18','jose blanco','TYUJ78','OC39'),(88,'RQ24','2','123','Tornillo estrella','EA','PR18','jose blanco','TRE87','OC39'),(89,'RQ25','1','1','Tornillo Hombro','EA','PR18','Jorge Lozano','YTR765','No_Asignada'),(90,'RQ25','2','1','PC Industrial','EA','PR18','Jorge Lozano','PCTY657','No_Asignada'),(91,'RQ26','1','1','PLC Simmens','EA','PR18','TEST','GHH65','No_Asignada'),(92,'RQ26','2','2','Tornillo estrella','EA','PR18','jose blanco','TRE87','No_Asignada'),(93,'RQ26','3','1','Tornillo estriado','EA','PR18','TEST','TYR56','No_Asignada'),(94,'RQ27','1','200','PLC Simmens','EA','PR18','TEST','GHH65','No_Asignada'),(95,'RQ28','1','2','sensor capacitivo','EA','PR18','jose blanco','TRE342','No_Asignada'),(96,'RQ29','1','2','Boton STOP','EA','PR18','TEST','YTR567','No_Asignada'),(97,'RQ29','1','2','Pieza de Aluminio','EA','PR18','Jorge Lozano','TRF678','No_Asignada'),(98,'RQ30','1','2','Tornillo Hombro','EA','PR18','Jorge Lozano','YTR765','No_Asignada'),(99,'RQ30','1','2','Tornillo Hombro','EA','PR18','Jorge Lozano','YTR765','No_Asignada'),(100,'RQ31','1','2','Tornillo Hombro','EA','PR18','Casa','YTR765','No_Asignada'),(101,'RQ31','2','3','Tornillo Hombro','EA','PR18','Casa','YTR765','No_Asignada'),(102,'RQ31','3','4','Tornillo estriado','EA','PR18','Jorge Lozano','TYR56','No_Asignada'),(103,'RQ32','1','2','Tornillo Hombro','EA','PR18','casa','YTR765','No_Asignada'),(104,'RQ33','1','2','Tornillo Hombro','EA','PR19','Casa','YTR765','No_Asignada'),(105,'RQ34','1','5','CONECTOR M8 MACHO','PIEZA','','casa','AB-C3-M8MS','No_Asignada'),(109,'RQ35','1','4','MONITOR PARA COMPUTADORA','PIEZA','','TEST','V206HQL','No_Asignada'),(130,'RQ35','2','5','CABLE MULTICONDUCTOR 10 VIAS 22AWG','METRO','','TEST','30-CM-10X22','No_Asignada'),(135,'RQ34','2','5','BALEROTHOMSON','PIEZA','','','A162536','No_Asignada'),(136,'RQ34','3','4','CONECTOR M8 MACHO','PIEZA','','','AB-C3-M8MS','No_Asignada'),(137,'RQ34','4','1','BALEROTHOMSON','PIEZA','','','A162536','No_Asignada'),(138,'RQ35','3','2','CONECTOR M12 ETHERNET 90° AUTOMATIONDIRECTI','PIEZA','','TEST',' 7000-14581-0000000','No_Asignada'),(139,'RQ40','1','1','BALEROTHOMSON','PIEZA','','TEST','A162536','No_Asignada'),(140,'RQ42','1','1','BALEROTHOMSON','PIEZA','','TEST','A162536','No_Asignada'),(141,'RQ00044','1','1','BALEROTHOMSON','PIEZA','','TEST','A162536','No_Asignada'),(142,'RQ00049','1','1','test','ea','PR18','TEST','456','No_Asignada'),(143,'RQ00049','2','2','sfsfds','ea','PR00023','TEST','3253ttt','No_Asignada'),(144,'RQ00050','1','2','werrwrewrewrwerwrewer','rr','PR18','TEST','wrwre','No_Asignada'),(145,'RQ00050','2','2','werw','rr','PR18','TEST','erwr','No_Asignada'),(146,'RQ00050','3','1','werwerwerwerwr','we','PR18','TEST','1','No_Asignada'),(147,'RQ00053','1','3','345354345','ea','PR18','Jorge Lozano','3453','No_Asignada'),(150,'RQ00055','1','3','3','4','PR18','Jorge Lozano','3','No_Asignada'),(152,'RQ00055','2','5','6','6','PR18','Jorge Lozano','6','No_Asignada'),(153,'RQ00062','1','1','1','1','PR18','casa','1','No_Asignada'),(154,'RQ00064','1','1','1','1','PR18','Casa','1','No_Asignada'),(155,'RQ00065','1','1','1','1','PR18','Jorge Lozano','1','No_Asignada'),(156,'RQ00066','1','1','sfdsdfsfd','p','PR18','Jorge Lozano','234243','No_Asignada'),(157,'RQ00066','2','2','sdfsdfsfdsdf','af','PR19','Jorge Lozano','234','No_Asignada'),(158,'RQ00066','3','4','ertetr','tt','PR00022','Jorge Lozano','765','No_Asignada');
/*!40000 ALTER TABLE `partidas_requisiciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:55
