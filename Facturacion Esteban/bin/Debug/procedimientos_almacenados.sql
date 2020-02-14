/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.7.18-log : Database - bdferia
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bdferia` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `bdferia`;

/* Procedure structure for procedure `DEL_ART` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_ART` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_ART`(
    in p_id varchar(20)
    )
BEGIN
	
	UPDATE `tb_articulo`
	SET `Art_IsActive` = 0
	WHERE `Art_Id` = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_ART_COT` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_ART_COT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_ART_COT`(
	in p_auto int
	
    )
BEGIN
	
	DELETE 
	from `tb_cot_detalle`
	where CDet_fnum = p_auto;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_ART_FACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_ART_FACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_ART_FACT`(
	in p_auto int
	
    )
BEGIN
	
	DELETE 
	from tb_fact_detalle
	where FDet_fnum = p_auto;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_CLI` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_CLI` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_CLI`(
    in p_id varchar(20)
    )
BEGIN
	
	UPDATE `tb_cliente`
	SET `Cli_IsActive` = 0
	WHERE `Cli_Id` = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_COT` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_COT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_COT`(in p_id int)
BEGIN
  UPDATE 
    `tb_cotizacion` 
  SET
    `Cot_IsActive` = 0 
  WHERE `Cot_auto` = p_id ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_FACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_FACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_FACT`(
    in p_id int
    )
BEGIN
	
	UPDATE `tb_factura`
	SET `Fact_IsActive` = 0
	WHERE `Fact_auto` = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `DEL_TEMP` */

/*!50003 DROP PROCEDURE IF EXISTS  `DEL_TEMP` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `DEL_TEMP`(
	
	
    )
BEGIN
	
	DELETE 
	from `tb_temp`;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_ARTICULO` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_ARTICULO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_ARTICULO`(
  IN p_id varchar (20),
  in p_nombre varchar (50),
  in p_pre1 float,
  in p_pre2 float,
  in p_pre3 float,
  in p_pre4 float,
  In p_tipo varchar (100),
  IN p_imp bit,
  in p_costo Float,
  in p_barcode varchAR(50)
)
BEGIN
  insert into Tb_Articulo (
    `Art_Id`,
    `Art_Nombre`,
    `Art_Pre1`,
    `Art_Pre2`,
    `Art_Pre3`,
    `Art_Pre4`,
    `Art_Tipo`,
    `Art_Costo`,
    `Art_Imp`,
    `Art_barcode`
  ) 
  VALUES
    (
      p_id,
      p_nombre,
      p_pre1,
      p_pre2,
      p_pre3,
      p_pre4,
      p_tipo,
      p_costo,
      p_imp,
      p_barcode
    ) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_CAMBIO_FACTURA` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_CAMBIO_FACTURA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_CAMBIO_FACTURA`(
	IN p_num int, 
	in p_cli int, 
	in p_ven int, 
	in p_fecha datetime,
	in p_sub float,
	in p_desc float,
	in p_total float,
	in p_pago float,
	in p_imp float,
	in p_com1 varchar(255),
	in p_com2 varchar(255),
	in p_leyenda varchar(255),
	in p_open bit,
	IN p_cambio int,
	in p_fact_id int
    )
BEGIN
	insert into `tb_cambios_factura`(
	
		Fact_Num, `Fact_Cli`, Fact_Vend, Fact_Fecha, Fact_SubT, Fact_Descuent, 
		Fact_Total,Fact_Pago, `Fact_Imp`, `Fact_Clicom1`, `Fact_Clicom2`, 
		`Fact_Leyenda`, Fact_IsOpen, `Fact_Cambio`, `Fact_id_origen`
	)
	values
	(
	   p_num, p_cli, p_ven, p_fecha, p_sub, p_desc, p_total, p_pago, p_imp,
	   p_com1, p_com2, p_leyenda, p_open, p_cambio, p_fact_id
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_CAMBIO_FACT_DETALLE` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_CAMBIO_FACT_DETALLE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_CAMBIO_FACT_DETALLE`(
  IN p_fac_id int,
  in p_art_id int,
  in p_precio float,
  in p_imp float,
  in p_sub float,
  in p_cant float,
  in p_fecha datetime
)
BEGIN
  insert into `tb_cambios_fact_detalle` (
    `FDet_fnum`,
    `FDet_artId`,
    `FDet_artPre`,
    `FDet_Imp`,
    `FDet_sub`,
    `FDet_Cant`,
    `FDet_fecha`
  ) 
  values
    (
      p_fac_id,
      p_art_id,
      p_precio,
      p_imp,
      p_sub,
      p_cant,
      p_fecha
    ) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_CLIENTE` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_CLIENTE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_CLIENTE`(
  IN p_id varchar (20),
  in p_nombre varchar (100),
  in p_direc varchar (80),
  in p_tel varchar (15),
  in p_adv varchar (250),
  in p_printer boolean,
  IN p_vendedor int
)
BEGIN
  insert into Tb_Cliente (
    `Cli_Id`,
    `Cli_Nombre`,
    `Cli_Direccion`,
    `Cli_Telefono`,
    `Cli_Advertencia`,
    `Cli_tipo_impresion`,
    `Cli_Id_Vendedor`
  ) 
  values
    (
      p_id,
      p_nombre,
      p_direc,
      p_tel,
      p_adv,
      p_printer,
      p_vendedor
    ) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_COTIZACION` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_COTIZACION` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_COTIZACION`(
	IN p_num int, 
	in p_cli int, 
	in p_ven int, 
	in p_fecha datetime,
	in p_sub float,
	in p_desc float,
	in p_total float,
	In p_imp float,
	in p_com1 varchar(255),
	in p_com2 varchar(255),
	in p_leyenda varchar(255)
	
	
    )
BEGIN
	insert into `Tb_cotizacion`(
	
		Cot_Num, `Cot_Cli`, Cot_Vend, Cot_Fecha, Cot_SubT, Cot_Descuent, 
		Cot_Total, `Cot_Imp`, `Cot_Clicom1`, `Cot_Clicom2`, `Cot_Leyenda`
	)
	values
	(
	   p_num, p_cli, p_ven, p_fecha, p_sub, p_desc, p_total, p_imp,
	   p_com1, p_com2, p_leyenda
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_COT_DETALLE` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_COT_DETALLE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_COT_DETALLE`(
	IN p_fac_id int, 
	in p_art_id int, 
	in p_precio float, 
	in p_imp float,
	in p_sub float,
	in p_cant float
    )
BEGIN
	insert into `tb_cot_detalle`(
	
		`CDet_fnum`, `CDet_artId`, `CDet_artPre`, `CDet_Imp`, `CDet_sub`, `CDet_Cant`)
	values
	(
	   p_fac_id, p_art_id, p_precio, p_imp, p_sub, p_cant
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_FACTURA` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_FACTURA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_FACTURA`(
	IN p_num int, 
	in p_cli int, 
	in p_ven int, 
	in p_fecha datetime,
	in p_sub float,
	in p_desc float,
	in p_total float,
	in p_pago float,
	in p_imp float,
	in p_com1 varchar(255),
	in p_com2 varchar(255),
	in p_leyenda varchar(255),
	in p_open bit
	
    )
BEGIN
	insert into `Tb_Factura`(
	
		Fact_Num, `Fact_Cli`, Fact_Vend, Fact_Fecha, Fact_SubT, Fact_Descuent, 
		Fact_Total,Fact_Pago, `Fact_Imp`, `Fact_Clicom1`, `Fact_Clicom2`, `Fact_Leyenda`, Fact_IsOpen
	)
	values
	(
	   p_num, p_cli, p_ven, p_fecha, p_sub, p_desc, p_total, p_pago, p_imp,
	   p_com1, p_com2, p_leyenda, p_open
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_FACT_DETALLE` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_FACT_DETALLE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_FACT_DETALLE`(
	IN p_fac_id int, 
	in p_art_id int, 
	in p_precio float, 
	in p_imp float,
	in p_sub float,
	in p_cant float,
	in p_fecha datetime
    )
BEGIN
	insert into `tb_fact_detalle`(
	
		`FDet_fnum`, `FDet_artId`, `FDet_artPre`, `FDet_Imp`, `FDet_sub`, `FDet_Cant`, `FDet_fecha`)
	values
	(
	   p_fac_id, p_art_id, p_precio, p_imp, p_sub, p_cant, p_fecha
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_PRINT` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_PRINT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_PRINT`(
	in p_fact int, 
	in p_fecha datetime,
	in p_cant int,
	in p_comentario varchar(250),
	in p_tipo_impresora varchar(50),
	in p_tipo varchar(50)
    )
BEGIN
	insert into `tb_historial_impresion`(
	
		tb_historial_impresion.`fact_id`, 
		tb_historial_impresion.`fecha_impre`,
		tb_historial_impresion.`faImp_cant`,
		tb_historial_impresion.`facHis_Comentario`,
		tb_historial_impresion.`facHis_tipoImpresora`,
		tb_historial_impresion.`facHis_tipo`
	)
	values
	(
	   p_fact, 
	   p_fecha,
	   p_cant,
	   p_comentario,
	   p_tipo_impresora,
	   p_tipo
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_TEMP` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_TEMP` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_TEMP`(
  in p_cliente varchar (100),
  in p_total float,
  in p_factura varchar (9)
)
BEGIN
  insert into `tb_temp` (
    `fact_numero`,
    `fact_cliente`,
    `fact_total`
  ) 
  VALUES
    (
      p_factura,
      p_cliente,
      p_total
    ) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `INS_VENDEDOR` */

