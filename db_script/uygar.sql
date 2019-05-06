-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 06 May 2019, 10:20:21
-- Sunucu sürümü: 10.1.38-MariaDB
-- PHP Sürümü: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `uygar`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bill`
--

CREATE TABLE `bill` (
  `id` int(11) NOT NULL,
  `companyName` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `price` double NOT NULL,
  `customerName` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `customerPhoneNumber` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `point` double NOT NULL,
  `type` varchar(20) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `campaign`
--

CREATE TABLE `campaign` (
  `TravelCompany_name` varchar(128) COLLATE utf8_turkish_ci NOT NULL,
  `originCity` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `destinationCity` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `date` date NOT NULL,
  `estimatedTimeOfArrival` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `capacity` int(11) NOT NULL,
  `price` double NOT NULL,
  `campaignID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `campaign`
--

INSERT INTO `campaign` (`TravelCompany_name`, `originCity`, `destinationCity`, `date`, `estimatedTimeOfArrival`, `capacity`, `price`, `campaignID`) VALUES
('Metro', 'Adana', 'Sivas', '2019-11-13', '20', 113, 133, 1),
('Metro', 'Balikesir', 'Manisa', '2020-03-28', '5', 75, 276, 2),
('Uçan Türk özel havayolu', 'Erzurum', 'Istanbul', '2019-11-19', '4', 129, 114, 3),
('Uçan Türk özel havayolu', 'Istanbul', 'Manisa', '2019-05-25', '8', 134, 209, 4),
('YTUR', 'Kahramanmaras', 'Manisa', '2019-12-27', '18', 144, 175, 5),
('Uçan Türk özel havayolu', 'Osmaniye', 'Ankara', '2019-09-27', '10', 78, 185, 6),
('Metro', 'Konya', 'Bursa', '2020-03-19', '1', 139, 244, 7),
('Devlet Demir Yolları', 'Konya', 'Denizli', '2020-02-13', '9', 76, 128, 8),
('YTUR', 'Trabzon', 'Bursa', '2019-10-09', '11', 133, 213, 9),
('Metro', 'Antakya', 'Sivas', '2019-12-22', '17', 150, 204, 10),
('Devlet Demir Yolları', 'Osmaniye', 'Diyarbakir', '2019-06-23', '12', 108, 226, 11),
('Uçan Türk özel havayolu', 'Antakya', 'Bursa', '2020-02-14', '20', 131, 133, 12),
('Uçan Türk özel havayolu', 'Sivas', 'Osmaniye', '2019-06-29', '0', 134, 131, 13),
('Uçan Türk özel havayolu', 'Osmaniye', 'Bursa', '2019-10-29', '17', 108, 167, 14),
('Devlet Demir Yolları', 'Batman', 'Ankara', '2019-11-24', '7', 116, 152, 15),
('Uçan Türk özel havayolu', 'Gebze', 'Erzurum', '2020-05-02', '11', 50, 101, 16),
('Metro', 'Manisa', 'Istanbul', '2019-08-27', '9', 135, 115, 17),
('YTUR', 'Diyarbakir', 'Diyarbakir', '2019-10-26', '0', 145, 241, 18),
('YTUR', 'Sivas', 'Batman', '2019-09-08', '14', 135, 266, 19),
('Uçan Türk özel havayolu', 'Adiyaman', 'Kahramanmaras', '2019-07-14', '4', 54, 169, 20),
('Uçan Türk özel havayolu', 'Kayseri', 'Antakya', '2020-01-22', '0', 96, 220, 21),
('Metro', 'Samsun', 'Ankara', '2019-05-08', '3', 111, 148, 22),
('Uçan Türk özel havayolu', 'Konya', 'Ankara', '2019-05-23', '4', 145, 123, 23),
('Uçan Türk özel havayolu', 'Ankara', 'Kayseri', '2020-04-14', '23', 103, 257, 24),
('Devlet Demir Yolları', 'Bursa', 'Mersin', '2020-02-10', '4', 148, 191, 25),
('Uçan Türk özel havayolu', 'Mersin', 'Bursa', '2019-09-19', '1', 64, 101, 26),
('Metro', 'Ankara', 'Konya', '2020-02-20', '9', 66, 258, 27),
('YTUR', 'Kahramanmaras', 'Trabzon', '2019-07-15', '19', 89, 300, 28),
('Devlet Demir Yolları', 'Ankara', 'Sivas', '2020-04-06', '3', 68, 206, 29),
('Uçan Türk özel havayolu', 'Trabzon', 'Trabzon', '2019-05-16', '9', 94, 291, 30),
('Devlet Demir Yolları', 'Mersin', 'Osmaniye', '2019-11-08', '18', 142, 132, 31),
('Uçan Türk özel havayolu', 'Diyarbakir', 'Sivas', '2019-12-07', '21', 95, 207, 32),
('Devlet Demir Yolları', 'Diyarbakir', 'Elazig', '2019-12-26', '17', 111, 241, 33),
('Uçan Türk özel havayolu', 'Osmaniye', 'Sivas', '2019-10-07', '17', 66, 174, 34),
('Uçan Türk özel havayolu', 'Osmaniye', 'Kirikkale', '2019-07-22', '19', 116, 286, 35),
('Uçan Türk özel havayolu', 'Erzurum', 'Denizli', '2019-08-17', '6', 51, 112, 36),
('Metro', 'Elazig', 'Sivas', '2019-05-29', '3', 78, 191, 37),
('YTUR', 'Kayseri', 'Erzurum', '2019-12-04', '9', 141, 238, 38),
('Metro', 'Ankara', 'Denizli', '2019-05-24', '16', 108, 137, 39),
('YTUR', 'Antalya', 'Istanbul', '2019-08-01', '8', 136, 192, 40),
('Metro', 'Denizli', 'Adiyaman', '2019-05-22', '5', 140, 300, 41),
('Devlet Demir Yolları', 'Osmaniye', 'Kirikkale', '2020-01-09', '10', 102, 233, 42),
('Uçan Türk özel havayolu', 'Cankaya', 'Sanliurfa', '2019-10-16', '12', 90, 208, 43),
('Uçan Türk özel havayolu', 'Diyarbakir', 'Cankaya', '2019-11-06', '15', 71, 245, 44),
('YTUR', 'Izmir', 'Denizli', '2019-08-28', '4', 144, 213, 45),
('Metro', 'Diyarbakir', 'Gebze', '2019-11-26', '6', 57, 247, 46),
('Devlet Demir Yolları', 'Mersin', 'Bursa', '2019-10-23', '5', 60, 175, 47),
('Uçan Türk özel havayolu', 'Batman', 'Ankara', '2020-04-14', '3', 125, 263, 48),
('YTUR', 'Izmir', 'Malatya', '2020-02-03', '14', 72, 271, 49),
('Uçan Türk özel havayolu', 'Trabzon', 'Samsun', '2019-10-03', '20', 76, 199, 50),
('YTUR', 'Balikesir', 'Konya', '2019-08-17', '22', 147, 225, 51),
('Uçan Türk özel havayolu', 'Kahramanmaras', 'Konya', '2019-10-12', '18', 98, 170, 52),
('Metro', 'Kirikkale', 'Elazig', '2020-01-04', '13', 106, 236, 53),
('YTUR', 'Balikesir', 'Antakya', '2019-12-29', '8', 132, 236, 54),
('Metro', 'Batman', 'Antalya', '2019-10-26', '6', 95, 291, 55),
('Metro', 'Batman', 'Istanbul', '2020-01-28', '18', 54, 250, 56),
('Metro', 'Konya', 'Gaziantep', '2019-11-04', '0', 131, 191, 57),
('Metro', 'Kirikkale', 'Eskisehir', '2019-05-20', '22', 126, 283, 58),
('Devlet Demir Yolları', 'Ankara', 'Kayseri', '2019-05-31', '12', 82, 107, 59),
('Metro', 'Manisa', 'Adiyaman', '2019-12-14', '6', 146, 164, 60),
('Metro', 'Kayseri', 'Konya', '2020-02-26', '4', 99, 157, 61),
('YTUR', 'Antalya', 'Eskisehir', '2019-12-08', '20', 137, 200, 62),
('Devlet Demir Yolları', 'Elazig', 'Osmaniye', '2019-06-27', '23', 108, 114, 63),
('Metro', 'Mersin', 'Erzurum', '2020-01-28', '21', 88, 143, 64),
('Uçan Türk özel havayolu', 'Sanliurfa', 'Sanliurfa', '2019-07-10', '7', 145, 266, 65),
('Devlet Demir Yolları', 'Batman', 'Izmir', '2019-05-14', '21', 127, 166, 66),
('Metro', 'Konya', 'Erzurum', '2020-02-16', '7', 146, 184, 67),
('Devlet Demir Yolları', 'Batman', 'Bursa', '2019-05-13', '13', 122, 282, 68),
('Devlet Demir Yolları', 'Adiyaman', 'Denizli', '2019-10-12', '0', 127, 170, 69),
('Uçan Türk özel havayolu', 'Antalya', 'Elazig', '2019-10-15', '4', 67, 236, 70),
('Metro', 'Izmir', 'Sanliurfa', '2020-02-27', '14', 147, 197, 71),
('YTUR', 'Konya', 'Cankaya', '2019-09-02', '11', 64, 103, 72),
('Metro', 'Elazig', 'Sanliurfa', '2019-11-22', '14', 66, 167, 73),
('Metro', 'Elazig', 'Sivas', '2020-03-18', '9', 143, 179, 74),
('Metro', 'Van', 'Cankaya', '2020-04-08', '11', 111, 244, 75),
('YTUR', 'Malatya', 'Adana', '2019-07-14', '17', 76, 111, 76),
('Devlet Demir Yolları', 'Gebze', 'Gaziantep', '2020-03-19', '14', 147, 282, 77),
('Uçan Türk özel havayolu', 'Kahramanmaras', 'Kahramanmaras', '2020-03-24', '18', 149, 225, 78),
('Devlet Demir Yolları', 'Bursa', 'Gaziantep', '2019-07-24', '20', 104, 131, 79),
('Devlet Demir Yolları', 'Denizli', 'Kahramanmaras', '2020-03-26', '19', 93, 126, 80),
('Metro', 'Samsun', 'Cankaya', '2020-02-11', '22', 139, 216, 81),
('Metro', 'Batman', 'Sivas', '2019-11-06', '16', 91, 159, 82),
('YTUR', 'Gaziantep', 'Konya', '2019-07-18', '4', 86, 284, 83),
('Metro', 'Denizli', 'Samsun', '2020-05-06', '14', 137, 200, 84),
('Metro', 'Batman', 'Ankara', '2020-01-25', '12', 62, 183, 85),
('Metro', 'Malatya', 'Adana', '2020-04-18', '7', 148, 158, 86),
('Devlet Demir Yolları', 'Balikesir', 'Samsun', '2019-12-10', '21', 75, 130, 87),
('YTUR', 'Bursa', 'Malatya', '2019-11-15', '1', 85, 201, 88),
('Devlet Demir Yolları', 'Elazig', 'Antakya', '2019-10-22', '13', 120, 196, 89),
('Devlet Demir Yolları', 'Denizli', 'Istanbul', '2019-07-13', '19', 50, 221, 90),
('Uçan Türk özel havayolu', 'Istanbul', 'Sanliurfa', '2019-05-13', '20', 122, 250, 91),
('Metro', 'Bursa', 'Elazig', '2019-08-13', '5', 96, 290, 92),
('Uçan Türk özel havayolu', 'Cankaya', 'Van', '2019-09-02', '15', 107, 229, 93),
('YTUR', 'Izmir', 'Bursa', '2019-10-07', '19', 61, 235, 94),
('YTUR', 'Sivas', 'Adiyaman', '2020-02-02', '19', 101, 183, 95),
('Devlet Demir Yolları', 'Van', 'Sanliurfa', '2020-01-15', '0', 100, 197, 96),
('Devlet Demir Yolları', 'Manisa', 'Malatya', '2020-02-12', '3', 91, 177, 97),
('Devlet Demir Yolları', 'Antalya', 'Van', '2019-08-04', '5', 97, 265, 98),
('Metro', 'Sivas', 'Balikesir', '2019-09-03', '21', 51, 205, 99),
('Uçan Türk özel havayolu', 'Sivas', 'Manisa', '2020-04-26', '1', 60, 119, 100);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hotel`
--

CREATE TABLE `hotel` (
  `id` int(11) NOT NULL,
  `name` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `pointCoefficent` double NOT NULL,
  `email` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `roomNo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hotelreservation`
--

CREATE TABLE `hotelreservation` (
  `id` int(11) NOT NULL,
  `Hotel_id` int(11) NOT NULL,
  `startDate` date NOT NULL,
  `finishDate` date NOT NULL,
  `price` double NOT NULL,
  `Bill_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci COMMENT='e.g. card, cash, paypal, wire transfer';

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `location`
--

