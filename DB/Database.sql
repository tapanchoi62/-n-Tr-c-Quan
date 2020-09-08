CREATE DATABASE  IF NOT EXISTS `qlcssx_clsp` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `qlcssx_clsp`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: qlcssx_clsp
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `chitieu`
--

DROP TABLE IF EXISTS `chitieu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chitieu` (
  `mact` varchar(5) NOT NULL,
  `tenct` varchar(100) NOT NULL,
  `ynghia` varchar(300) NOT NULL,
  PRIMARY KEY (`mact`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chitieu`
--

LOCK TABLES `chitieu` WRITE;
/*!40000 ALTER TABLE `chitieu` DISABLE KEYS */;
INSERT INTO `chitieu` VALUES ('CT01','Kích thước, ngoại quan và cơ lý - Thép','Các tiêu chuẩn về kích thước hình học, ngoại quan (bao gồm bề mặt,mép cán), các giới hạn chảy, giới hạn bền, giới hạn kéo độ dãn của thép'),('CT02','Hoá học - Thép','Thực hiện công bố hàm lượng các nguyên tố C, Si, Mn, P, S, Cr, Ni... của thép'),('CT03','Kết cấu - Tôn','Chất lượng được biểu hiện qua chất liệu mái tôn. Mái 1 lớp, 3 lớp hay mái chống nóng'),('CT04','Độ dày - Tôn','Tuỳ vào từng loại và yếu tố kỹ thuật có tiêu chuẩn riêng. Đơn vị đo chuẩn là zem. Dao động từ 2-5 zem tuỳ loại'),('CT05','Chỉ số PH - Phân bón','Các chỉ số pH (CaCl2); pH (H2O); pH (KCl)'),('CT06','Độ ẩm - Phân bón','Độ ẩm mẫu là hàm lượng nước có trong mẫu, được biểu thị bằng tỷ số phần trăm giữa khối lượng nước có trong mẫu bay hơi sau khi sấy đến khô tuyệt đối với khối lượng mẫu trước khi sấy (ký hiệu %A)'),('CT07','Hàm lượng phốt pho - Phân bón','Xác định phốt pho tổng số của các loại phân bón có chứa phốt pho dạng khoáng, dạng hữu cơ (phân khoáng đơn, khoáng phức hợp, khoáng hỗn hợp, phân hữu cơ, hữu cơ vi sinh, hữu cơ sinh học, hữu cơ khoáng, than bùn) và các loại quặng có chưa phốt pho (apatit, photphorit)'),('CT08','Hàm lượng Kali - Phân bón','Xác định kali tổng số của các loại phân bón có chứa kali bao gồm phân kali khoáng (khoáng đơn, khoáng hỗn hợp, khoáng phức hợp) và phân có chứa cả chất hữu cơ và kali (phân hữu cơ, hữu cơ vi sinh, hữu cơ sinh học, hữu cơ khoáng, than bùn)'),('CT09','Hàm lượng Natri - Phân bón','Xác định natri tổng số của các loại phân bón có chứa natri bao gồm phân kali khoáng (khoáng đơn, khoáng hỗn hợp, khoáng phức hợp) và phân có chứa cả chất hữu cơ và natri (phân hữu cơ, hữu cơ vi sinh, hữu cơ sinh học, hữu cơ khoáng, than bùn)');
/*!40000 ALTER TABLE `chitieu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cssx`
--

DROP TABLE IF EXISTS `cssx`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cssx` (
  `macs` int(11) NOT NULL AUTO_INCREMENT,
  `tencs` varchar(50) NOT NULL,
  `diachi` varchar(50) NOT NULL,
  `tenchu` varchar(50) NOT NULL,
  `sodt` varchar(12) NOT NULL,
  PRIMARY KEY (`macs`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cssx`
--

LOCK TABLES `cssx` WRITE;
/*!40000 ALTER TABLE `cssx` DISABLE KEYS */;
INSERT INTO `cssx` VALUES (1,'Phước Hoà','TpHCM','Nguyễn Văn Hoà','0913333333'),(2,'Trần Hưng','TpHCM','Văn Trần Hưng','0973222333'),(3,'Hữu Dư','Đà Nẵng','Phạm Hữu ','0938485769'),(4,'Hoà Phát','HN','Trần Đình Long','0398759283'),(5,'Trung nguyên Legend','TpHCM','Đặng Lê Nguyên Vũ','0384957322'),(6,'Vạn Thành','Huế','Thành Công','0837495742');
/*!40000 ALTER TABLE `cssx` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ctphieudangky`
--

DROP TABLE IF EXISTS `ctphieudangky`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ctphieudangky` (
  `spdk` varchar(10) NOT NULL,
  `mact` varchar(5) NOT NULL,
  `csdk` int(11) NOT NULL,
  PRIMARY KEY (`spdk`,`mact`),
  KEY `fk_ctdk_pdk_idx` (`spdk`),
  KEY `fk_ctdk_ct_idx` (`mact`),
  CONSTRAINT `fk_ctdk_ct` FOREIGN KEY (`mact`) REFERENCES `chitieu` (`mact`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ctdk_pdk` FOREIGN KEY (`spdk`) REFERENCES `phieudangky` (`spdk`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ctphieudangky`
--

LOCK TABLES `ctphieudangky` WRITE;
/*!40000 ALTER TABLE `ctphieudangky` DISABLE KEYS */;
INSERT INTO `ctphieudangky` VALUES ('PDK0001','CT05',10),('PDK0001','CT06',15),('PDK0002','CT07',12),('PDK0002','CT09',20),('PDK0004','CT03',20),('PDK0004','CT05',12),('PDK0005','CT01',100);
/*!40000 ALTER TABLE `ctphieudangky` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ctphieukiemnghiem`
--

DROP TABLE IF EXISTS `ctphieukiemnghiem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ctphieukiemnghiem` (
  `spkn` varchar(10) NOT NULL,
  `mact` varchar(5) NOT NULL,
  `cskn` int(11) NOT NULL,
  `cskq` int(11) NOT NULL,
  PRIMARY KEY (`spkn`,`mact`),
  KEY `fk_ctpkn_pkn_idx` (`spkn`),
  KEY `fk_ctpkn_ctpdk_idx` (`mact`),
  CONSTRAINT `fk_ctpkn_ctpdk` FOREIGN KEY (`mact`) REFERENCES `ctphieudangky` (`mact`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ctpkn_pkn` FOREIGN KEY (`spkn`) REFERENCES `phieukiemnghiem` (`spkn`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ctphieukiemnghiem`
--

LOCK TABLES `ctphieukiemnghiem` WRITE;
/*!40000 ALTER TABLE `ctphieukiemnghiem` DISABLE KEYS */;
INSERT INTO `ctphieukiemnghiem` VALUES ('PKN0001','CT05',8,9),('PKN0001','CT06',10,19),('PKN0002','CT07',12,9),('PKN0002','CT09',20,10),('PKN0003','CT05',15,16),('PKN0004','CT03',15,10);
/*!40000 ALTER TABLE `ctphieukiemnghiem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `nhanvien` (
  `manv` int(11) NOT NULL AUTO_INCREMENT,
  `tennv` varchar(45) NOT NULL,
  `ngsinh` date NOT NULL,
  `gioitinh` varchar(5) NOT NULL,
  `mapb` varchar(45) DEFAULT NULL,
  `sdt` varchar(12) NOT NULL,
  PRIMARY KEY (`manv`),
  KEY `fk_nv_pb_idx` (`mapb`),
  CONSTRAINT `fk_nv_pb` FOREIGN KEY (`mapb`) REFERENCES `phongban` (`mapb`) ON DELETE SET NULL ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES (1,'Nguyễn Văn A','1978-03-02','Nam','pb01','0938484729'),(2,'Nguyễn Thị B','1980-02-29','Nữ','pb01','04827465927'),(3,'Trần Công Cẩn','1990-02-02','Nam','pb02','0938474628'),(4,'Trần Hoàn Hảo','1974-09-02','Nam','pb02','0938372648'),(5,'Trần Mạnh Mẽ','1987-08-07','Nam','pb03','09391749282'),(6,'Lê Văn D','1979-05-05','Nam','pb03','09487267492'),(7,'Võ Thị T','1989-08-19','Nữ','pb03','033492729'),(8,'Nguyễn Phú T','1990-10-10','Nam','pb04','0938382929');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieudangky`
--

DROP TABLE IF EXISTS `phieudangky`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `phieudangky` (
  `spdk` varchar(10) NOT NULL,
  `ngdk` date NOT NULL,
  `nghh` date NOT NULL,
  `macs` int(11) NOT NULL,
  `masp` varchar(6) NOT NULL,
  `sl` int(11) NOT NULL,
  PRIMARY KEY (`spdk`),
  KEY `fk_pdk_cs_idx` (`macs`),
  KEY `fk_pdk_sp_idx` (`masp`),
  CONSTRAINT `fk_pdk_cs` FOREIGN KEY (`macs`) REFERENCES `cssx` (`macs`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_pdky_sp` FOREIGN KEY (`masp`) REFERENCES `sanpham` (`masp`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieudangky`
--

LOCK TABLES `phieudangky` WRITE;
/*!40000 ALTER TABLE `phieudangky` DISABLE KEYS */;
INSERT INTO `phieudangky` VALUES ('PDK0001','2019-06-05','2019-06-29',1,'sp101',1000),('PDK0002','2018-07-12','2025-07-12',1,'sp102',100),('PDK0004','2019-06-06','2019-06-06',5,'sp203',100),('PDK0005','2019-06-01','2019-06-01',6,'sp404',100);
/*!40000 ALTER TABLE `phieudangky` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieukiemnghiem`
--

DROP TABLE IF EXISTS `phieukiemnghiem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `phieukiemnghiem` (
  `spkn` varchar(10) NOT NULL,
  `spdk` varchar(10) NOT NULL,
  `ngaykn` date NOT NULL,
  `manv` int(11) NOT NULL,
  `masp` varchar(6) NOT NULL,
  `kl` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`spkn`),
  KEY `fk_pkn_pdk_idx` (`spdk`),
  KEY `fk_pkn_sp_idx` (`masp`),
  KEY `fk_pkn_nv_idx` (`manv`),
  CONSTRAINT `fk_pkn_nv` FOREIGN KEY (`manv`) REFERENCES `nhanvien` (`manv`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_pkn_sp` FOREIGN KEY (`masp`) REFERENCES `sanpham` (`masp`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `kn_dk` FOREIGN KEY (`spdk`) REFERENCES `phieudangky` (`spdk`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieukiemnghiem`
--

LOCK TABLES `phieukiemnghiem` WRITE;
/*!40000 ALTER TABLE `phieukiemnghiem` DISABLE KEYS */;
INSERT INTO `phieukiemnghiem` VALUES ('PKN0001','PDK0001','2018-04-25',1,'sp101','Mẫu thử đạt chất lượng'),('PKN0002','PDK0002','2017-06-09',2,'sp102','Mẫu thử không đạt chất lượng'),('PKN0003','PDK0001','2019-06-21',4,'sp503','ABC'),('PKN0004','PDK0004','2019-06-13',5,'sp203',NULL);
/*!40000 ALTER TABLE `phieukiemnghiem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phongban`
--

DROP TABLE IF EXISTS `phongban`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `phongban` (
  `mapb` varchar(5) NOT NULL,
  `tenpb` varchar(45) NOT NULL,
  PRIMARY KEY (`mapb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phongban`
--

LOCK TABLES `phongban` WRITE;
/*!40000 ALTER TABLE `phongban` DISABLE KEYS */;
INSERT INTO `phongban` VALUES ('pb01','Phòng hành chính'),('pb02','Phòng kinh doanh'),('pb03','Phòng kiểm định'),('pb04','Phòng kỹ thuật');
/*!40000 ALTER TABLE `phongban` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sanpham`
--

DROP TABLE IF EXISTS `sanpham`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sanpham` (
  `masp` varchar(6) NOT NULL,
  `tensp` varchar(45) NOT NULL,
  `donvi` varchar(45) NOT NULL,
  `macs` int(11) NOT NULL,
  PRIMARY KEY (`masp`),
  KEY `fk_sp_cs_idx` (`macs`),
  CONSTRAINT `fk_sp_cs` FOREIGN KEY (`macs`) REFERENCES `cssx` (`macs`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sanpham`
--

LOCK TABLES `sanpham` WRITE;
/*!40000 ALTER TABLE `sanpham` DISABLE KEYS */;
INSERT INTO `sanpham` VALUES ('sp001','Thép ống','cây',3),('sp002','Thép cuộn','mét',3),('sp003','Ống nhưa','cây',3),('sp004','Tôn lạnh','tấm',3),('sp005','Tôn vân gỗ','tấm',3),('sp006','Xi măng','bao',3),('sp101','Phân bón NPK','bao',1),('sp102','Phân bón hữu cơ','bao',1),('sp103','Phân Kali','bao',1),('sp104','Phân lân','bao',1),('sp105','Phân Ure','bao',1),('sp201','Cà phê hoà tan','hộp',5),('sp202','Cà phê rang xay','hộp',5),('sp203','Cà phê chồn Robusta','hộp',5),('sp204','Cà phê hạt','hộp/bịch',5),('sp205','Cà phê bột','hộp/bịch',5),('sp301','Nồi cơm điện','cái',2),('sp302','Bếp từ','cái',2),('sp303','Bếp hồng ngoại','cái',2),('sp304','Lò vi sóng','cái',2),('sp305','Nồi áp suất','cái',2),('sp306','Bình đun nước siêu tốc','cái',2),('sp307','Bếp ga','cái',2),('sp401','Máy thể dục đa năng','cái',6),('sp402','Cân sức khoẻ','cái',6),('sp403','Ghế massage','cái',6),('sp404','Máy massage bụng','cái',6),('sp501','Máy điều hoà','cái',4),('sp502','Quạt điều hoà','cái',4),('sp503','Tủ lạnh','cái',4),('sp504','Bình lọc nước nóng lạnh','cái',4);
/*!40000 ALTER TABLE `sanpham` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `taikhoan` (
  `matk` int(11) NOT NULL AUTO_INCREMENT,
  `tentk` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `matkhau` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `manv` int(11) NOT NULL,
  `quyen` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`matk`),
  UNIQUE KEY `manv_UNIQUE` (`manv`),
  KEY `fk_tk_nv_idx` (`manv`),
  CONSTRAINT `fk_tk_nv` FOREIGN KEY (`manv`) REFERENCES `nhanvien` (`manv`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taikhoan`
--

LOCK TABLES `taikhoan` WRITE;
/*!40000 ALTER TABLE `taikhoan` DISABLE KEYS */;
INSERT INTO `taikhoan` VALUES (1,'TMS','123',1,'nhanvien'),(2,'SML','123',2,'quanly'),(3,'QL','12345',3,'quanly');
/*!40000 ALTER TABLE `taikhoan` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-07 18:28:15