/*!50003 DROP PROCEDURE IF EXISTS  `INS_VENDEDOR` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `INS_VENDEDOR`(
	IN p_id varchar(20), 
	in p_nombre varchar(30) 
	)
BEGIN
	insert into `Tb_Vendedor`(
	`Vend_Id`, `Vend_Nombre`
	)
	values
	(
	   p_id, p_nombre
	);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `RP_CLIENTES` */

/*!50003 DROP PROCEDURE IF EXISTS  `RP_CLIENTES` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `RP_CLIENTES`(
  IN p_fechain datetime,
  in p_fechaout datetime,
  IN p_id int
)
BEGIN
  SELECT 
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_Fecha` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
   WHERE tb_factura.Fact_Fecha BETWEEN p_fechain AND p_fechaout AND tb_factura.Fact_IsActive = '1'
   and tb_factura.`Fact_Cli` = p_id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `RP_DIA` */

/*!50003 DROP PROCEDURE IF EXISTS  `RP_DIA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `RP_DIA`(
  IN p_fechain DATETIME,
  IN p_fechaout DATETIME
)
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_vendedor`.`Vend_Nombre` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  WHERE (
      tb_factura.Fact_Fecha BETWEEN p_fechain 
      AND p_fechaout
    ) 
  ORDER BY tb_factura.`Fact_Num` DESC ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `RP_FECHAS` */

/*!50003 DROP PROCEDURE IF EXISTS  `RP_FECHAS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `RP_FECHAS`(
  IN p_fechain datetime,
  in p_fechaout datetime
)
BEGIN
  SELECT 
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Total`,
    DATE_FORMAT(
      `tb_factura`.`Fact_Fecha`,
      "%d/%m/%Y %H:%i:%s"
    ) 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  WHERE (
      tb_factura.Fact_Fecha BETWEEN p_fechain 
      AND p_fechaout 
      AND tb_factura.Fact_IsActive = '1'
    ) 
  order by tb_factura.`Fact_Num` desc ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `RP_VENDEDORES` */

