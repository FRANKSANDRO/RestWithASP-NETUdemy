﻿CREATE TABLE `persons` (
`Id` int(10) UNSIGNED NULL DEFAULT NULL,
`FirstName` VARCHAR(50) NULL DEFAULT NULL,
`LastName` VARCHAR(50) NULL DEFAULT NULL,
`Address` VARCHAR(50) NULL DEFAULT NULL,
`Gender` VARCHAR(50) NULL DEFAULT NULL
)
ENGINE=InnoDB
;

ALTER TABLE `persons` CHANGE COLUMN `Id` `Id` INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY;