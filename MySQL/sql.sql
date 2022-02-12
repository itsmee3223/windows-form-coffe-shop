/*
SQLyog Ultimate v12.5.1 (64 bit)
MySQL - 10.4.21-MariaDB : Database - cofee
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`cofee` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `cofee`;

/*Table structure for table `detail_transaksi` */

DROP TABLE IF EXISTS `detail_transaksi`;

CREATE TABLE `detail_transaksi` (
  `id_transaksi` varchar(10) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `handphone` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id_transaksi`),
  CONSTRAINT `detail_transaksi_ibfk_1` FOREIGN KEY (`id_transaksi`) REFERENCES `transaksi` (`id_transaksi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `detail_transaksi` */

insert  into `detail_transaksi`(`id_transaksi`,`tanggal`,`alamat`,`handphone`) values 
('TR300','2022-01-05','Tanjung Bintang','0898987675'),
('TR500','2022-01-11','Bandar','081111111');

/*Table structure for table `menu` */

DROP TABLE IF EXISTS `menu`;

CREATE TABLE `menu` (
  `id_menu` varchar(5) NOT NULL,
  `nama_menu` varchar(25) DEFAULT NULL,
  `harga` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_menu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `menu` */

insert  into `menu`(`id_menu`,`nama_menu`,`harga`) values 
('C001','Coffe Late',15000),
('C012','Matcha',12000),
('C015','Beef Buter',25000),
('C121','Kopi Hitam',25000),
('C800','Burger',25000);

/*Table structure for table `pembeli` */

DROP TABLE IF EXISTS `pembeli`;

CREATE TABLE `pembeli` (
  `id_pembeli` varchar(5) NOT NULL,
  `nama_pembeli` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_pembeli`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `pembeli` */

insert  into `pembeli`(`id_pembeli`,`nama_pembeli`) values 
('P012','Nova Istiqo'),
('P200','Novaaa Koma');

/*Table structure for table `transaksi` */

DROP TABLE IF EXISTS `transaksi`;

CREATE TABLE `transaksi` (
  `id_pembeli` varchar(5) DEFAULT NULL,
  `id_menu` varchar(5) DEFAULT NULL,
  `id_transaksi` varchar(10) DEFAULT NULL,
  KEY `id_menu` (`id_menu`),
  KEY `id_transaksi` (`id_transaksi`),
  KEY `id_pembeli` (`id_pembeli`),
  CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`id_menu`) REFERENCES `menu` (`id_menu`),
  CONSTRAINT `transaksi_ibfk_4` FOREIGN KEY (`id_pembeli`) REFERENCES `pembeli` (`id_pembeli`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `transaksi` */

insert  into `transaksi`(`id_pembeli`,`id_menu`,`id_transaksi`) values 
('P012','C012','TR500'),
('P012','C015','TR500'),
('P200','C800','TR300');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
