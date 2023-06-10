-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 05, 2023 at 09:13 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `prj_car`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(32) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('Admin', '12345'),
('Arihantjain', 'Admin'),
('admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `car_id` int(11) NOT NULL,
  `car_name` varchar(50) NOT NULL,
  `car_no` varchar(32) NOT NULL,
  `color` varchar(12) NOT NULL,
  `rent` int(11) NOT NULL,
  `status` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `car`
--

INSERT INTO `car` (`car_id`, `car_name`, `car_no`, `color`, `rent`, `status`) VALUES
(101, 'Mahindra Thar', '7RPC156', 'Galaxy Grey', 15000, 'Available'),
(102, 'Toyota Innova', '8PUV845', 'Silver', 5000, 'Available'),
(103, 'Maruti', 'JK2376', 'White', 3000, 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `cust`
--

CREATE TABLE `cust` (
  `cust_id` varchar(16) NOT NULL,
  `cust_name` varchar(32) NOT NULL,
  `age` int(11) NOT NULL,
  `ph_no` bigint(20) NOT NULL,
  `addr` varchar(100) NOT NULL,
  `cfn` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cust`
--

INSERT INTO `cust` (`cust_id`, `cust_name`, `age`, `ph_no`, `addr`, `cfn`) VALUES
('A1001', 'Ajay Nagar', 28, 9985674265, 'Borkheda , Kota', 586),
('A1002', 'Ayush Gupta', 26, 9845654655, 'Station,Kota', 587);

-- --------------------------------------------------------

--
-- Table structure for table `rent`
--

CREATE TABLE `rent` (
  `car_id` int(11) NOT NULL,
  `car_name` varchar(50) NOT NULL,
  `cust_id` varchar(16) NOT NULL,
  `cust_name` varchar(32) NOT NULL,
  `rent` int(11) NOT NULL,
  `no_days` int(11) NOT NULL,
  `hired_till` datetime NOT NULL,
  `ph_no` bigint(20) NOT NULL,
  `totalrent` int(11) NOT NULL,
  `cfn` int(11) NOT NULL,
  `status` varchar(16) NOT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rent`
--

INSERT INTO `rent` (`car_id`, `car_name`, `cust_id`, `cust_name`, `rent`, `no_days`, `hired_till`, `ph_no`, `totalrent`, `cfn`, `status`, `date`) VALUES
(101, 'Mahindra Thar', 'A1001', 'Ajay Nagar', 15000, 2, '2023-05-07 01:01:03', 9985674265, 30000, 586, '', '2023-05-05 01:01:22'),
(102, 'Toyota Innova', 'A1002', 'Ayush Gupta', 5000, 2, '2023-05-08 00:37:43', 9845654655, 10000, 587, 'Busy', '2023-05-06 00:38:03');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`car_id`);

--
-- Indexes for table `cust`
--
ALTER TABLE `cust`
  ADD PRIMARY KEY (`cust_id`);

--
-- Indexes for table `rent`
--
ALTER TABLE `rent`
  ADD KEY `rent_ibfk_1` (`car_id`),
  ADD KEY `rent_ibfk_2` (`cust_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `car`
--
ALTER TABLE `car`
  MODIFY `car_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=106;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rent`
--
ALTER TABLE `rent`
  ADD CONSTRAINT `rent_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `car` (`car_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `rent_ibfk_2` FOREIGN KEY (`cust_id`) REFERENCES `cust` (`cust_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
