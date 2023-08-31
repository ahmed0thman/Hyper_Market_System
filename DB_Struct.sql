-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2020 at 12:48 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `market`
--
DROP DATABASE IF EXISTS `market`;
CREATE DATABASE IF NOT EXISTS `market` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `market`;

-- --------------------------------------------------------

--
-- Table structure for table `activities`
--

CREATE TABLE `activities` (
  `id` int(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `_date` datetime NOT NULL,
  `username` int(11) NOT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `id` int(11) NOT NULL,
  `id_in_day` int(11) NOT NULL,
  `_date` datetime NOT NULL,
  `item_total_number` int(11) NOT NULL,
  `person` int(11) NOT NULL,
  `employee` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `discount` int(11) NOT NULL DEFAULT 0,
  `totalPrice` decimal(10,2) NOT NULL,
  `paid` decimal(10,2) NOT NULL,
  `rest` decimal(10,2) NOT NULL,
  `type` varchar(20) NOT NULL,
  `profit` decimal(10,0) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `bill_info`
--

CREATE TABLE `bill_info` (
  `item` int(11) NOT NULL,
  `bill` int(11) NOT NULL,
  `unit` varchar(50) NOT NULL,
  `unit_price` decimal(10,2) NOT NULL,
  `num_total` decimal(10,2) NOT NULL,
  `total_price` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `emp_outgoings`
--

CREATE TABLE `emp_outgoings` (
  `id` int(11) NOT NULL,
  `employee` int(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `_date` date NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `alarm` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `code` varchar(50) NOT NULL,
  `name` varchar(100) NOT NULL,
  `menu` int(11) NOT NULL,
  `small_unit` varchar(100) NOT NULL,
  `big_unit` varchar(100) NOT NULL,
  `small_num_in_big` int(11) DEFAULT NULL,
  `small_unit_buy_price` varchar(50) NOT NULL,
  `small_unit_sell_price` varchar(50) NOT NULL,
  `big_unit_buy_price` varchar(50) NOT NULL,
  `big_unit_sell_price` varchar(50) NOT NULL,
  `limit_need` int(11) NOT NULL,
  `limit_alarm` varchar(10) NOT NULL,
  `is_expiring` varchar(10) NOT NULL DEFAULT 'لا',
  `exp_duration_alarm` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `machine`
--

CREATE TABLE `machine` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `balance` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `machine_archive`
--

CREATE TABLE `machine_archive` (
  `id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `_date` datetime NOT NULL,
  `machine` int(11) NOT NULL,
  `person` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `id` int(11) NOT NULL,
  `title` varchar(50) NOT NULL,
  `description` longtext DEFAULT NULL,
  `alarm_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `out_goings`
--

CREATE TABLE `out_goings` (
  `id` int(11) NOT NULL,
  `type` varchar(20) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `_date` date NOT NULL,
  `descripion` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE `person` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `phone2` varchar(20) DEFAULT NULL,
  `type` varchar(20) DEFAULT NULL,
  `debt` decimal(10,2) DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `shop`
--

CREATE TABLE `shop` (
  `item` int(11) NOT NULL,
  `qunatity` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `store`
--

CREATE TABLE `store` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `address` varchar(50) DEFAULT NULL,
  `employee` int(11) NOT NULL,
  `phone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `store_info`
--

CREATE TABLE `store_info` (
  `id` int(11) NOT NULL,
  `item` varchar(50) NOT NULL,
  `store` int(11) NOT NULL,
  `bill` int(11) DEFAULT NULL,
  `unit` varchar(50) NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `quantity` decimal(10,2) NOT NULL,
  `exp_date` varchar(20) DEFAULT NULL,
  `small_unit_buy_price` decimal(10,2) DEFAULT NULL,
  `small_unit_sell_price` decimal(10,2) DEFAULT NULL,
  `big_unit_buy_price` decimal(10,2) DEFAULT NULL,
  `big_unit_sell_price` decimal(10,2) DEFAULT NULL,
  `small_profit` decimal(10,0) NOT NULL,
  `big_profit` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `unit`
--

CREATE TABLE `unit` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `userpassword` varchar(50) DEFAULT NULL,
  `salary` int(11) DEFAULT NULL,
  `type` varchar(20) NOT NULL,
  `debt` decimal(10,0) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `walet`
--

CREATE TABLE `walet` (
  `amount` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activities`
--
ALTER TABLE `activities`
  ADD PRIMARY KEY (`id`),
  ADD KEY `activities_ibfk_1` (`username`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee` (`employee`),
  ADD KEY `person` (`person`);

--
-- Indexes for table `bill_info`
--
ALTER TABLE `bill_info`
  ADD KEY `bill` (`bill`),
  ADD KEY `item` (`item`);

--
-- Indexes for table `emp_outgoings`
--
ALTER TABLE `emp_outgoings`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee` (`employee`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`code`),
  ADD KEY `menu` (`menu`);

--
-- Indexes for table `machine`
--
ALTER TABLE `machine`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `machine_archive`
--
ALTER TABLE `machine_archive`
  ADD PRIMARY KEY (`id`),
  ADD KEY `machine` (`machine`),
  ADD KEY `person` (`person`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `out_goings`
--
ALTER TABLE `out_goings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shop`
--
ALTER TABLE `shop`
  ADD PRIMARY KEY (`item`);

--
-- Indexes for table `store`
--
ALTER TABLE `store`
  ADD PRIMARY KEY (`id`),
  ADD KEY `employee` (`employee`);

--
-- Indexes for table `store_info`
--
ALTER TABLE `store_info`
  ADD PRIMARY KEY (`id`),
  ADD KEY `bill` (`bill`),
  ADD KEY `store` (`store`),
  ADD KEY `store_info_ibfk_3` (`item`);

--
-- Indexes for table `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activities`
--
ALTER TABLE `activities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `emp_outgoings`
--
ALTER TABLE `emp_outgoings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `machine`
--
ALTER TABLE `machine`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `machine_archive`
--
ALTER TABLE `machine_archive`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `out_goings`
--
ALTER TABLE `out_goings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `store`
--
ALTER TABLE `store`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `store_info`
--
ALTER TABLE `store_info`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `unit`
--
ALTER TABLE `unit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `activities`
--
ALTER TABLE `activities`
  ADD CONSTRAINT `activities_ibfk_1` FOREIGN KEY (`username`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `bill`
--
ALTER TABLE `bill`
  ADD CONSTRAINT `bill_ibfk_1` FOREIGN KEY (`person`) REFERENCES `person` (`id`),
  ADD CONSTRAINT `bill_ibfk_2` FOREIGN KEY (`employee`) REFERENCES `users` (`id`);

--
-- Constraints for table `bill_info`
--
ALTER TABLE `bill_info`
  ADD CONSTRAINT `bill_info_ibfk_2` FOREIGN KEY (`bill`) REFERENCES `bill` (`id`),
  ADD CONSTRAINT `bill_info_ibfk_3` FOREIGN KEY (`item`) REFERENCES `store_info` (`id`);

--
-- Constraints for table `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `item_ibfk_1` FOREIGN KEY (`menu`) REFERENCES `menu` (`id`);

--
-- Constraints for table `machine_archive`
--
ALTER TABLE `machine_archive`
  ADD CONSTRAINT `machine_archive_ibfk_1` FOREIGN KEY (`machine`) REFERENCES `machine` (`id`),
  ADD CONSTRAINT `machine_archive_ibfk_2` FOREIGN KEY (`person`) REFERENCES `person` (`id`);

--
-- Constraints for table `shop`
--
ALTER TABLE `shop`
  ADD CONSTRAINT `shop_ibfk_1` FOREIGN KEY (`item`) REFERENCES `store_info` (`id`);

--
-- Constraints for table `store`
--
ALTER TABLE `store`
  ADD CONSTRAINT `store_ibfk_1` FOREIGN KEY (`employee`) REFERENCES `users` (`id`);

--
-- Constraints for table `store_info`
--
ALTER TABLE `store_info`
  ADD CONSTRAINT `store_info_ibfk_3` FOREIGN KEY (`item`) REFERENCES `item` (`code`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `store_info_ibfk_4` FOREIGN KEY (`bill`) REFERENCES `bill` (`id`),
  ADD CONSTRAINT `store_info_ibfk_5` FOREIGN KEY (`store`) REFERENCES `store` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