CREATE TABLE `location` (
  `Hotel_id` int(11) NOT NULL,
  `city` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `locationID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `session`
--

CREATE TABLE `session` (
  `id` int(11) NOT NULL,
  `isActive` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `session`
--

INSERT INTO `session` (`id`, `isActive`) VALUES
(0, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `transportationservice`
--

CREATE TABLE `transportationservice` (
  `Bill_id` int(11) NOT NULL,
  `Campaign_campaignID` int(11) NOT NULL,
  `transportationID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `travelcompany`
--

CREATE TABLE `travelcompany` (
  `name` varchar(128) COLLATE utf8_turkish_ci NOT NULL,
  `pointCoefficient` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `travelcompany`
--

INSERT INTO `travelcompany` (`name`, `pointCoefficient`) VALUES
('Devlet Demir Yolları', 1),
('Uçan Türk özel havayolu', 1),
('Metro', 1),
('YTUR', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uuser`
--

CREATE TABLE `uuser` (
  `userName` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `password` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `type` varchar(10) COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `uuser`
--

INSERT INTO `uuser` (`userName`, `password`, `type`) VALUES
('ag', 'ag', 'AG'),
('uygar', 'uygar', 'YSP');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `campaign`
--
ALTER TABLE `campaign`
  ADD PRIMARY KEY (`campaignID`);

--
-- Tablo için indeksler `hotel`
--
ALTER TABLE `hotel`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `hotelreservation`
--
ALTER TABLE `hotelreservation`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `location`
--
ALTER TABLE `location`
  ADD PRIMARY KEY (`locationID`);

--
-- Tablo için indeksler `session`
--
ALTER TABLE `session`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `transportationservice`
--
ALTER TABLE `transportationservice`
  ADD PRIMARY KEY (`transportationID`);

--
-- Tablo için indeksler `travelcompany`
--
ALTER TABLE `travelcompany`
  ADD PRIMARY KEY (`name`);

--
-- Tablo için indeksler `uuser`
--
ALTER TABLE `uuser`
  ADD PRIMARY KEY (`userName`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `bill`
--
ALTER TABLE `bill`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hotel`
--
ALTER TABLE `hotel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `hotelreservation`
--
ALTER TABLE `hotelreservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
