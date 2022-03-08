CREATE TABLE IF NOT EXISTS `product` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `unit_of_measurement` varchar(80) NOT NULL,
  `liter` varchar(6) NOT NULL,
  `weigth` varchar(6) NOT NULL,
  `price` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) 