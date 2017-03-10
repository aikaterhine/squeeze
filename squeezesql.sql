-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: 127.0.0.1    Database: squeezebd
-- ------------------------------------------------------
-- Server version	5.7.16-log

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
-- Table structure for table `album`
--

DROP TABLE IF EXISTS `album`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `album` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `estudio` varchar(45) DEFAULT NULL,
  `dtlancamento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `album`
--

LOCK TABLES `album` WRITE;
/*!40000 ALTER TABLE `album` DISABLE KEYS */;
INSERT INTO `album` VALUES (1,'aasdsa','asdasd','sadasd'),(2,'asdasd','sadasd','asdasdd'),(3,'dddd','dddd','ddd'),(4,'aaaa','aaaa','quinta-feira, 9 de março de 2017'),(5,'aaa','aaa','quinta-feira, 9 de março de 2017'),(6,'aaaa','aaaa','sexta-feira, 10 de março de 2017');
/*!40000 ALTER TABLE `album` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `albumartista`
--

DROP TABLE IF EXISTS `albumartista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `albumartista` (
  `idartista` int(11) NOT NULL,
  `idalbum` int(11) NOT NULL,
  PRIMARY KEY (`idartista`,`idalbum`),
  KEY `fk_artistas_has_albuns_albuns1_idx` (`idalbum`),
  KEY `fk_artistas_has_albuns_artistas1_idx` (`idartista`),
  CONSTRAINT `fk_artistas_has_albuns_albuns1` FOREIGN KEY (`idalbum`) REFERENCES `album` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_artistas_has_albuns_artistas1` FOREIGN KEY (`idartista`) REFERENCES `artista` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `albumartista`
--

LOCK TABLES `albumartista` WRITE;
/*!40000 ALTER TABLE `albumartista` DISABLE KEYS */;
INSERT INTO `albumartista` VALUES (2014120312,6);
/*!40000 ALTER TABLE `albumartista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artista`
--

DROP TABLE IF EXISTS `artista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `artista` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `tipocarreira` int(11) NOT NULL,
  `dtcarreira` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_artistas_carreiraMusical1_idx` (`tipocarreira`),
  CONSTRAINT `fk_artistas_carreiraMusical1` FOREIGN KEY (`tipocarreira`) REFERENCES `tipocarreira` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2014120318 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artista`
--

LOCK TABLES `artista` WRITE;
/*!40000 ALTER TABLE `artista` DISABLE KEYS */;
INSERT INTO `artista` VALUES (2014120312,'Lorde',1,'quinta-feira, 9 de março de 2017'),(2014120313,'Phantogram',1,'quinta-feira, 9 de março de 2017'),(2014120314,'Sigrid',1,'quinta-feira, 9 de março de 2017'),(2014120315,'aaaaa',1,'quinta-feira, 9 de março de 2017'),(2014120316,'fffff',1,'quinta-feira, 9 de março de 2017'),(2014120317,'gggg',1,'quinta-feira, 9 de março de 2017');
/*!40000 ALTER TABLE `artista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artistafavorito`
--

DROP TABLE IF EXISTS `artistafavorito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `artistafavorito` (
  `idusuario` int(11) NOT NULL,
  `idartista` int(11) NOT NULL,
  PRIMARY KEY (`idusuario`,`idartista`),
  KEY `fk_usuarios_has_artistas_artistas1_idx` (`idartista`),
  KEY `fk_usuarios_has_artistas_usuarios1_idx` (`idusuario`),
  CONSTRAINT `fk_usuarios_has_artistas_artistas1` FOREIGN KEY (`idartista`) REFERENCES `artista` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarios_has_artistas_usuarios1` FOREIGN KEY (`idusuario`) REFERENCES `usuario` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artistafavorito`
--

LOCK TABLES `artistafavorito` WRITE;
/*!40000 ALTER TABLE `artistafavorito` DISABLE KEYS */;
/*!40000 ALTER TABLE `artistafavorito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faixa`
--

DROP TABLE IF EXISTS `faixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faixa` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  `duracao` varchar(45) DEFAULT NULL,
  `idalbum` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_faixas_albuns1_idx` (`idalbum`),
  CONSTRAINT `fk_faixas_albuns1` FOREIGN KEY (`idalbum`) REFERENCES `album` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faixa`
--

LOCK TABLES `faixa` WRITE;
/*!40000 ALTER TABLE `faixa` DISABLE KEYS */;
INSERT INTO `faixa` VALUES (1,'zzz','zzz',6),(2,'sssss','ssss',6);
/*!40000 ALTER TABLE `faixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `generoartista`
--

DROP TABLE IF EXISTS `generoartista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `generoartista` (
  `idartista` int(11) NOT NULL,
  `idgenero` int(11) NOT NULL,
  PRIMARY KEY (`idartista`,`idgenero`),
  KEY `fk_generoartista_artista1_idx` (`idartista`),
  KEY `fk_generoartista_tipogenero1_idx` (`idgenero`),
  CONSTRAINT `fk_generoartista_artista1` FOREIGN KEY (`idartista`) REFERENCES `artista` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_generoartista_tipogenero1` FOREIGN KEY (`idgenero`) REFERENCES `tipogenero` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `generoartista`
--

LOCK TABLES `generoartista` WRITE;
/*!40000 ALTER TABLE `generoartista` DISABLE KEYS */;
/*!40000 ALTER TABLE `generoartista` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipocarreira`
--

DROP TABLE IF EXISTS `tipocarreira`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipocarreira` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipocarreira`
--

LOCK TABLES `tipocarreira` WRITE;
/*!40000 ALTER TABLE `tipocarreira` DISABLE KEYS */;
INSERT INTO `tipocarreira` VALUES (1,'Solo');
/*!40000 ALTER TABLE `tipocarreira` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipogenero`
--

DROP TABLE IF EXISTS `tipogenero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipogenero` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipogenero`
--

LOCK TABLES `tipogenero` WRITE;
/*!40000 ALTER TABLE `tipogenero` DISABLE KEYS */;
INSERT INTO `tipogenero` VALUES (1,'Pop'),(2,'Indie');
/*!40000 ALTER TABLE `tipogenero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `senha` varchar(8) DEFAULT NULL,
  `tipo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'catarina','catarina','123',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-03-10 10:48:47
