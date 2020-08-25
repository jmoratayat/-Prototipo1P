create database bodega;
use bodega;
#------------------------------------------------------------------------------------------------------------------------------------------
create table if not exists tbl_login(
	pk_id_login 					int,
    usuario_login 					varchar(45),
    contraseña_login 				varchar(45),
    estado_login					int(2),
    fk_idempleado_login				int(9),#fk
    fk_idpermiso_login				int(9)
);
alter table tbl_login change pk_id_login pk_id_login int(9) auto_increment primary key;
create table if not exists tbl_empleado(
	pk_id_empleado 					int,#pk
    nombre_empleado					varchar(20),
    apellido_empleado				varchar(20),
    dpi_empleado					int(15),
    direccion_empleado				varchar(50),
    nit_empleado					int(15),
    fechanacimiento_empleado		date,
    fechaingreso_empleado			date,
    telefono_empleado				int(9),
    correo_empleado					varchar(50),
    genero_empleado					int(2),#genero
    estado_empleado					int(2)#estado activo o suspendido.
);
alter table tbl_empleado change pk_id_empleado pk_id_empleado int(9) auto_increment primary key;
create table if not exists tbl_permiso(
	pk_id_permiso					int,
    tipo_permiso					varchar(25),
    descripcon_permiso				varchar(50)
);
alter table tbl_permiso change pk_id_permiso pk_id_permiso int(9) auto_increment primary key;
#------------------------------------------------------------------------------------------------------------------------------------------
create table if not exists tbl_inventario(
	pk_id_inventario		int not null,
    descripcion_inventario	varchar(50),
    existencia_inventario	int,
    precio_inventario		double,
    estado_inventario		int,
    fk_idtipo_inventario	int
);
alter table tbl_inventario change pk_id_inventario pk_id_inventario int(9) auto_increment primary key;
create table if not exists tbl_tipoproducto(
	pk_id_tipoproducto			int not null,
    descripcion_tipoproducto	varchar(50),
    estado_tipoproducto			int
);
alter table tbl_tipoproducto change pk_id_tipoproducto pk_id_tipoproducto int(9) auto_increment primary key;
create table if not exists tbl_proveedor(
	pk_id_proveedor 					int,#pk
    nombre_proveedor					varchar(20),
    direccion_proveedors				varchar(50),
    nit_proveedors						int(15),
    telefono_proveedors					int(9),
    correo_proveedors					varchar(50),
    estado_proveedors					int(2)#estado activo o suspendido.
);
alter table tbl_proveedor change pk_id_proveedor pk_id_proveedor int(9) auto_increment primary key;
create table if not exists tbl_compra(
	pk_id_compra					int not null,
    fk_idproveedor_compra			int not null,
    fecha_compra					date
);
alter table tbl_compra change pk_id_compra pk_id_compra int(9) auto_increment primary key;
create table if not exists tbl_detallecompra(
	pk_id_detallecompra				int not null,
    fk_idcompra_detallecompra		int,
    fk_idinventario_detallecompra	int,
	tipopago_compra					int,
    cantidad_detallecompra			int
);
alter table tbl_detallecompra change pk_id_detallecompra pk_id_detallecompra int(9) auto_increment primary key;
#------------------------------------------------------------------------------------------------------------------------------------------
create table if not exists tbl_vendedor(
	pk_id_vendedor					int,#pk
    nombre_vendedor					varchar(20),
    apellido_vendedor					varchar(20),
    dpi_vendedor						int(15),
    direccion_vendedor					varchar(50),
    nit_vendedor						int(15),
    fechanacimiento_vendedor			date,
    fechaingreso_vendedor				date,
    telefono_vendedor					int(9),
    correo_vendedor						varchar(50),
    genero_vendedor						int(2),#genero
    estado_vendedor						int(2)#estado activo o suspendido.
);
alter table tbl_vendedor change pk_id_vendedor pk_id_vendedor int(9) auto_increment primary key;