/*!50003 DROP PROCEDURE IF EXISTS  `RP_VENDEDORES` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `RP_VENDEDORES`(
	IN p_fechain date,
	in p_fechaout date,
	IN p_id varchar(20)
    )
BEGIN
	
	SELECT
    `tb_vendedor`.`Vend_Nombre`
    , `tb_factura`.`Fact_Num`
    , `tb_factura`.`Fact_Total`
    , `tb_factura`.`Fact_Fecha`
FROM
    `bdferia`.`tb_factura`
    INNER JOIN `bdferia`.`tb_vendedor` 
        ON (`tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`)
	WHERE tb_factura.Fact_Fecha between p_fechain and p_fechaout and tb_factura.Fact_IsActive = '1'
	and tb_factura.Fact_Vend like concat(p_id, '%');
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO`(
    in p_id varchar(20),
    out p_resp varchar(50))
BEGIN
	set p_resp = '';
	select `Art_Nombre`
	into p_resp
	from tb_articulo
	where `Art_Id` = p_id and `Art_IsActive` = 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULOS_FAC` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULOS_FAC` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULOS_FAC`(
    in p_id varchar(20)
    )
BEGIN
	
	select Art_Id, Art_Nombre, Art_Pre1, Art_Pre2, Art_Pre3, Art_Pre4
	from tb_articulo
	where Art_auto = p_id; 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULOS_FAC_ANT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULOS_FAC_ANT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULOS_FAC_ANT`(
    IN p_id_art INT,
    IN p_id_cli INT
    )
BEGIN
	
SELECT
    `tb_fact_detalle`.`FDet_artPre`
FROM
    `bdferia`.`tb_factura`
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_fact_detalle` 
        ON (`tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`)
	WHERE `tb_fact_detalle`.`FDet_artId` = p_id_art AND
		`tb_factura`.`Fact_Cli` = p_id_cli
		ORDER BY `tb_fact_detalle`.`FDet_fecha` DESC
		LIMIT 1;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO_ACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO_ACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO_ACT`(
    in p_id varchar(20))
BEGIN
	
	select `Art_Nombre`, `Art_Pre1`, `Art_Pre2`, `Art_Pre3`, `Art_Pre4`,`Art_barcode`
	from tb_articulo
	where `Art_Id` = p_id and `Art_IsActive` = 1;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO_COD` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO_COD` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO_COD`(in p_id varchar (20))
BEGIN
  select 
    Art_Id,
    Art_Nombre,
    Art_auto,
    `Art_Pre1`,
    `Art_Pre4` 
  from
    tb_articulo 
  where (`Art_Id` LIKE CONCAT('%', p_id, '%') OR Art_Nombre LIKE CONCAT('%', p_id, '%'))
    and Art_IsActive = 1 
  order by `Art_Id` 
  limit 100 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO_COD_HIST` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO_COD_HIST` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO_COD_HIST`(in p_id varchar (20), in p_cliente int)
BEGIN
  select 
    * 
  from
    (SELECT 
      `tb_articulo`.`Art_Id`,
      `tb_articulo`.`Art_Nombre`,
      `tb_articulo`.`Art_auto`,
      `tb_fact_detalle`.`FDet_artPre`,
      `tb_articulo`.`Art_Pre4` 
    FROM
      `bdferia`.`tb_factura` 
      INNER JOIN `bdferia`.`tb_cliente` 
        ON (
          `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
        ) 
      INNER JOIN `bdferia`.`tb_fact_detalle` 
        ON (
          `tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`
        ) 
      INNER JOIN `bdferia`.`tb_articulo` 
        ON (
          `tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`
        ) 
    where (`Art_Id` LIKE CONCAT('%', p_id, '%') or Art_Nombre LIKE CONCAT('%', p_id, '%'))
      and Art_IsActive = 1 
      AND `tb_cliente`.`Cli_auto` = p_cliente 
      AND `tb_fact_detalle`.`FDet_fecha` IS NOT NULL 
      AND `tb_fact_detalle`.`FDet_fecha` > DATE_SUB(sysdate(), INTERVAL 6 MONTH) 
    ORDER BY `tb_fact_detalle`.`FDet_fecha` DESC) t 
  group by t.art_id 
  limit 3 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO_NOM` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO_NOM` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO_NOM`(
    in p_id varchar(50)
    )
BEGIN
	
	select Art_Id, Art_Nombre, Art_auto, `Art_Pre1`, `Art_Pre4`
	from tb_articulo
	where Art_Nombre LIKE CONCAT('%', p_id, '%') and Art_IsActive = 1
	limit 200; 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ARTICULO_RAP` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ARTICULO_RAP` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ARTICULO_RAP`(
    in p_id varchar(20)
    )
BEGIN
	
	select Art_auto
	from tb_articulo
	where `Art_Id` = p_id and Art_IsActive = 1; 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ART_BARCODE` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ART_BARCODE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ART_BARCODE`(IN p_id varchar (50))
BEGIN
  select 
    `Art_Id`,
    `Art_barcode`,
    `Art_Nombre`,
    `Art_Pre1`,
    `Art_Pre4` 
  from
    tb_articulo 
  WHERE (
      Art_IsActive = "1" 
      and `Art_barcode` LIKE p_id
    ) 
  limit 100 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ART_FACTURA` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ART_FACTURA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ART_FACTURA`(
    in p_id varchar(20)
    )
BEGIN
	
	select Art_Id, Art_Nombre
	from tb_articulo
	where Art_auto = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ART_IDF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ART_IDF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ART_IDF`(IN p_id varchar (20))
BEGIN
  select 
    `Art_Id`,
    `Art_barcode`,
    `Art_Nombre`,
    `Art_Pre1`,
    `Art_Pre4` 
  from
    tb_articulo 
  WHERE (
      Art_IsActive = "1" 
      and `Art_Id` LIKE CONCAT('%', p_id, '%')
    ) 
  limit 100 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_ART_NOMF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_ART_NOMF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_ART_NOMF`(IN p_nom varchar (50))
BEGIN
  select 
    `Art_Id`,
    `Art_barcode`,
    `Art_Nombre`,
    `Art_Pre1`,
    `Art_Pre4` 
  from
    tb_articulo 
  WHERE (
      Art_IsActive = "1" 
      and Art_Nombre LIKE CONCAT('%', p_nom, '%')
    ) 
  order by `Art_Nombre` 
  limit 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_BARCODE` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_BARCODE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_BARCODE`(
    in p_barcode varchar(50))
BEGIN
	
	select count(1)
	from tb_articulo
	where `Art_barcode` = p_barcode and `Art_IsActive` = 1;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_BARCODE_FACTURA` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_BARCODE_FACTURA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_BARCODE_FACTURA`(
    in p_barcode varchar(50)
    )
BEGIN
	
	select Art_Id, Art_Nombre, Art_Pre1, Art_Pre2, Art_Pre3, Art_Pre4, `Art_auto`
	from tb_articulo
	where Art_barcode = p_barcode; 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_BARCODE_FACTURA_ANT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_BARCODE_FACTURA_ANT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_BARCODE_FACTURA_ANT`(
    IN p_barcode varchar(50),
    IN p_id_cli INT
    )
BEGIN
	
SELECT
    `tb_fact_detalle`.`FDet_artPre`
    FROM
    `bdferia`.`tb_fact_detalle`
    INNER JOIN `bdferia`.`tb_factura` 
        ON (`tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`)
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`)
        WHERE `tb_articulo`.`Art_barcode` = p_barcode AND
		`tb_factura`.`Fact_Cli` = p_id_cli
		ORDER BY `tb_fact_detalle`.`FDet_fecha` DESC
		LIMIT 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CAMBIOS_FACTURA` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CAMBIOS_FACTURA` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CAMBIOS_FACTURA`(
    in p_id INT,
    out p_resp INT)
BEGIN
	set p_resp = 0;
	select count(`tb_cambios_factura`.`Fact_id_origen`)
	into p_resp
	from `tb_cambios_factura`
	where `tb_cambios_factura`.`Fact_id_origen` = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CAMBIO_FACT_AUTO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CAMBIO_FACT_AUTO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CAMBIO_FACT_AUTO`(
    in p_id INT,
    IN p_cambio INT,
    out p_resp INT)
BEGIN
	set p_resp = 0;
	select `tb_cambios_factura`.`Fact_auto`
	into p_resp
	from `tb_cambios_factura`
	where `tb_cambios_factura`.`Fact_id_origen` = p_id and `tb_cambios_factura`.`Fact_Cambio` = p_cambio
	LIMIT 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CDET_MOD` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CDET_MOD` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CDET_MOD`(
    in p_id INT)
BEGIN
	SELECT
    `tb_articulo`.`Art_Id`
    , `tb_articulo`.`Art_Nombre`
    , `tb_cot_detalle`.`CDet_Cant`
    , `tb_cot_detalle`.`CDet_artPre`
    , `tb_cot_detalle`.`CDet_Imp`
    , `tb_cot_detalle`.`CDet_sub`
    , `tb_articulo`.`Art_auto`
FROM
    `bdferia`.`tb_cot_detalle`
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_cot_detalle`.`CDet_artId` = `tb_articulo`.`Art_auto`)
	WHERE (tb_cot_detalle.`CDet_fnum` = p_id);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE`(
    in p_id varchar(20),
    out p_resp varchar(100))
BEGIN
	set p_resp = '';
	select `Cli_Nombre`
	into p_resp
	from tb_cliente
	where cli_id = p_id and Cli_IsActive = 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTES_FAC` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTES_FAC` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTES_FAC`(
    IN p_id VARCHAR(20),
    IN p_nombre VARCHAR(100)
    )
BEGIN
	
	SELECT `Cli_auto`, `Cli_Id`, `Cli_Nombre`
	FROM `tb_cliente`
	WHERE (`Cli_Id` LIKE CONCAT ('%', p_id) OR `Cli_Nombre` LIKE CONCAT ('%',p_nombre, '%')) AND Cli_IsActive = 1; 
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_ACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_ACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_ACT`(in p_codigo varchar (20))
BEGIN
  SELECT 
    `tb_cliente`.`Cli_Nombre`,
    `tb_cliente`.`Cli_Telefono`,
    `tb_cliente`.`Cli_Direccion`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_vendedor`.`Vend_Auto`,
    `tb_cliente`.`Cli_tipo_impresion`,
    `tb_cliente`.`Cli_Advertencia` 
  FROM
    `bdferia`.`tb_cliente` 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_cliente`.`Cli_Id_Vendedor` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (`tb_cliente`.`Cli_Id` = p_codigo) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_AUTO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_AUTO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_AUTO`(in p_id INT)
BEGIN
  SELECT 
    `tb_cliente`.`Cli_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  where `tb_factura`.`Fact_auto` = p_id ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_COB` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_COB` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_COB`(
    IN p_num INT)
BEGIN
SELECT
    `tb_cliente`.`Cli_Nombre`
    , `tb_factura`.`Fact_Total`
FROM
    `bdferia`.`tb_factura`
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
	WHERE `tb_factura`.`Fact_Num` = p_num AND `tb_factura`.`Fact_IsActive` = 1
	LIMIT 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_FACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_FACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_FACT`(
  in p_idc varchar (20),
  out p_cli_id int,
  OUT p_cli_nombre varchar (100),
  out p_cli_direcc varchar (80),
  out p_cli_adv vARCHAR (250),
  out p_cli_tel varchar (80),
  out p_printer boolean,
  OUT p_vendedor int
)
BEGIN
  set p_cli_id = 0 ;
  set p_cli_nombre = '' ;
  set p_cli_direcc = '' ;
  SET p_cli_adv = '' ;
  set p_cli_tel = '' ;
  set p_printer = false ;
  set p_vendedor = 0 ;
  select 
    Cli_auto,
    Cli_Nombre,
    Cli_Direccion,
    `Cli_Advertencia`,
    `Cli_Telefono`,
    `Cli_tipo_impresion`,
    `Cli_Id_Vendedor` into p_cli_id,
    p_cli_nombre,
    p_cli_direcc,
    p_cli_adv,
    p_cli_tel,
    p_printer,
    p_vendedor 
  from
    tb_cliente 
  where Cli_Id = p_idc 
    and Cli_IsActive = 1 
  limit 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_IDF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_IDF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_IDF`(
	IN p_id varchar(20)
    )
BEGIN
	
	SELECT
	Cli_Id
	, Cli_Nombre
	FROM bdferia.tb_cliente
	WHERE Cli_Id LIKE CONCAT(p_id, '%') AND Cli_IsActive = '1'
	limit 50;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_NOMF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_NOMF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_NOMF`(
	IN p_nom varchar(100)
    )
BEGIN
	
	select `Cli_Id`, `Cli_Nombre`	
	from tb_cliente
	WHERE (Cli_IsActive = "1" and Cli_Nombre LIKE CONCAT('%', p_nom, '%'))
	limit 200;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_TICKET` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_TICKET` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_TICKET`(
  in p_idc varchar (20),
  out p_printer boolean
)
BEGIN
  set p_printer = false ;
  select 
    `Cli_tipo_impresion` into p_printer 
  from
    tb_cliente 
  where Cli_Id = p_idc 
    and Cli_IsActive = 1 
  limit 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLIENTE_TODOS` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLIENTE_TODOS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLIENTE_TODOS`(
    )
BEGIN
	
	select `Cli_Id`, `Cli_Nombre`	
	from tb_cliente
	WHERE Cli_IsActive = "1";
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_CLI_OPEN` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_CLI_OPEN` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_CLI_OPEN`(
	IN p_id INT,
	OUT p_fact INT
    )
BEGIN
	SET p_fact = 0;
	SELECT
	`tb_factura`.`Fact_auto`
	INTO p_fact
	FROM
	`bdferia`.`tb_factura`
    	WHERE (`tb_factura`.`Fact_Cli` = p_id AND `tb_factura`.`Fact_IsOpen` = 1)
	LIMIT 1;
	
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND`(
	IN p_cond varchAR(30)
  )
BEGIN
	
	select `Art_Id`, `Art_Nombre`, `Art_Imp`, `Art_Costo`
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1 AND `Art_Id`= p_cond
	limit 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND_CONS` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND_CONS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND_CONS`(
  )
BEGIN
	
	select `Art_Id`, `Art_Nombre`, Art_Pre1, Art_Pre4
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1
	order by `Art_Nombre`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND_COSTOS` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND_COSTOS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND_COSTOS`(
  )
BEGIN
	
	select `Art_Id`,`Art_Nombre`, Art_Costo, Art_Pre1, Art_Pre4
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1
	ORDER BY `Art_Nombre`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND_FILTRO_COSTO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND_FILTRO_COSTO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND_FILTRO_COSTO`(
	IN p_cond varchAR(50)
  )
BEGIN
	
	select `Art_Id`,`Art_Nombre`, Art_Costo, Art_Pre1, Art_Pre4
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1 AND Art_Nombre LIKE CONCAT('%', p_cond, '%')
	ORDER BY `Art_Nombre`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND_FILTRO_SUGERIDO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND_FILTRO_SUGERIDO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND_FILTRO_SUGERIDO`(
	IN p_cond varchAR(50)
  )
BEGIN
	
	select `Art_Id`, `Art_Nombre`, Art_Pre1, Art_Pre4
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1 AND Art_Nombre LIKE CONCAT('%', p_cond, '%')
	ORDER BY `Art_Nombre`;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COND_ID` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COND_ID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COND_ID`(
	IN p_cond varchAR(30)
  )
BEGIN
	
	select `Art_Nombre`
	from tb_articulo
	where `Art_Tipo` = 'CONDIMENTO' and `Art_IsActive` = 1 AND `Art_Id`= p_cond
	limit 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COTIZACION` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COTIZACION` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COTIZACION`()
BEGIN
  SELECT 
    `tb_cotizacion`.`Cot_auto`,
    `tb_cotizacion`.`Cot_Num`,
    `tb_cotizacion`.`Cot_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_cotizacion`.`Cot_Total` 
  FROM
    `bdferia`.`tb_cotizacion` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_cotizacion`.`Cot_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  WHERE (
      `tb_cotizacion`.`Cot_IsActive` = 1
    ) 
  ORDER BY `tb_cotizacion`.`Cot_Num` DESC ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COT_AUTO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COT_AUTO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COT_AUTO`(
  in p_id INT,
  out p_resp INT,
  in p_fecha datetime
)
BEGIN
  set p_resp = 0 ;
  select 
    Cot_auto into p_resp 
  from
    tb_cotizacion 
  where `Cot_Num` = p_id 
    and `Cot_IsActive` = 1 
    and `Cot_Fecha` = p_fecha 
  LIMIT 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COT_BUSQ` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COT_BUSQ` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COT_BUSQ`(IN p_nombre varchar (100))
BEGIN
  SELECT 
    `tb_cotizacion`.`Cot_auto`,
    `tb_cotizacion`.`Cot_Num`,
    `tb_cotizacion`.`Cot_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_cotizacion`.`Cot_Total` 
  FROM
    `bdferia`.`tb_cotizacion` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_cotizacion`.`Cot_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  WHERE (
      `tb_cotizacion`.`Cot_IsActive` = 1 
      AND `tb_cliente`.`Cli_Nombre` like concat('%', p_nombre, '%')
    ) 
  ORDER BY `tb_cotizacion`.`Cot_Num` DESC 
  limit 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_COT_MOD` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_COT_MOD` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_COT_MOD`(
    in p_id INT)
BEGIN
	SELECT
    `tb_cliente`.`Cli_Id`
    , `tb_cliente`.`Cli_Nombre`
    , `tb_cliente`.`Cli_auto`
    , `tb_vendedor`.`Vend_Nombre`
    , `tb_vendedor`.`Vend_auto`
    , `tb_cotizacion`.`Cot_auto`
    , `tb_cotizacion`.`Cot_Clicom1`
    , `tb_cotizacion`.`Cot_Clicom2`
    , `tb_cotizacion`.`Cot_Descuent`
    , `tb_cotizacion`.`Cot_Fecha`
    , `tb_cotizacion`.`Cot_Leyenda`
    , `tb_cotizacion`.`Cot_Num`
    , `tb_cotizacion`.`Cot_SubT`
    , `tb_cotizacion`.`Cot_Total`
FROM
    `bdferia`.`tb_cotizacion`
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_cotizacion`.`Cot_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_vendedor` 
        ON (`tb_cotizacion`.`Cot_Vend` = `tb_vendedor`.`Vend_auto`)
        WHERE (`tb_cotizacion`.`Cot_auto` = p_id  ) ;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_AUTO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_AUTO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_AUTO`(
  in p_id INT,
  out p_resp INT,
  in p_fecha datetime
)
BEGIN
  set p_resp = 0 ;
  select 
    Fact_auto into p_resp 
  from
    tb_factura 
  where `Fact_Num` = p_id 
    and `fact_IsActive` = 1 
    and `Fact_Fecha` = p_fecha 
  LIMIT 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_CAMBIOS` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_CAMBIOS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_CAMBIOS`(in p_id INT, iN p_cambio int)
BEGIN
  SELECT 
    `tb_cliente`.`Cli_Id`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_cliente`.`Cli_auto`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_vendedor`.`Vend_auto`,
    `tb_cambios_factura`.`Fact_auto`,
    `tb_cambios_factura`.`Fact_Clicom1`,
    `tb_cambios_factura`.`Fact_Clicom2`,
    `tb_cambios_factura`.`Fact_Descuent`,
    `tb_cambios_factura`.`Fact_Fecha`,
    `tb_cambios_factura`.`Fact_Leyenda`,
    `tb_cambios_factura`.`Fact_Num`,
    `tb_cambios_factura`.`Fact_Pago`,
    `tb_cambios_factura`.`Fact_SubT`,
    `tb_cambios_factura`.`Fact_Total`,
    `tb_cliente`.`Cli_tipo_impresion`
  FROM
    `bdferia`.`tb_cambios_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_cambios_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_cambios_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (`tb_cambios_factura`.`Fact_id_origen` = p_id and `tb_cambios_factura`.`Fact_Cambio` = p_cambio) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_CLOSED` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_CLOSED` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_CLOSED`()
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 0
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC
  limit 500;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_CLOSED_BUSQ` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_CLOSED_BUSQ` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_CLOSED_BUSQ`(IN p_nombre VARCHAR (100))
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 0 
      AND `tb_cliente`.`Cli_Nombre` LIKE CONCAT('%', p_nombre, '%')
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC 
  LIMIT 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_CLOSED_BUSQF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_CLOSED_BUSQF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_CLOSED_BUSQF`(IN p_fact int)
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 0 
      AND `tb_factura`.`Fact_Num` like concat('%', p_fact, '%')
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC 
  limit 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_CLOSED_FILTRO_NOMBRE` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_CLOSED_FILTRO_NOMBRE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_CLOSED_FILTRO_NOMBRE`(IN p_nombre VARCHAR (100))
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 0 
      AND `tb_cliente`.`Cli_Nombre` LIKE CONCAT('%', p_nombre, '%')
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC 
  LIMIT 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_MOD` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_MOD` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_MOD`(in p_id INT)
BEGIN
  SELECT 
    `tb_cliente`.`Cli_Id`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_cliente`.`Cli_auto`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_vendedor`.`Vend_auto`,
    `tb_factura`.`Fact_auto`,
    `tb_factura`.`Fact_Clicom1`,
    `tb_factura`.`Fact_Clicom2`,
    `tb_factura`.`Fact_Descuent`,
    `tb_factura`.`Fact_Fecha`,
    `tb_factura`.`Fact_Leyenda`,
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Pago`,
    `tb_factura`.`Fact_SubT`,
    `tb_factura`.`Fact_Total`,
    `tb_cliente`.`Cli_tipo_impresion` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (`tb_factura`.`Fact_auto` = p_id) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_OPEN` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_OPEN` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_OPEN`()
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 1
    ) 
  ORDER BY `tb_cliente`.`Cli_Nombre` ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_OPEN_BUSQ` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_OPEN_BUSQ` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_OPEN_BUSQ`(IN p_nombre varchar (100))
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 1 
      AND `tb_cliente`.`Cli_Nombre` like concat('%', p_nombre, '%')
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC 
  limit 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_OPEN_BUSQF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_OPEN_BUSQF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_OPEN_BUSQF`(IN p_fact int)
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_factura`.`Fact_Fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_vendedor`.`Vend_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_factura`.`Fact_auto` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_vendedor` 
      ON (
        `tb_factura`.`Fact_Vend` = `tb_vendedor`.`Vend_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_IsOpen` = 1 
      AND `tb_factura`.`Fact_Num` like concat('%', p_fact, '%')
    ) 
  ORDER BY `tb_factura`.`Fact_Num` DESC 
  limit 200 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FACT_TO_PRINT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FACT_TO_PRINT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FACT_TO_PRINT`(
in p_num int
    )
BEGIN
SELECT
    `tb_factura`.`Fact_Num`
    , `tb_cliente`.`Cli_Nombre`
    , `tb_factura`.`Fact_Total`
FROM
    `bdferia`.`tb_factura`
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
        WHERE `tb_factura`.`Fact_auto` = p_num;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FDET_CAMBIOS` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FDET_CAMBIOS` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FDET_CAMBIOS`(in p_id INT)
BEGIN
  SELECT 
    `tb_articulo`.`Art_Id`,
    `tb_articulo`.`Art_Nombre`,
    `tb_cambios_fact_detalle`.`FDet_Cant`,
    `tb_cambios_fact_detalle`.`FDet_artPre`,
    `tb_cambios_fact_detalle`.`FDet_Imp`,
    `tb_cambios_fact_detalle`.`FDet_sub`,
    `tb_articulo`.`Art_auto`,
    `tb_cambios_fact_detalle`.`FDet_fecha` 
  FROM
    `bdferia`.`tb_cambios_fact_detalle` 
    INNER JOIN `bdferia`.`tb_cambios_factura` 
      ON (
        `tb_cambios_fact_detalle`.`FDet_fnum` = `tb_cambios_factura`.`Fact_auto`
      ) 
    INNER JOIN `bdferia`.`tb_articulo` 
      ON (
        `tb_cambios_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`
      ) 
  WHERE (
      `tb_cambios_fact_detalle`.`FDet_fnum` = p_id
    ) ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_FDET_MOD` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_FDET_MOD` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_FDET_MOD`(
    in p_id INT)
BEGIN
	SELECT
    `tb_articulo`.`Art_Id`
    , `tb_articulo`.`Art_Nombre`
    , `tb_fact_detalle`.`FDet_Cant`
    , `tb_fact_detalle`.`FDet_artPre`
    , `tb_fact_detalle`.`FDet_Imp`
    , `tb_fact_detalle`.`FDet_sub`
    , `tb_articulo`.`Art_auto`
    , `tb_fact_detalle`.`FDet_fecha`
FROM
    `bdferia`.`tb_fact_detalle`
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`)
	WHERE (tb_fact_detalle.`FDet_fnum` = p_id);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HISTORIAL_IMPRESION_FILTRO_ID` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HISTORIAL_IMPRESION_FILTRO_ID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HISTORIAL_IMPRESION_FILTRO_ID`(in p_id int)
BEGIN
  SELECT 
    `tb_historial_impresion`.`fecha_impre`,
    `tb_factura`.`Fact_Num`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_historial_impresion`.`facHis_Comentario` 
  FROM
    `bdferia`.`tb_historial_impresion` 
    INNER JOIN `bdferia`.`tb_factura` 
      ON (
        `tb_historial_impresion`.`fact_id` = `tb_factura`.`Fact_auto`
      ) 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_factura`.`Fact_Num` LIKE CONCAT('%', p_id, '%')
    ) 
  ORDER BY `tb_historial_impresion`.`fecha_impre` DESC
  limit 500 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HISTORIAL_IMPRESION_FILTRO_NOMBRE` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HISTORIAL_IMPRESION_FILTRO_NOMBRE` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HISTORIAL_IMPRESION_FILTRO_NOMBRE`(in p_nombre varchar (100))
BEGIN
  SELECT 
    `tb_historial_impresion`.`fecha_impre`,
    `tb_factura`.`Fact_Num`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_historial_impresion`.`facHis_Comentario` 
  FROM
    `bdferia`.`tb_historial_impresion` 
    INNER JOIN `bdferia`.`tb_factura` 
      ON (
        `tb_historial_impresion`.`fact_id` = `tb_factura`.`Fact_auto`
      ) 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
  where `tb_historial_impresion`.`fact_id` = `tb_factura`.`Fact_auto` 
    AND `tb_cliente`.`Cli_Nombre` LIKE CONCAT('%', p_nombre, '%') 
    and `tb_factura`.`Fact_IsActive` = 1 
  order by `tb_historial_impresion`.`fecha_impre` desc 
  limit 500;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HISTORIAL_PRODUCTO_VENDIDO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HISTORIAL_PRODUCTO_VENDIDO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HISTORIAL_PRODUCTO_VENDIDO`(
  IN p_nombre VARCHAR (50),
  IN p_fecha_inicio datetime,
  in p_fecha_fin datetime,
  IN p_cliente varchar (100)
)
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_fact_detalle`.`FDet_fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_articulo`.`Art_Id`,
    `tb_articulo`.`Art_Nombre`,
    `tb_fact_detalle`.`FDet_Cant`,
    `tb_fact_detalle`.`FDet_artPre` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_fact_detalle` 
      ON (
        `tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`
      ) 
    INNER JOIN `bdferia`.`tb_articulo` 
      ON (
        `tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      AND `tb_articulo`.`Art_Nombre` LIKE CONCAT('%', p_nombre, '%') 
      and `tb_cliente`.`Cli_Nombre` like concat('%', p_cliente, '%') 
      and `tb_fact_detalle`.`FDet_fecha` between p_fecha_inicio 
      and p_fecha_fin
    ) 
  ORDER BY `tb_fact_detalle`.`FDet_fecha` desc ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO`(
  IN p_fecha_inicio datetime,
  in p_fecha_fin datetime
)
BEGIN
  SELECT 
    `tb_factura`.`Fact_Num`,
    `tb_fact_detalle`.`FDet_fecha`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_articulo`.`Art_Id`,
    `tb_articulo`.`Art_Nombre`,
    `tb_fact_detalle`.`FDet_Cant`,
    `tb_fact_detalle`.`FDet_artPre` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_fact_detalle` 
      ON (
        `tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`
      ) 
    INNER JOIN `bdferia`.`tb_articulo` 
      ON (
        `tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`
      ) 
  WHERE (
      `tb_factura`.`Fact_IsActive` = 1 
      and `tb_fact_detalle`.`FDet_fecha` between p_fecha_inicio 
      and p_fecha_fin
    ) 
  ORDER BY `tb_fact_detalle`.`FDet_fecha` desc ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HIST_CLI` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HIST_CLI` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HIST_CLI`(
	IN p_id int
    )
BEGIN
	SELECT
    `tb_factura`.`Fact_Num`
    , `tb_factura`.`Fact_Fecha`
    , `tb_articulo`.`Art_Id`
    , `tb_articulo`.`Art_Nombre`
    , `tb_fact_detalle`.`FDet_Cant`
    , `tb_fact_detalle`.`FDet_artPre`
FROM
    `bdferia`.`tb_fact_detalle`
    INNER JOIN `bdferia`.`tb_factura` 
        ON (`tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`)
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`)
WHERE (tb_factura.Fact_IsActive = 1
    AND tb_factura.Fact_Cli = p_id)
ORDER BY `tb_factura`.`Fact_Num` DESC
limit 500;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HIST_CLI_IDF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HIST_CLI_IDF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HIST_CLI_IDF`(
	IN p_id varchar(20),
	in p_auto int
    )
BEGIN
	SELECT
    `tb_factura`.`Fact_Num`
    , `tb_factura`.`Fact_Fecha`
    , `tb_articulo`.`Art_Id`
    , `tb_articulo`.`Art_Nombre`
    , `tb_fact_detalle`.`FDet_Cant`
    , `tb_fact_detalle`.`FDet_artPre`
FROM
    `bdferia`.`tb_fact_detalle`
    INNER JOIN `bdferia`.`tb_factura` 
        ON (`tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`)
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`)
WHERE (`tb_factura`.`Fact_IsActive` = 1
	AND tb_articulo.Art_Id like concat('%', p_id, '%' ) and tb_cliente.Cli_auto = p_auto)
ORDER BY `tb_factura`.`Fact_Num` DESC
limit 100;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HIST_CLI_NOMF` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HIST_CLI_NOMF` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HIST_CLI_NOMF`(
	IN p_nombre varchar(50),
	in p_auto int
    )
BEGIN
	SELECT
    `tb_factura`.`Fact_Num`
    , `tb_factura`.`Fact_Fecha`
    , `tb_articulo`.`Art_Id`
    , `tb_articulo`.`Art_Nombre`
    , `tb_fact_detalle`.`FDet_Cant`
    , `tb_fact_detalle`.`FDet_artPre`
FROM
    `bdferia`.`tb_fact_detalle`
    INNER JOIN `bdferia`.`tb_factura` 
        ON (`tb_fact_detalle`.`FDet_fnum` = `tb_factura`.`Fact_auto`)
    INNER JOIN `bdferia`.`tb_cliente` 
        ON (`tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`)
    INNER JOIN `bdferia`.`tb_articulo` 
        ON (`tb_fact_detalle`.`FDet_artId` = `tb_articulo`.`Art_auto`)
WHERE (`tb_factura`.`Fact_IsActive` = 1
	AND tb_articulo.Art_Nombre like concat('%', p_nombre, '%' ) AND tb_cliente.Cli_auto = p_auto)
ORDER BY `tb_factura`.`Fact_Num` DESC
limit 100;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_HIST_PRINT` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_HIST_PRINT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_HIST_PRINT`()
BEGIN
  SELECT 
    `tb_historial_impresion`.`fecha_impre`,
    `tb_factura`.`Fact_Num`,
    `tb_cliente`.`Cli_Nombre`,
    `tb_factura`.`Fact_Total`,
    `tb_historial_impresion`.`facHis_Comentario` 
  FROM
    `bdferia`.`tb_factura` 
    INNER JOIN `bdferia`.`tb_cliente` 
      ON (
        `tb_factura`.`Fact_Cli` = `tb_cliente`.`Cli_auto`
      ) 
    INNER JOIN `bdferia`.`tb_historial_impresion` 
      ON (
        `tb_historial_impresion`.`fact_id` = `tb_factura`.`Fact_auto`
      ) 
  order by tb_historial_impresion.`fecha_impre` desc
  limit 1000;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_NOMBRE_VENDEDOR` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_NOMBRE_VENDEDOR` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_NOMBRE_VENDEDOR`(in p_id int)
BEGIN
  select 
    `vend_Nombre` 
  from
    tb_vendedor 
  where Vend_auto = p_id 
    and vend_IsActive = 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_VENDEDOR` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_VENDEDOR` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_VENDEDOR`(
    in p_id varchar(20),
    out p_resp varchar(30))
BEGIN
	set p_resp = '';
	select `vend_Nombre`
	into p_resp
	from tb_vendedor
	where `Vend_Id` = p_id and vend_IsActive = 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `SEL_VENDEDORES` */

