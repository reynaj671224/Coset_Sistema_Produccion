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
-- Table structure for table `entrada_material`
--

DROP TABLE IF EXISTS `entrada_material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entrada_material` (
  `codigo_entrada` int(10) NOT NULL AUTO_INCREMENT,
  `orden_compra` varchar(45) NOT NULL,
  `fecha` varchar(45) NOT NULL,
  `codigo_material` varchar(45) NOT NULL,
  `cantidad_material` int(11) NOT NULL,
  `codigo_proveedor_material` varchar(45) NOT NULL,
  `nombre_empleado` varchar(45) NOT NULL,
  `descripcion_material` varchar(80) NOT NULL,
  `precio` varchar(45) NOT NULL,
  PRIMARY KEY (`codigo_entrada`)
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrada_material`
--

LOCK TABLES `entrada_material` WRITE;
/*!40000 ALTER TABLE `entrada_material` DISABLE KEYS */;
INSERT INTO `entrada_material` VALUES (20,'OC94','18/04/2018','AG365',1,'0005','Javier Reyna','BARRA CON ROSCA DE ALUMINIO LARGA','45.67'),(21,'OC94','18/04/2018','AG402',1,'9213K74','Javier Reyna','CONECTOR TIPO LLANTA','67.78'),(22,'NA','20/04/2018','AG77',6,'ALA1-420-165W','Javier Reyna','','12.33'),(23,'OC95','21/04/2018','AG991',2,'na','KEVIN GONZALEZ ESPARZA','aluminio tuerca','12.30'),(24,'OC95','21/04/2018','AG991',6,'na','Javier Reyna','aluminio tuerca','12.30'),(25,'NA','21/04/2018','AG991',1,'na','KEVIN GONZALEZ ESPARZA','','11.89'),(26,'NA','02/05/2018','AG735',1,'14017','Kevin Gonzalez Esprarza','BISAGRA PARA PERFILES','320'),(27,'NA','02/05/2018','AG1030',2,'6204 2RSJEM','Kevin Gonzalez Esprarza','BALERO DEEP GROOVE BALL','160'),(28,'NA','02/05/2018','AG1031',2,'33209','Kevin Gonzalez Esprarza','BALERO RODAMIENTO CONICO 45mm x 85mm x 32mm','800'),(29,'NA','02/05/2018','AG1029',2,'L44649 ','Kevin Gonzalez Esprarza','BALERO SET 4','260'),(30,'NA','02/05/2018','AG1028',1,'K400+','Kevin Gonzalez Esprarza','TECLADO INALAMBRICO','470'),(31,'NA','09/05/2018','AG1042',1,'IN13','Arturo Estrada','LED INDICADOR 12 MM 24 V','1.70'),(32,'NA','09/05/2018','AG1041',1,'MD-D225S-1','Kevin Gonzalez Esprarza','MODULO INTERFAZ DE ENCABEZADOS','480'),(33,'NA','11/05/2018','AG1051',15,'440N-532015','Kevin Gonzalez Esprarza','CONTACT SWITCH','1271.09'),(34,'NA','11/05/2018','AG1052',8000,'30-CE22AZ','Kevin Gonzalez Esprarza','CABLE ESTAÑADO AZUL','3.49'),(35,'NA','11/05/2018','AG1053',1000,'30-CE22N','Kevin Gonzalez Esprarza','CABLE ESTAÑADO NEGRO','3.49'),(36,'NA','11/05/2018','AG1054',150,'AB-C3-M8MS','Kevin Gonzalez Esprarza','CONECTOR M8 MACHO','167.49'),(37,'NA','11/05/2018','AG1043',8,'LV0050V1','Kevin Gonzalez Esprarza','RUEDA NIVELADORA M-1','1370'),(38,'NA','16/05/2018','AG1036',1,'G1540098','Kevin Gonzalez Esprarza','CABLE ENCODER BLANCO','5400'),(39,'NA','16/05/2018','AG1057',4,'LV0600V3','Kevin Gonzalez Esprarza','RUEDA NIVELADORA GRANDE M-1','553.50'),(40,'NA','18/05/2018','AG1059',3,'FU-67TG','Kevin Gonzalez Esprarza','UNIDAD DE FIBRA REFLECTIVA FORMA HEXAGONAL ACORAZADO','1519.00'),(41,'NA','18/05/2018','AG1060',3,'FS-N11P','Kevin Gonzalez Esprarza','AMP FIBRA OPTICA ENERGIA  NEO-MEGA','2622.00'),(42,'NA','21/05/2018','AG1061',400,'30-CM-10X22','Kevin Gonzalez Esprarza','CABLE MULTICONDUCTOR 10 VIAS 22AWG','48.80'),(43,'NA','22/05/2018','AG1063',5000,'LAT-40-799-5','Kevin Gonzalez Esprarza','ETIQUETAS LASERTAB','0'),(44,'NA','22/05/2018','AG1064',1,'NA','Kevin Gonzalez Esprarza','FILTRO AQUABOON 10\" BIG BLUE PLEATED SEDIMENT 5 MICRON 10\" X 4.5\"','0'),(45,'NA','23/05/2018','AG1037',18,'V206HQL','Kevin Gonzalez Esprarza','MONITOR PARA COMPUTADORA','0'),(46,'NA','24/05/2018','AG1066',2,'AT-167','Kevin Gonzalez Esprarza','DISCO DE CORTE METALICO 7-14\" X 5/8\" X 4O PARA ALUMINIO','250'),(47,'NA','24/05/2018','AG1065',2,'DW-03110','Kevin Gonzalez Esprarza','DISCO 8-14\" 40 PARA PLASTICO Y MADERA','250'),(48,'NA','25/05/2018','AG1067',1,'FBA_ML10B','Kevin Gonzalez Esprarza','FLAT PANEL SWING ARM MOUNT','1139.00'),(49,'NA','25/05/2018','AG1071',1,'KT120','Kevin Gonzalez Esprarza','KEYBOARD AND MOUSE SET','276.00 '),(50,'NA','25/05/2018','AG1072',16,'GD-40F','Arturo Estrada','LLANTA PARA CARRITO','180.00'),(51,'NA','25/05/2018','AG1073',12,'DS4308-DL00007PZWW','Kevin Gonzalez Esprarza','SCANNER ZEBRA ','6840'),(52,'NA','25/05/2018','AG1082',3,'41111930','Kevin Gonzalez Esprarza','SENSOR MAGNETICO PARA CILINDRO ','7595.00'),(53,'NA','25/05/2018','AG1079',4,'18941','Kevin Gonzalez Esprarza','SENSOR MAGNETIC SMH-S1-HGPP16-,05','1475'),(54,'NA','25/05/2018','AG1080',4,'544216','Kevin Gonzalez Esprarza','CONVERTIDOR DE SEÑALES SVE4-HS-R-HM8-2P-M8','1634.88'),(55,'NA','25/05/2018','AG1081',2,'18940','Kevin Gonzalez Esprarza','SENSOR MAGNETIC SHM-S1-HGPP12-0,5','1475.00'),(56,'NA','25/05/2018','AG1076',2,'197895','Kevin Gonzalez Esprarza','MINI-CARRO SLT-16-30-A-CC-B','9103.20'),(57,'NA','25/05/2018','AG1077',4,'551367','Kevin Gonzalez Esprarza','DET. PROX. SME-10M-DS-24V-E-0,3-L-y','413.90'),(58,'NA','25/05/2018','AG1078',4,'541333','Kevin Gonzalez Esprarza','CABLE CONEXION NEBU-M8G3-2.5-LE3 60V','89.29'),(59,'NA','28/05/2018','AG1085',3,'IR2020-F02BG-A','Kevin Gonzalez Esprarza','REGULADOR DE PRECISION C/MAN','933.00'),(60,'NA','28/05/2018','AG1086',10,'KQ2H04-U02A','Kevin Gonzalez Esprarza','CONEXION RAPIDA DE BRONCE MACHO','20.00'),(61,'NA','28/05/2018','AG1087',1,'SS5Y5-10SEA-12B-C6','Kevin Gonzalez Esprarza','MANIFOLD P/SY5000','6101.00'),(62,'NA','28/05/2018','AG1088',4,'SY5300-5U1 ','Kevin Gonzalez Esprarza','VALVULA SOLENIODE','949.00'),(63,'NA','28/05/2018','AG1089',2,'AN20-C10','Kevin Gonzalez Esprarza','SILENCIADOR','65.00'),(64,'NA','28/05/2018','AG1090',1,'KQ2P-10','Kevin Gonzalez Esprarza','CONEXION TAPON PLASTICO','12.00'),(65,'NA','28/05/2018','AG1091',30,'AS1201F-M5-04A','Kevin Gonzalez Esprarza','REGULADOR DE CAUDAL','73.00'),(66,'NA','28/05/2018','AG1092',10,'AS2201F-U01-06 ','Kevin Gonzalez Esprarza','REGULADOR DE CAUDAL 6MM-1/8','98.00'),(67,'NA','28/05/2018','AG1093',10,'AS1201F-U02-06 ','Kevin Gonzalez Esprarza','REGULADOR DE CAUDAL 6MM-1/4','110.00'),(68,'NA','28/05/2018','AG1094',10,'KQ2R04-06A','Kevin Gonzalez Esprarza','CONEXION PLASTICA REDUCCION','25'),(69,'NA','28/05/2018','AG1095',8,'SY5400-5U1','Kevin Gonzalez Esprarza','VALVULA SOLENOIDE','949.00'),(70,'NA','29/05/2018','AG1100',5,'PSE05-115','Kevin Gonzalez Esprarza','POWER SUPPLY, 5VDC, 15W, ENCAPSULATED','0'),(71,'NA','29/05/2018','AG1072',8,'GD-40F','Kevin Gonzalez Esprarza','LLANTA PARA CARRITO','0'),(72,'NA','29/05/2018','AG1067',1,'FBA_ML10B','Kevin Gonzalez Esprarza','FLAT PANEL SWING ARM MOUNT','0'),(73,'NA','29/05/2018','AG1101',3,'RH48','Kevin Gonzalez Esparza','RESISTENCIA PARA DOBLAR LEXAN','875.00'),(74,'NA','30/05/2018','AG1103',2,'240816','Kevin Gonzalez Esparza','MXH6-10Z MESA DESLIZANTE COMPACTA NEUMATICA 6X10','1790.00'),(75,'NA','30/05/2018','AG1102',2,'213212','Kevin Gonzalez Esparza','CDQSB12-30DCM CIL NEUMATICO COMPACTO 12X30','242.00'),(76,'NA','30/05/2018','AG1078',100,'541333','Kevin Gonzalez Esparza','CABLE CONEXION NEBU-M8G3-2.5-LE3 60V','89.29'),(77,'NA','30/05/2018','AG1104',1,'32686','Kevin Gonzalez Esparza','CILINDRO DOBLE DPZ-16-10-P-A','7273.30'),(78,'NA','31/05/2018','AG1106',2,'183831','Kevin Gonzalez Esparza','MY1M32-250H MESA DESLIZANTE DE 250MM DE CARRERA','6961.00'),(79,'NA','31/05/2018','AG1107',4,'164281','Kevin Gonzalez Esparza','CDQ2B32-20DZ CIL NEUMATICO COMPACTO 32X20','683.00'),(80,'NA','31/05/2018','AG1108',4,'104715','Kevin Gonzalez Esparza','CKZT40-90T CIL NEUM POWER CLAMP DIAM','8891.00'),(81,'NA','31/05/2018','AG1109',2,'231211','Kevin Gonzalez Esparza','ISA3-HCP-2 SENSOR DE PRESION','4500.00'),(82,'NA','31/05/2018','AG1110',4,'008737','Kevin Gonzalez Esparza','CQ2B25-5D CIL NEUMATICO COMPACTO 25X5','342.00'),(83,'NA','31/05/2018','AG1111',4,'003437','Kevin Gonzalez Esparza','TAPON ALLEN 1/8 PT','16.00'),(84,'NA','31/05/2018','AG1115',1,'541344','Kevin Gonzalez Esparza','CABLE CONEXION NEBU-M8W4-K-2,5-LE4','188.07'),(85,'NA','31/05/2018','AG1112',1,'1376664','Kevin Gonzalez Esparza','CIL. NORMALIZ. DSBC-40-250-PPVA-N3','1596.30'),(86,'NA','31/05/2018','AG1113',2,'574335','Kevin Gonzalez Esparza','DET. PROX. SMT-8M-A-PS-24-E-2,5-OE','290.41'),(87,'NA','31/05/2018','AG1114',1,'540191','Kevin Gonzalez Esparza','TRANS. POSICION SMAT-8E-S50-IU-M8','4657.34'),(88,'NA','01/06/2018','AG1116',5,'85-VGA-120','Kevin Gonzalez Esparza','EXTENSION VGA MACHO HEMBRA 1.80 MTS PREMIUM','139.00'),(89,'NA','01/06/2018','AG1117',5,'100-9700200','Kevin Gonzalez Esparza','BARRA DE MULTICONTACTO 6 TOMAS','89.00'),(90,'NA','01/06/2018','AG1072',12,'GD-40F','Kevin Gonzalez Esparza','LLANTA PARA CARRITO','45.00'),(91,'NA','01/06/2018','AG1042',300,'IN13','Kevin Gonzalez Esparza','LED INDICADOR AZUL 12 MM 24 V','1.70'),(92,'NA','01/06/2018','AG1118',150,'IN13','Kevin Gonzalez Esparza','LED INDICADOR VERDE 12MM 24V','1.70'),(93,'NA','01/06/2018','AG1119',50,'PNK6-AP-4A','Kevin Gonzalez Esparza','INDUCTIVE PROXIMITY SENSOR','375.00'),(94,'NA','05/06/2018','AG1120',100,'26121604','Kevin Gonzalez Esparza','CONECTOR M8 MACHO PIN RECTO PARA CONDUCTO','172.25'),(95,'OC107','06/06/2018','AG1074',1,'N/A','Roberto Pedroza Serrano','ALUMINIO ½ X 12 X 48','1804.20'),(96,'NA','06/06/2018','AG1088',20,'SY5300-5U1 ','Kevin Gonzalez Esparza','VALVULA SOLENOIDE','949.00'),(97,'OC106','06/06/2018','AG1068',1,'N/A','Arturo Estrada','ALUMINIO Ø½  X 12','15.25'),(98,'NA','06/06/2018','AG1043',20,'LV0050V1','Kevin Gonzalez Esparza','RUEDA NIVELADORA M-1','342.50'),(99,'NA','06/06/2018','AG978',3,'L14-20P','Arturo Estrada','CLAVIJA C/SEGURO 20A 125/250V','532'),(100,'OC109','06/06/2018','AG1096',1,'N/A','Arturo Estrada','ALUMINIO 2 X 2¼ X 6','179.40'),(101,'OC109','06/06/2018','AG1096',1,'N/A','Adalberto Perez Manzo','ALUMINIO 2 X 2¼ X 6','179.40'),(102,'OC110','13/06/2018','AG1002',1,'N/A','Marcelo Estrada Montijo','ALUMINIO Ø4 X 10','0.00'),(103,'OC110','13/06/2018','AG297',1,'C0-00DR-D','Marcelo Estrada Montijo','BASIC PLC','0.00'),(104,'OC110','13/06/2018','AG1043',1,'LV0050V1','Marcelo Estrada Montijo','RUEDA NIVELADORA M-1','1370.00'),(105,'OC110','13/06/2018','AG1057',1,'LV0600V3','Marcelo Estrada Montijo','RUEDA NIVELADORA GRANDE M-1','553.50'),(106,'OC110','13/06/2018','AG1002',0,'N/A','Francisco Trevizo Rodriguez','ALUMINIO Ø4 X 10','0.00'),(107,'OC110','13/06/2018','AG297',2,'C0-00DR-D','Francisco Trevizo Rodriguez','BASIC PLC','0.00'),(108,'OC110','13/06/2018','AG1043',2,'LV0050V1','Francisco Trevizo Rodriguez','RUEDA NIVELADORA M-1','1370.00'),(109,'OC110','13/06/2018','AG1057',2,'LV0600V3','Francisco Trevizo Rodriguez','RUEDA NIVELADORA GRANDE M-1','553.50'),(110,'NA','13/06/2018','AG1043',6,'LV0050V1','Alfredo Damian Arellano Valenzuela','RUEDA NIVELADORA M-1','234'),(111,'OC102','18/06/2018','AG1008',1,'N/A','Roberto Pedroza Serrano','ALUMINIO ½ X 2 X 32','255'),(112,'OC102','18/06/2018','AG1058',1,'N/A','Roberto Pedroza Serrano','A-2   2 X 2.125 X 2¾','480');
/*!40000 ALTER TABLE `entrada_material` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-05  9:04:46
