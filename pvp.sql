-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2022 at 12:53 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pvp`
--

-- --------------------------------------------------------

--
-- Table structure for table `devices`
--

CREATE TABLE `devices` (
  `fk_user` int(11) NOT NULL,
  `is_on` tinyint(1) NOT NULL,
  `is_realtime` tinyint(1) NOT NULL,
  `setup_string` varchar(50) CHARACTER SET utf8 NOT NULL,
  `id` int(11) NOT NULL,
  `treshold` int(11) DEFAULT NULL,
  `tag` varchar(50) CHARACTER SET utf8 DEFAULT NULL,
  `tariff` decimal(11,4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `devices`
--

INSERT INTO `devices` (`fk_user`, `is_on`, `is_realtime`, `setup_string`, `id`, `treshold`, `tag`, `tariff`) VALUES
(13, 1, 0, 'OwCn0qs8IK', 1, 3111, 'Vonia', '0.3400'),
(13, 1, 1, '4uPJgx4Exa', 2, 6000, 'Garažas', '0.0000');

-- --------------------------------------------------------

--
-- Table structure for table `infos`
--

CREATE TABLE `infos` (
  `id` int(11) NOT NULL,
  `fk_device_id` int(11) NOT NULL,
  `date_time` datetime NOT NULL,
  `wattage` decimal(11,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `infos`
--

INSERT INTO `infos` (`id`, `fk_device_id`, `date_time`, `wattage`) VALUES
(1, 1, '2022-02-27 14:28:00', '420.00'),
(2, 1, '2022-02-27 14:28:21', '421.00'),
(3, 1, '2022-02-27 14:29:52', '423.00'),
(9, 1, '2022-04-22 17:10:34', '543.00'),
(10, 1, '2022-04-21 17:10:20', '1001.00'),
(13, 1, '2022-04-20 17:10:08', '422.00'),
(14, 1, '2022-04-19 16:33:48', '1111.00'),
(15, 1, '2022-04-18 16:33:53', '200.00'),
(16, 1, '2022-04-17 16:33:54', '454.00'),
(17, 1, '2022-04-16 16:33:55', '423.00'),
(18, 1, '2022-04-15 16:33:56', '2344.00'),
(19, 1, '2022-04-14 16:33:57', '1456.00'),
(20, 1, '2022-04-13 16:33:58', '998.00'),
(21, 1, '2022-04-12 16:33:59', '235.00'),
(22, 1, '2022-04-11 16:34:01', '432.00'),
(23, 1, '2022-04-10 16:34:02', '233.00'),
(24, 1, '2022-04-10 16:34:02', '845.00'),
(25, 1, '2022-04-09 16:34:03', '765.00'),
(26, 1, '2022-04-08 16:34:03', '1166.00'),
(27, 1, '2022-04-08 16:34:04', '3411.00'),
(28, 1, '2022-04-07 16:34:04', '6544.00'),
(29, 1, '2022-04-06 16:34:05', '4356.00'),
(30, 1, '2022-04-05 16:34:06', '6222.00'),
(31, 1, '2022-04-04 16:34:06', '8766.00'),
(32, 1, '2022-04-03 16:34:07', '4334.00'),
(33, 1, '2022-04-02 16:34:07', '5435.00'),
(34, 1, '2022-04-01 16:34:08', '6544.00'),
(35, 1, '2022-03-22 16:34:08', '7567.00'),
(36, 1, '2022-03-23 16:34:09', '4234.00'),
(37, 1, '2022-03-24 16:34:09', '3123.00'),
(38, 1, '2022-03-25 16:34:10', '6126.00'),
(39, 1, '2022-03-26 16:34:10', '6321.00'),
(40, 1, '2022-03-27 16:34:11', '1233.00'),
(41, 1, '2022-03-28 16:34:11', '3212.00'),
(42, 1, '2022-03-29 16:34:12', '5435.00'),
(43, 1, '2022-03-30 16:34:12', '3211.00'),
(84, 1, '2022-05-02 20:58:17', '3.55'),
(85, 1, '2022-05-02 20:59:01', '3.56'),
(86, 1, '2022-05-03 00:27:48', '55.12');

-- --------------------------------------------------------

--
-- Table structure for table `manufactureddevices`
--

CREATE TABLE `manufactureddevices` (
  `id` int(11) NOT NULL,
  `setupString` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `manufactureddevices`
--

INSERT INTO `manufactureddevices` (`id`, `setupString`) VALUES
(1, 'OwCn0qs8IK'),
(2, '4uPJgx4Exa'),
(3, 'ezpm7phFO9'),
(4, 'hkOHSxqqa6');

-- --------------------------------------------------------

--
-- Table structure for table `realtimeinfos`
--

CREATE TABLE `realtimeinfos` (
  `id` int(11) NOT NULL,
  `fk_device_id` int(11) NOT NULL,
  `wattage` decimal(11,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `realtimeinfos`
--

INSERT INTO `realtimeinfos` (`id`, `fk_device_id`, `wattage`) VALUES
(1, 1, '55'),
(2, 2, '2009');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `mail` varchar(50) CHARACTER SET utf8 NOT NULL,
  `pass_hash` varchar(150) CHARACTER SET utf8 NOT NULL,
  `created` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `mail`, `pass_hash`, `created`) VALUES
(13, 'mangirdas@mail.com', '$2a$11$1mJ5FSIFdHcPFNIB15nUEebQbao.ccvAaNvehCbZHW./nQ15UjED.', '2022-03-09 22:02:28');

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20220326153045_DBInit', '5.0.15'),
('20220326194207_Migration1', '5.0.15'),
('20220327102919_DBFull', '5.0.15'),
('20220327103138_DBFullHotfix', '5.0.15'),
('20220327111807_DBFullHotfix2', '5.0.15');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `devices`
--
ALTER TABLE `devices`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_user` (`fk_user`);

--
-- Indexes for table `infos`
--
ALTER TABLE `infos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_device_id` (`fk_device_id`);

--
-- Indexes for table `manufactureddevices`
--
ALTER TABLE `manufactureddevices`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `realtimeinfos`
--
ALTER TABLE `realtimeinfos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_device_id` (`fk_device_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `mail` (`mail`),
  ADD KEY `Email` (`mail`),
  ADD KEY `Pass_hash` (`pass_hash`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `devices`
--
ALTER TABLE `devices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `infos`
--
ALTER TABLE `infos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT for table `manufactureddevices`
--
ALTER TABLE `manufactureddevices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `realtimeinfos`
--
ALTER TABLE `realtimeinfos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `devices`
--
ALTER TABLE `devices`
  ADD CONSTRAINT `has` FOREIGN KEY (`fk_user`) REFERENCES `users` (`id`);

--
-- Constraints for table `infos`
--
ALTER TABLE `infos`
  ADD CONSTRAINT `shows` FOREIGN KEY (`fk_device_id`) REFERENCES `devices` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
