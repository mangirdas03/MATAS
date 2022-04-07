-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 07, 2022 at 08:37 PM
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
(13, 1, 0, 'qwerty', 1, NULL, NULL);

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
(1, 1, '2022-03-27 14:28:00', 420),
(2, 1, '2022-03-27 14:28:21', 421),
(3, 1, '2022-03-27 14:29:52', 423),
(4, 1, '2022-03-29 23:03:25', 701);

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
(1, 1, 78);

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
(13, 'testas@test.com', '$2a$11$bA1jcVOw0XElYbKAsYhy.OjMCTIpY9yhMySd3s7sGymWCCUmDej9i');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `infos`
--
ALTER TABLE `infos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `realtimeinfos`
--
ALTER TABLE `realtimeinfos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

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