create table if not exists tbl_factura(
	pk_id_factura					int not null,
    fecha_emision_factura			date,
    fk_idvendedor_factura			int,
    fecha_vencimiento_factura		date,
    nombre_factura					varchar(50),
    apellido_factura				varchar(50),
    telefono_factura				int,
    mail_factura					varchar(50),
    total_factura					double,
    tipo_factura					int, #credio o al contado
    tiempopago_factura				varchar(50)
);
alter table tbl_factura change pk_id_factura pk_id_factura int(9) auto_increment primary key;

create table if not exists tbl_detallefactura(
	pk_id_detallefactura				int not null,
    fk_idfactura_detallefactura			int,
    fk_idinventario_detallefactura		int
);
alter table tbl_detallefactura change pk_id_detallefactura pk_detallefactura int(9) auto_increment primary key;
#------------------------------------------------------------------------------------------------------------------------------------------
create table if not exists tbl_cotizacion(
	pk_id_cotizacion					int not null,
    fecha_emision_cotizacion			date,
    fecha_vencimiento_cotizacion		date,
    nombre_cotizacion					varchar(50),
    apellido_cotizacion					varchar(50),
    telefono_cotizacion					int,
    mail_cotizacion						varchar(50),
    total_cotizacion					double
);
alter table tbl_cotizacion change pk_id_cotizacion pk_id_cotizacion int(9) auto_increment primary key;

create table if not exists tbl_detallecotizacion(
	pk_id_detallecotizacion				int not null,
    fk_idcotizacion_detallecotizacion	int,
    fk_idinventario_detallecotizacion	int
);
alter table tbl_detallecotizacion change pk_id_detallecotizacion pk_id_detallecotizacion int(9) auto_increment primary key;

#------------------------------------------------------------------------------------------------------------------------------------------
create table if not exists tbl_cobro(
	pk_id_cobro					int not null,
    fk_idvendedor_cobro			int,
    fecha_cobro					date,
    fk_idfactura_cobro			int,
    descripcion_cobro			varchar(50),
    saldorestante_cobro			double,
    saldoabonar_cobro			double
);
alter table tbl_cobro change pk_id_cobro pk_id_cobro int(9) auto_increment primary key;


#------------------------------------------------------------------------------------------------------------------------------------------
alter table tbl_login add constraint fk_per_user foreign key(fk_idempleado_login) references tbl_empleado (pk_id_empleado);
alter table tbl_login add constraint fk_perm_user foreign key(fk_idpermiso_login) references tbl_permiso(pk_id_permiso);
#------------------------------------------------------------------------------------------------------------------------------------------
alter table tbl_inventario add constraint fk_tipo_ivent foreign key(fk_idtipo_inventario) references tbl_tipoproducto(pk_id_tipoproducto);
alter table tbl_compra add constraint fk_comp_prov foreign key(fk_idproveedor_compra) references tbl_proveedor(pk_id_proveedor);
alter table tbl_detallecompra add constraint fk_fk_deta_comp foreign key(fk_idcompra_detallecompra) references tbl_compra(pk_id_compra);
alter table tbl_detallecompra add constraint fk_pro_detc foreign key(fk_idinventario_detallecompra) references tbl_inventario(pk_id_inventario);
#------------------------------------------------------------------------------------------------------------------------------------------
alter table tbl_detallecotizacion add constraint fk_deta_coti foreign key(fk_idcotizacion_detallecotizacion) references tbl_cotizacion(pk_id_cotizacion);
alter table tbl_detallecotizacion add constraint fk_deta_prod foreign key(fk_idinventario_detallecotizacion) references tbl_inventario(pk_id_inventario);
#------------------------------------------------------------------------------------------------------------------------------------------
alter table tbl_cobro add constraint fk_cobro_ordenc foreign key(fk_idvendedor_cobro) references tbl_vendedor(pk_id_vendedor);
alter table tbl_cobro add constraint fk_cobro_fact	foreign key(fk_idfactura_cobro) references tbl_factura(pk_id_factura);
alter table tbl_detallefactura add constraint fk_detall_fact foreign key(fk_idfactura_detallefactura) references tbl_factura(pk_id_factura);
alter table tbl_detallefactura add constraint fk_detall_inve foreign key(fk_idinventario_detallefactura) references tbl_inventario(pk_id_inventario);
alter table tbl_factura add constraint fk_fac_vend foreign key (fk_idvendedor_factura) references tbl_vendedor(pk_id_vendedor);
