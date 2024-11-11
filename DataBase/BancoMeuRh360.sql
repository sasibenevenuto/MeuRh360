-- Database: meuRh360

-- DROP DATABASE IF EXISTS "meuRh360";

CREATE DATABASE "meuRh360"
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Portuguese_Brazil.1252'
    LC_CTYPE = 'Portuguese_Brazil.1252'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;
	
-- Table: public.company

-- DROP TABLE IF EXISTS public.company;

CREATE TABLE IF NOT EXISTS public.company
(
    "companyId" integer NOT NULL,
    "typeCompany" character varying(100) COLLATE pg_catalog."default",
    name character varying(500) COLLATE pg_catalog."default" NOT NULL,
    cnpj character varying(14) COLLATE pg_catalog."default" NOT NULL,
    "postalCode" character varying(8) COLLATE pg_catalog."default",
    address character varying(500) COLLATE pg_catalog."default",
    neighborhood character varying(500) COLLATE pg_catalog."default",
    "federativeUnit" character varying(2) COLLATE pg_catalog."default",
    city character varying(100) COLLATE pg_catalog."default",
    complement character varying(500) COLLATE pg_catalog."default",
    "cellPhone" character(14) COLLATE pg_catalog."default" NOT NULL,
    "nameAdministrator" character varying(500) COLLATE pg_catalog."default" NOT NULL,
    "cpfAdministrator" character varying(11) COLLATE pg_catalog."default" NOT NULL,
    "emailAdministrator" character varying(500) COLLATE pg_catalog."default",
    CONSTRAINT company_pkey PRIMARY KEY ("companyId")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.company
    OWNER to postgres;
	
-- Table: public.user

-- DROP TABLE IF EXISTS public."user";

CREATE TABLE IF NOT EXISTS public."user"
(
    "userId" integer NOT NULL,
    "acceptanceTerms" bit(1) NOT NULL,
    name character varying(500) COLLATE pg_catalog."default" NOT NULL,
    email character varying(500) COLLATE pg_catalog."default" NOT NULL,
    password character varying(500) COLLATE pg_catalog."default" NOT NULL,
    "passwordConfirm" character varying(500) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT user_pkey PRIMARY KEY ("userId")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."user"
    OWNER to postgres;