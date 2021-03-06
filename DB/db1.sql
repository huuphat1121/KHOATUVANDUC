PGDMP     
                    v         	   ql_khoatu    9.5.3    9.5.3 )    G           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            H           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            I           1262    16485 	   ql_khoatu    DATABASE     �   CREATE DATABASE ql_khoatu WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE ql_khoatu;
             postgres    false            J           1262    16485 	   ql_khoatu    COMMENT     4   COMMENT ON DATABASE ql_khoatu IS 'quan ly khoa tu';
                  postgres    false    2121                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            K           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    6            L           0    0    public    ACL     �   REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;
                  postgres    false    6                        3079    12355    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            M           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    16534    ca_niem_phat    TABLE     x   CREATE TABLE ca_niem_phat (
    ca_id integer NOT NULL,
    ca_niem character varying NOT NULL,
    so_nguoi integer
);
     DROP TABLE public.ca_niem_phat;
       public         postgres    false    6            �            1259    16532    ca_niem_phat_ca_id_seq    SEQUENCE     x   CREATE SEQUENCE ca_niem_phat_ca_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.ca_niem_phat_ca_id_seq;
       public       postgres    false    184    6            N           0    0    ca_niem_phat_ca_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE ca_niem_phat_ca_id_seq OWNED BY ca_niem_phat.ca_id;
            public       postgres    false    183            �            1259    16510    hocvien_info    TABLE     	  CREATE TABLE hocvien_info (
    hocvien_id integer NOT NULL,
    phapdanh character varying NOT NULL,
    thedanh character varying NOT NULL,
    phone character varying,
    nguoithan_phone character varying NOT NULL,
    cmnd character varying NOT NULL,
    cmnd_note character varying,
    hocvien_diachi character varying,
    namsinh integer,
    vitri character varying,
    ngayden date,
    ngayve date,
    ghichu character varying,
    caniemphat character varying NOT NULL,
    khu_id character(1) NOT NULL
);
     DROP TABLE public.hocvien_info;
       public         postgres    false    6            O           0    0    TABLE hocvien_info    COMMENT     1   COMMENT ON TABLE hocvien_info IS 'hocvien_info';
            public       postgres    false    182            P           0    0    COLUMN hocvien_info.hocvien_id    COMMENT     ;   COMMENT ON COLUMN hocvien_info.hocvien_id IS 'hocvien_id';
            public       postgres    false    182            Q           0    0    COLUMN hocvien_info.phapdanh    COMMENT     7   COMMENT ON COLUMN hocvien_info.phapdanh IS 'phapdanh';
            public       postgres    false    182            R           0    0    COLUMN hocvien_info.thedanh    COMMENT     5   COMMENT ON COLUMN hocvien_info.thedanh IS 'thedanh';
            public       postgres    false    182            S           0    0    COLUMN hocvien_info.phone    COMMENT     1   COMMENT ON COLUMN hocvien_info.phone IS 'phone';
            public       postgres    false    182            T           0    0 #   COLUMN hocvien_info.nguoithan_phone    COMMENT     E   COMMENT ON COLUMN hocvien_info.nguoithan_phone IS 'nguoithan_phone';
            public       postgres    false    182            U           0    0    COLUMN hocvien_info.cmnd    COMMENT     /   COMMENT ON COLUMN hocvien_info.cmnd IS 'cmnd';
            public       postgres    false    182            V           0    0    COLUMN hocvien_info.cmnd_note    COMMENT     9   COMMENT ON COLUMN hocvien_info.cmnd_note IS 'cmnd_note';
            public       postgres    false    182            W           0    0 "   COLUMN hocvien_info.hocvien_diachi    COMMENT     ;   COMMENT ON COLUMN hocvien_info.hocvien_diachi IS 'diachi';
            public       postgres    false    182            X           0    0    COLUMN hocvien_info.namsinh    COMMENT     5   COMMENT ON COLUMN hocvien_info.namsinh IS 'namsinh';
            public       postgres    false    182            Y           0    0    COLUMN hocvien_info.vitri    COMMENT     1   COMMENT ON COLUMN hocvien_info.vitri IS 'vitri';
            public       postgres    false    182            Z           0    0    COLUMN hocvien_info.ngayden    COMMENT     5   COMMENT ON COLUMN hocvien_info.ngayden IS 'ngayden';
            public       postgres    false    182            [           0    0    COLUMN hocvien_info.ngayve    COMMENT     3   COMMENT ON COLUMN hocvien_info.ngayve IS 'ngayve';
            public       postgres    false    182            \           0    0    COLUMN hocvien_info.ghichu    COMMENT     3   COMMENT ON COLUMN hocvien_info.ghichu IS 'ghichu';
            public       postgres    false    182            ]           0    0    COLUMN hocvien_info.caniemphat    COMMENT     ;   COMMENT ON COLUMN hocvien_info.caniemphat IS 'caniemphat';
            public       postgres    false    182            �            1259    16494 	   vitri_khu    TABLE     �   CREATE TABLE vitri_khu (
    khu_id character(1) NOT NULL,
    vitri character varying NOT NULL,
    status boolean NOT NULL
);
    DROP TABLE public.vitri_khu;
       public         postgres    false    6            ^           0    0    TABLE vitri_khu    COMMENT     +   COMMENT ON TABLE vitri_khu IS 'vitri_khu';
            public       postgres    false    181            _           0    0    COLUMN vitri_khu.khu_id    COMMENT     0   COMMENT ON COLUMN vitri_khu.khu_id IS 'khu_id';
            public       postgres    false    181            `           0    0    COLUMN vitri_khu.vitri    COMMENT     .   COMMENT ON COLUMN vitri_khu.vitri IS 'vitri';
            public       postgres    false    181            a           0    0    COLUMN vitri_khu.status    COMMENT     0   COMMENT ON COLUMN vitri_khu.status IS 'status';
            public       postgres    false    181            �           2604    16537    ca_id    DEFAULT     j   ALTER TABLE ONLY ca_niem_phat ALTER COLUMN ca_id SET DEFAULT nextval('ca_niem_phat_ca_id_seq'::regclass);
 A   ALTER TABLE public.ca_niem_phat ALTER COLUMN ca_id DROP DEFAULT;
       public       postgres    false    184    183    184            D          0    16534    ca_niem_phat 
   TABLE DATA               9   COPY ca_niem_phat (ca_id, ca_niem, so_nguoi) FROM stdin;
    public       postgres    false    184   �%       b           0    0    ca_niem_phat_ca_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('ca_niem_phat_ca_id_seq', 3, true);
            public       postgres    false    183            B          0    16510    hocvien_info 
   TABLE DATA               �   COPY hocvien_info (hocvien_id, phapdanh, thedanh, phone, nguoithan_phone, cmnd, cmnd_note, hocvien_diachi, namsinh, vitri, ngayden, ngayve, ghichu, caniemphat, khu_id) FROM stdin;
    public       postgres    false    182   �%       A          0    16494 	   vitri_khu 
   TABLE DATA               3   COPY vitri_khu (khu_id, vitri, status) FROM stdin;
    public       postgres    false    181   R&       �           2606    16542    ca_niem_phat_pkc 
   CONSTRAINT     W   ALTER TABLE ONLY ca_niem_phat
    ADD CONSTRAINT ca_niem_phat_pkc PRIMARY KEY (ca_id);
 G   ALTER TABLE ONLY public.ca_niem_phat DROP CONSTRAINT ca_niem_phat_pkc;
       public         postgres    false    184    184            �           2606    16517    hocvien_info_pkc 
   CONSTRAINT     \   ALTER TABLE ONLY hocvien_info
    ADD CONSTRAINT hocvien_info_pkc PRIMARY KEY (hocvien_id);
 G   ALTER TABLE ONLY public.hocvien_info DROP CONSTRAINT hocvien_info_pkc;
       public         postgres    false    182    182            �           2606    16501    vitri_khu_pkc 
   CONSTRAINT     Y   ALTER TABLE ONLY vitri_khu
    ADD CONSTRAINT vitri_khu_pkc PRIMARY KEY (khu_id, vitri);
 A   ALTER TABLE ONLY public.vitri_khu DROP CONSTRAINT vitri_khu_pkc;
       public         postgres    false    181    181    181            D   -   x�3�tv4T�U0�е��41�2
,3t38�M�b���� �z\      B   |   x�3�<2����y�
@z��N���ʇ�[�9��M���l 9�LS3s�?��҇���)�d<ܽd��ɜ��������F����F�9H�������y��e�#W� �](�      A   ,   x�s�t440�,�r�t1Ҹ�9�!"���#H�!P*F��� ���     