/*!50003 DROP PROCEDURE IF EXISTS  `SEL_VENDEDORES` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `SEL_VENDEDORES`(
)
BEGIN
	
	select Vend_auto, Vend_Id, Vend_Nombre
	from tb_vendedor
	where Vend_IsActive = 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_ART` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_ART` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_ART`(
  IN p_id VARCHAR (20),
  IN p_desc VARCHAR (50),
  IN p_pre1 DOUBLE,
  IN p_pre2 DOUBLE,
  IN p_pre3 DOUBLE,
  IN p_pre4 DOUBLE,
  in p_tipo varchar (100),
  in p_imp bit,
  in p_compra double,
  in p_barcode varchar (50)
)
BEGIN
  UPDATE 
    `tb_articulo` 
  SET
    `Art_Nombre` = p_desc,
    `Art_Pre1` = p_pre1,
    `Art_Pre2` = p_pre2,
    `Art_Pre3` = p_pre3,
    `Art_Pre4` = p_pre4,
    Art_Tipo = p_tipo,
    `Art_Imp` = p_imp,
    `Art_Costo` = p_compra,
    `Art_barcode` = p_barcode 
  WHERE `Art_Id` = p_id 
    AND Art_IsActive = 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_CLI` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_CLI` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_CLI`(
  in p_id varchar (20),
  IN p_nombre VARCHAR (100),
  IN p_tel varchar (15),
  IN p_direccion varchar (80),
  in p_adv varchar (250),
  in p_printer boolean,
  IN p_vendedor int
)
BEGIN
  UPDATE 
    `tb_cliente` 
  SET
    `Cli_Nombre` = p_nombre,
    `Cli_Telefono` = p_tel,
    `Cli_Direccion` = p_direccion,
    `Cli_Advertencia` = p_adv,
    `Cli_tipo_impresion` = p_printer,
    `Cli_Id_Vendedor` = p_vendedor 
  WHERE `Cli_Id` = p_id 
    AND Cli_IsActive = 1 ;
END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_CLI_FACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_CLI_FACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_CLI_FACT`(
	IN p_id INT,
    IN p_vend INT
    )
BEGIN
	
	UPDATE `tb_factura`
	SET 
	`Fact_Vend` = p_vend
	WHERE `Fact_Num` = p_id AND `Fact_IsActive` = 1;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_CLOSE_FACT` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_CLOSE_FACT` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_CLOSE_FACT`(
    in p_id int
    )
BEGIN
	
	UPDATE `tb_factura`
	SET `Fact_IsOpen` = 0
	WHERE `Fact_auto` = p_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_COTIZACION` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_COTIZACION` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_COTIZACION`(
	in p_auto int,
	IN p_num INT, 
	IN p_cli INT, 
	IN p_ven INT, 
	IN p_fecha DATETIME,
	IN p_sub FLOAT,
	IN p_desc FLOAT,
	IN p_total FLOAT,
	IN p_imp FLOAT,
	IN p_com1 VARCHAR(255),
	IN p_com2 VARCHAR(255),
	IN p_leyenda VARCHAR(255)
	
    )
BEGIN
	
	UPDATE `tb_cotizacion`
	SET 	
	Cot_Num = p_num, 
	Cot_Cli = p_cli, 
	Cot_Vend = p_ven,
	Cot_Fecha = p_fecha, 
	Cot_SubT = p_sub, 
	Cot_Descuent = p_desc, 
	Cot_Total = p_total,
	Cot_Imp = p_imp, 
	Cot_Clicom1 = p_com1, 
	Cot_Clicom2 = p_com2,
	Cot_Leyenda = p_leyenda 
	WHERE `Cot_auto` = p_auto;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `UPD_FACT_CLOSED` */

