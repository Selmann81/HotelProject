-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: otel
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20221202064531_first','3.1.31'),('20221202082403_odatips','3.1.31'),('20221202123358_guncelleme','3.1.31'),('20221202124116_guncellemee','3.1.31'),('20221206080142_ekleme_mig','3.1.31'),('20221214142402_randomkey','3.1.31');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admins` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `KullaniciAdi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Sifre` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musteris`
--

DROP TABLE IF EXISTS `musteris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `musteris` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `Adisoyadi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `DogumTarihi` datetime(6) NOT NULL,
  `TcNo` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Uyruk` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Telefon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musteris`
--

LOCK TABLES `musteris` WRITE;
/*!40000 ALTER TABLE `musteris` DISABLE KEYS */;
INSERT INTO `musteris` VALUES (1,'Selman Yılmaz','2004-11-20 00:00:00.000000','12345678901','Tc','5341234567',1),(2,'deneme','2002-12-13 00:00:00.000000','12312313','tc','123123123',1),(3,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,NULL,0),(4,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'23132132123',0),(5,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'3213123123',0),(6,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'123131233',0),(7,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'31231231',0),(8,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'213123123231',0),(9,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'213123',0),(10,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'12312312',0),(11,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'145236114',0),(12,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'123123321',0),(13,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'2313',0),(14,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'2332412412',0),(15,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'2542452',0),(16,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'3123123',0),(17,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'432341124',0),(18,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'857578',0),(19,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'75785',0),(20,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'5785875',0),(21,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'431243123',0),(22,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'4324214312',0),(23,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'767687867',0),(24,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'52575',0),(25,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'123456789',0),(26,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'123123231',0),(27,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'adsdad',0),(28,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'24342243',0),(29,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'31231232213',0),(30,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'4234124',0),(31,NULL,'0001-01-01 00:00:00.000000',NULL,NULL,'231332121',0);
/*!40000 ALTER TABLE `musteris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odalars`
--

DROP TABLE IF EXISTS `odalars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odalars` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `OdaAdi` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `OdaNo` int NOT NULL,
  `OdaTip` int NOT NULL,
  `Cephe` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `YatakSayisi` int NOT NULL,
  `Ozellikler` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int NOT NULL,
  `Aciklama` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Anasayfa` tinyint(1) NOT NULL,
  PRIMARY KEY (`Idno`),
  KEY `IX_Odalars_OdaTip` (`OdaTip`),
  CONSTRAINT `FK_Odalars_OdaTips_OdaTip` FOREIGN KEY (`OdaTip`) REFERENCES `odatips` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odalars`
--

LOCK TABLES `odalars` WRITE;
/*!40000 ALTER TABLE `odalars` DISABLE KEYS */;
INSERT INTO `odalars` VALUES (1,'Boş Oda ',0,1,'Yok',0,'1,2,3,6,9',1,'',0),(2,'Single Room',101,1,'Kara ',2,'1,2,3,5,10,12',1,NULL,1),(3,'Single Room',102,1,'Deniz ',2,'1,2,3,5,10,12',1,NULL,1),(4,'Single Room',103,1,'Yamaç',2,'1,2,3,5,10,12',1,NULL,1),(5,'Double Room',104,2,'Bahçe',1,'1,2,4,5,7,9,10,12',1,NULL,1),(6,'Double Room',201,2,'Kara',1,'1,2,3,5,10,12',1,NULL,1),(7,'Double Room',202,2,'Deniz',2,'1,2,3,5,10,12',1,NULL,1),(8,'Triple Room',203,3,'Bahçe',2,'1,2,3,5,10,12',1,NULL,1),(9,'Triple Room',204,3,'Yamaç',2,'1,2,3,5,10,12',1,NULL,1),(10,'Aile Oda(2+1+1)',301,8,'Bahçe',3,'1,2,3,5,10,12',1,NULL,1),(11,'Aile Oda(2+1+1)',302,8,'Deniz',3,'1,2,3,5,10,12',1,NULL,1),(12,'Aile Oda(2+1+1)',303,8,'Yamaç',3,'1,2,3,5,10,12',1,NULL,1),(13,'Junior Suite(1 Yatak)',304,5,'Deniz',1,'1,2,3,5,10,12',1,NULL,1),(14,'Junior Suite(2+1 Yatak)',305,5,'Bahçe',2,'1,2,3,5,10,12',1,'',1),(15,'Suit Oda (2+1)',401,6,'Deniz',2,'1,2,3,5,10,12',1,NULL,1),(16,'Suit Oda(2+1+1)',402,6,'Deniz',3,'1,2,3,5,10,12',1,NULL,1),(17,'Dubleks(2+2+1+1)',403,7,'Deniz',4,'1,2,3,5,10,12',1,NULL,1),(18,'Kral Dairesi',501,9,'Tüm',5,'1,2,3,5,10,12',1,NULL,1),(19,'Deneme oda',2,4,'Ön',3,NULL,0,NULL,0);
/*!40000 ALTER TABLE `odalars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odaozelliks`
--

DROP TABLE IF EXISTS `odaozelliks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odaozelliks` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `Ikon` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Act` int NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odaozelliks`
--

LOCK TABLES `odaozelliks` WRITE;
/*!40000 ALTER TABLE `odaozelliks` DISABLE KEYS */;
INSERT INTO `odaozelliks` VALUES (1,'fas fa-wind','Klima',1),(2,'fas fa-wifi','Ücretsiz Wifi',1),(3,'fa-windd','Deneme',1);
/*!40000 ALTER TABLE `odaozelliks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odatips`
--

DROP TABLE IF EXISTS `odatips`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odatips` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ozellikler` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ucret` double NOT NULL,
  `Act` int NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=199 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odatips`
--

LOCK TABLES `odatips` WRITE;
/*!40000 ALTER TABLE `odatips` DISABLE KEYS */;
INSERT INTO `odatips` VALUES (1,'Single Room','Çok güzel',100,1),(2,'Double Room','Çok güzel',125,1),(3,'Triple Room',NULL,150,1),(4,'Quad Room',NULL,160,1),(5,'Junior Suite Room',NULL,180,1),(6,'Suit',NULL,220,1),(7,'Dubleks',NULL,260,1),(8,'Aile Odası',NULL,300,1),(9,'Kral Dairesi',NULL,500,1),(194,'Deneme',NULL,123,1),(195,'dsadad',NULL,123,1),(196,'Deneme',NULL,12313,1),(197,'E2',NULL,0,1),(198,'Deneme',NULL,111,1);
/*!40000 ALTER TABLE `odatips` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pansiyonlars`
--

DROP TABLE IF EXISTS `pansiyonlars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pansiyonlars` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `Baslik` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Ucret` double NOT NULL,
  `Act` int NOT NULL,
  PRIMARY KEY (`Idno`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pansiyonlars`
--

LOCK TABLES `pansiyonlars` WRITE;
/*!40000 ALTER TABLE `pansiyonlars` DISABLE KEYS */;
INSERT INTO `pansiyonlars` VALUES (1,'Sadece Oda',0,1),(2,'Yarım Pansiyon',150,1),(3,'Tam Pansiyon',250,1),(4,'Oda Kahvaltı',500,1),(5,'Deneme',11,0);
/*!40000 ALTER TABLE `pansiyonlars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rezervasyons`
--

DROP TABLE IF EXISTS `rezervasyons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rezervasyons` (
  `Idno` int NOT NULL AUTO_INCREMENT,
  `MusteriId` int NOT NULL,
  `OdaId` int DEFAULT NULL,
  `OdaTipId` int NOT NULL,
  `GirisTarihi` datetime(6) NOT NULL,
  `CikisTarihi` datetime(6) NOT NULL,
  `Ucret` double NOT NULL,
  `Pansiyon` int NOT NULL,
  `EkUcret` double NOT NULL,
  `Aciklama` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Yetiskin` int NOT NULL,
  `Cocuk` int NOT NULL,
  `Act` int NOT NULL,
  `RandomKey` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Idno`),
  KEY `IX_Rezervasyons_MusteriId` (`MusteriId`),
  KEY `IX_Rezervasyons_OdaId` (`OdaId`),
  KEY `IX_Rezervasyons_OdaTipId` (`OdaTipId`),
  KEY `IX_Rezervasyons_Pansiyon` (`Pansiyon`),
  CONSTRAINT `FK_Rezervasyons_Musteris_MusteriId` FOREIGN KEY (`MusteriId`) REFERENCES `musteris` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_Rezervasyons_Odalars_OdaId` FOREIGN KEY (`OdaId`) REFERENCES `odalars` (`Idno`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Rezervasyons_OdaTips_OdaTipId` FOREIGN KEY (`OdaTipId`) REFERENCES `odatips` (`Idno`) ON DELETE CASCADE,
  CONSTRAINT `FK_Rezervasyons_Pansiyonlars_Pansiyon` FOREIGN KEY (`Pansiyon`) REFERENCES `pansiyonlars` (`Idno`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezervasyons`
--

LOCK TABLES `rezervasyons` WRITE;
/*!40000 ALTER TABLE `rezervasyons` DISABLE KEYS */;
INSERT INTO `rezervasyons` VALUES (3,5,1,1,'0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000',0,1,0,NULL,1,1,1,NULL),(4,6,1,2,'0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000',0,2,0,NULL,2,2,1,NULL),(5,3,1,1,'0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000',0,1,0,NULL,2,2,1,NULL),(6,3,1,1,'0001-01-01 00:00:00.000000','0001-01-01 00:00:00.000000',0,1,0,NULL,1,1,1,NULL),(7,7,1,1,'2022-12-16 00:00:00.000000','2022-12-19 00:00:00.000000',0,1,0,NULL,2,2,1,NULL),(8,8,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,2,2,1,'ARWUSJ'),(9,2,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,3,2,1,'AFSI3R'),(10,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,2,1,'RE09D4'),(11,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'XF4RUL'),(12,9,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,3,2,1,'RBQN63'),(13,3,1,2,'2022-12-15 00:00:00.000000','2022-12-17 00:00:00.000000',0,2,0,NULL,2,2,1,'APUYTD'),(14,10,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,1,1,1,'FF57C1'),(15,11,1,2,'2022-12-16 00:00:00.000000','2022-12-18 00:00:00.000000',0,2,0,NULL,2,2,1,'J4IFQK'),(16,3,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,3,0,NULL,2,2,1,'7T32NW'),(17,12,1,2,'2022-12-16 00:00:00.000000','2022-12-17 00:00:00.000000',0,2,0,NULL,3,1,1,'KVKYXO'),(18,14,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,3,3,1,'PTVGM9'),(19,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'RW6NCV'),(20,15,1,3,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,3,0,NULL,3,2,1,'4IY3LQ'),(21,16,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'7LG24T'),(22,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,2,1,1,'RN271V'),(23,17,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'VJUS9B'),(24,18,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'ZM0MFG'),(25,19,1,2,'2022-12-16 00:00:00.000000','2022-12-18 00:00:00.000000',0,2,0,NULL,3,1,1,'8Y3DI7'),(29,23,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,2,1,1,'NQNGKM'),(30,24,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,2,1,1,'GWGMH8'),(31,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'P8NKZ7'),(32,25,1,5,'2022-12-15 00:00:00.000000','2022-12-18 00:00:00.000000',0,2,0,NULL,2,2,1,'S3AXWD'),(35,3,1,1,'2022-12-15 00:00:00.000000','2022-12-24 00:00:00.000000',0,1,0,NULL,1,1,1,'C6EHJO'),(36,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'UFEZS8'),(37,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'YVRPXV'),(38,3,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'1MR8M7'),(39,26,1,1,'2022-12-15 00:00:00.000000','2022-12-19 00:00:00.000000',0,1,0,NULL,1,1,1,'ABMLD4'),(40,27,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'BL5J9R'),(41,28,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'F8XI4Z'),(42,29,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,1,0,NULL,1,1,1,'O5C55U'),(43,30,1,1,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,1,1,1,'FTQ4R8'),(44,31,1,2,'2022-12-15 00:00:00.000000','2022-12-16 00:00:00.000000',0,2,0,NULL,1,1,1,'RPB6DI');
/*!40000 ALTER TABLE `rezervasyons` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-15 17:50:14
