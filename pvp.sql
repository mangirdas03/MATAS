-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 25, 2022 at 09:31 PM
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
  `tag` varchar(50) CHARACTER SET utf8 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `devices`
--

INSERT INTO `devices` (`fk_user`, `is_on`, `is_realtime`, `setup_string`, `id`, `treshold`, `tag`) VALUES
(13, 1, 0, 'qwerty', 1, 3000, 'Vonia'),
(13, 1, 1, 'qwertyu', 2, 6000, 'aaa'),
(52, 1, 0, 'asdfg', 11, 543, '313'),
(13, 1, 0, 'zxcvbnm', 12, NULL, '');

-- --------------------------------------------------------

--
-- Table structure for table `infos`
--

CREATE TABLE `infos` (
  `id` int(11) NOT NULL,
  `fk_device_id` int(11) NOT NULL,
  `date_time` datetime NOT NULL,
  `wattage` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `infos`
--

INSERT INTO `infos` (`id`, `fk_device_id`, `date_time`, `wattage`) VALUES
(1, 1, '2022-02-27 14:28:00', 420),
(2, 1, '2022-02-27 14:28:21', 421),
(3, 1, '2022-02-27 14:29:52', 423),
(9, 1, '2022-04-22 17:10:34', 543),
(10, 1, '2022-04-21 17:10:20', 1001),
(13, 1, '2022-04-20 17:10:08', 422),
(14, 1, '2022-04-19 16:33:48', 1111),
(15, 1, '2022-04-18 16:33:53', 200),
(16, 1, '2022-04-17 16:33:54', 454),
(17, 1, '2022-04-16 16:33:55', 423),
(18, 1, '2022-04-15 16:33:56', 2344),
(19, 1, '2022-04-14 16:33:57', 1456),
(20, 1, '2022-04-13 16:33:58', 998),
(21, 1, '2022-04-12 16:33:59', 235),
(22, 1, '2022-04-11 16:34:01', 432),
(23, 1, '2022-04-10 16:34:02', 233),
(24, 1, '2022-04-10 16:34:02', 845),
(25, 1, '2022-04-09 16:34:03', 765),
(26, 1, '2022-04-08 16:34:03', 1166),
(27, 1, '2022-04-08 16:34:04', 3411),
(28, 1, '2022-04-07 16:34:04', 6544),
(29, 1, '2022-04-06 16:34:05', 4356),
(30, 1, '2022-04-05 16:34:06', 6222),
(31, 1, '2022-04-04 16:34:06', 8766),
(32, 1, '2022-04-03 16:34:07', 4334),
(33, 1, '2022-04-02 16:34:07', 5435),
(34, 1, '2022-04-01 16:34:08', 6544),
(35, 1, '2022-03-22 16:34:08', 7567),
(36, 1, '2022-03-23 16:34:09', 4234),
(37, 1, '2022-03-24 16:34:09', 3123),
(38, 1, '2022-03-25 16:34:10', 6126),
(39, 1, '2022-03-26 16:34:10', 6321),
(40, 1, '2022-03-27 16:34:11', 1233),
(41, 1, '2022-03-28 16:34:11', 3212),
(42, 1, '2022-03-29 16:34:12', 5435),
(43, 1, '2022-03-30 16:34:12', 3211);

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
(1, 'qwerty'),
(2, 'qwertyu'),
(3, 'zxcvbnm'),
(4, 'asdfg');

-- --------------------------------------------------------

--
-- Table structure for table `realtimeinfos`
--

CREATE TABLE `realtimeinfos` (
  `id` int(11) NOT NULL,
  `fk_device_id` int(11) NOT NULL,
  `wattage` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `realtimeinfos`
--

INSERT INTO `realtimeinfos` (`id`, `fk_device_id`, `wattage`) VALUES
(1, 1, 1020),
(2, 2, 2009),
(8, 11, 0),
(9, 12, 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `mail` varchar(50) CHARACTER SET utf8 NOT NULL,
  `pass_hash` varchar(150) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `mail`, `pass_hash`) VALUES
(7, 'test@test.com', '$2a$11$py8GV0vKRXhMOfzeDJJKZeRG5CFSlBvXX44r8X2s2DjQM4/bmFjFG'),
(13, 'testas@test.com', '$2a$11$bA1jcVOw0XElYbKAsYhy.OjMCTIpY9yhMySd3s7sGymWCCUmDej9i'),
(52, 'gilbertas@hotmail.com', '$2a$11$FQFO4cxFfFYCi6W2iqTZDuAhr5JPvjkNZg6NsdBH7TXz92CLYOaA.');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `infos`
--
ALTER TABLE `infos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- AUTO_INCREMENT for table `manufactureddevices`
--
ALTER TABLE `manufactureddevices`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `realtimeinfos`
--
ALTER TABLE `realtimeinfos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

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