/*!50003 DROP PROCEDURE IF EXISTS  `UPD_FACT_CLOSED` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `UPD_FACT_CLOSED`(
	in p_auto int,
	IN p_num INT, 
	IN p_cli INT, 
	IN p_ven INT, 
	IN p_fecha DATETIME,
	IN p_sub FLOAT,
	IN p_desc FLOAT,
	IN p_total FLOAT,
	IN p_pago FLOAT,
	IN p_imp FLOAT,
	IN p_com1 VARCHAR(255),
	IN p_com2 VARCHAR(255),
	IN p_leyenda VARCHAR(255),
	IN p_open BIT
    )
BEGIN
	
	UPDATE `tb_factura`
	SET 	
	Fact_Num = p_num, 
	Fact_Cli = p_cli, 
	Fact_Vend = p_ven,
	Fact_Fecha = p_fecha, 
	Fact_SubT = p_sub, 
	Fact_Descuent = p_desc, 
	Fact_Total = p_total,
	Fact_Pago = p_pago, 
	Fact_Imp = p_imp, 
	Fact_Clicom1 = p_com1, 
	Fact_Clicom2 = p_com2,
	Fact_Leyenda = p_leyenda, 
	Fact_IsOpen = p_open
	WHERE `Fact_auto` = p_auto;
    END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
