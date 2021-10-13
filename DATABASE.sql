-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: ebs
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bill_db`
--

DROP TABLE IF EXISTS `bill_db`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bill_db` (
  `CONSUMER_ID` bigint DEFAULT NULL,
  `BILL_ID` bigint NOT NULL AUTO_INCREMENT,
  `BILL_AMOUNT` bigint DEFAULT NULL,
  `BILL_DATE` date DEFAULT NULL,
  `BILL_DUE_DATE` date DEFAULT NULL,
  `UNITS_CONSUMED` bigint DEFAULT NULL,
  `BILL_STATUS` varchar(100) DEFAULT NULL,
  `PAYMENT_METHOD` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`BILL_ID`),
  KEY `CONSUMER_ID` (`CONSUMER_ID`),
  CONSTRAINT `bill_db_ibfk_1` FOREIGN KEY (`CONSUMER_ID`) REFERENCES `consumer_db` (`CONSUMER_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bill_db`
--

LOCK TABLES `bill_db` WRITE;
/*!40000 ALTER TABLE `bill_db` DISABLE KEYS */;
INSERT INTO `bill_db` VALUES (1,1,12400,'2021-08-13','2021-09-25',124,'PAID',' Debit Card '),(1,2,32400,'2021-08-12','2021-09-11',324,'PAID',' Debit Card '),(1,3,5700,'2021-08-13','2021-09-12',57,' PAID ',' NULL '),(1,4,50000,'2021-08-20','2021-09-25',500,'PAID',' Credit Card '),(2,8,11800,'2021-08-20','2021-09-19',118,' PAID ',' NULL ');
/*!40000 ALTER TABLE `bill_db` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consumer_db`
--

DROP TABLE IF EXISTS `consumer_db`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consumer_db` (
  `CONSUMER_ID` bigint NOT NULL AUTO_INCREMENT,
  `CONSUMER_NAME` varchar(500) DEFAULT NULL,
  `CONSUMER_PHONE` varchar(500) DEFAULT NULL,
  `CONSUMER_EMAIL` varchar(500) DEFAULT NULL,
  `CONSUMER_STATE` varchar(500) DEFAULT NULL,
  `CONSUMER_CITY` varchar(500) DEFAULT NULL,
  `CONSUMER_PIN_CODE` bigint DEFAULT NULL,
  `METER_ID` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`CONSUMER_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consumer_db`
--

LOCK TABLES `consumer_db` WRITE;
/*!40000 ALTER TABLE `consumer_db` DISABLE KEYS */;
INSERT INTO `consumer_db` VALUES (1,' Likhan ',' 700223563 ',' aman123@gmail.com ',' assam ',' ghy ',793101,'10001111 '),(2,' Noorain ',' 34563574373 ',' noorainAK47@gmail.com ',' Assam ',' Guwahati ',842347,'8890 '),(3,' Aman Patel ',' 7002235778 ',' aman17627@gmail.com ',' Bihar ',' Patna ',844116,'1001 ');
/*!40000 ALTER TABLE `consumer_db` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-24 20:18:15
