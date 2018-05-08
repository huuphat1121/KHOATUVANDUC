-- Project Name : noname
-- Date/Time    : 5/8/2018 10:03:05 AM
-- Author       : PhatLH1
-- RDBMS Type   : PostgreSQL
-- Application  : A5:SQL Mk-2

-- vitri_khu
drop table vitri_khu cascade;

create table vitri_khu (
  khu_id char not null
  , vitri varchar not null
  , status boolean not null
  , constraint vitri_khu_PKC primary key (khu_id,vitri)
) ;

-- hocvien_info
drop table hocvien_info cascade;

create table hocvien_info (
  hocvien_id integer not null
  , phapdanh character varying not null
  , thedanh character varying not null
  , phone varchar
  , nguoithan_phone varchar not null
  , cmnd varchar not null
  , cmnd_note character varying
  , hocvien_diachi character varying
  , namsinh integer
  , vitri varchar
  , ngayden timestamp with time zone
  , ngayve timestamp with time zone
  , ghichu character varying
  , constraint hocvien_info_PKC primary key (hocvien_id)
) ;

comment on table vitri_khu is 'vitri_khu';
comment on column vitri_khu.khu_id is 'khu_id';
comment on column vitri_khu.vitri is 'vitri';
comment on column vitri_khu.status is 'status';

comment on table hocvien_info is 'hocvien_info';
comment on column hocvien_info.hocvien_id is 'hocvien_id';
comment on column hocvien_info.phapdanh is 'phapdanh';
comment on column hocvien_info.thedanh is 'thedanh';
comment on column hocvien_info.phone is 'phone';
comment on column hocvien_info.nguoithan_phone is 'nguoithan_phone';
comment on column hocvien_info.cmnd is 'cmnd';
comment on column hocvien_info.cmnd_note is 'cmnd_note';
comment on column hocvien_info.hocvien_diachi is 'diachi';
comment on column hocvien_info.namsinh is 'namsinh';
comment on column hocvien_info.vitri is 'vitri';
comment on column hocvien_info.ngayden is 'ngayden';
comment on column hocvien_info.ngayve is 'ngayve';
comment on column hocvien_info.ghichu is 'ghichu';

