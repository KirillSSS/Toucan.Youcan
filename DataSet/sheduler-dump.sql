--
-- PostgreSQL database dump
--

-- Dumped from database version 12.9 (Debian 12.9-1.pgdg110+1)
-- Dumped by pg_dump version 12.8

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE IF EXISTS "Scheduler";
--
-- Name: Scheduler; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Scheduler" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'en_US.utf8' LC_CTYPE = 'en_US.utf8';


ALTER DATABASE "Scheduler" OWNER TO postgres;

\connect "Scheduler"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: Admins; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Admins" (
    id_category integer NOT NULL,
    id_user integer NOT NULL
);


ALTER TABLE public."Admins" OWNER TO postgres;

--
-- Name: Category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Category" (
    id integer NOT NULL,
    code character varying(8) NOT NULL,
    name character varying(25) NOT NULL,
    dad_id integer,
    owner_id integer NOT NULL
);


ALTER TABLE public."Category" OWNER TO postgres;

--
-- Name: Category_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Category_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Category_id_seq" OWNER TO postgres;

--
-- Name: Category_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Category_id_seq" OWNED BY public."Category".id;


--
-- Name: Days; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Days" (
    id integer NOT NULL,
    name character varying(10) NOT NULL
);


ALTER TABLE public."Days" OWNER TO postgres;

--
-- Name: Days_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Days_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Days_id_seq" OWNER TO postgres;

--
-- Name: Days_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Days_id_seq" OWNED BY public."Days".id;


--
-- Name: Group; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Group" (
    id integer NOT NULL,
    id_category integer NOT NULL,
    name character varying(20),
    type smallint NOT NULL,
    date_start date NOT NULL,
    date_end date NOT NULL,
    period integer NOT NULL,
    repeat boolean NOT NULL,
    time_start time without time zone NOT NULL,
    time_end time without time zone NOT NULL
);


ALTER TABLE public."Group" OWNER TO postgres;

--
-- Name: Group_Days; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Group_Days" (
    id_group integer NOT NULL,
    id_day integer NOT NULL
);


ALTER TABLE public."Group_Days" OWNER TO postgres;

--
-- Name: Group_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Group_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Group_id_seq" OWNER TO postgres;

--
-- Name: Group_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Group_id_seq" OWNED BY public."Group".id;


--
-- Name: Month; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Month" (
    id smallint NOT NULL,
    name character varying(15) NOT NULL
);


ALTER TABLE public."Month" OWNER TO postgres;

--
-- Name: Month_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Month_id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Month_id_seq" OWNER TO postgres;

--
-- Name: Month_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Month_id_seq" OWNED BY public."Month".id;


--
-- Name: Once_Month_Number; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Once_Month_Number" (
    id_group integer NOT NULL,
    number smallint NOT NULL
);


ALTER TABLE public."Once_Month_Number" OWNER TO postgres;

--
-- Name: Once_Year_Number_Month; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Once_Year_Number_Month" (
    id_group integer NOT NULL,
    number integer NOT NULL,
    id_month integer NOT NULL
);


ALTER TABLE public."Once_Year_Number_Month" OWNER TO postgres;

--
-- Name: Once_Year_Number_Month_id_group_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Once_Year_Number_Month_id_group_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Once_Year_Number_Month_id_group_seq" OWNER TO postgres;

--
-- Name: Once_Year_Number_Month_id_group_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Once_Year_Number_Month_id_group_seq" OWNED BY public."Once_Year_Number_Month".id_group;


--
-- Name: Repeat_first_day; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Repeat_first_day" (
    id_group integer NOT NULL,
    id_day integer NOT NULL,
    number smallint NOT NULL
);


ALTER TABLE public."Repeat_first_day" OWNER TO postgres;

--
-- Name: Type_Repeat; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Type_Repeat" (
    id smallint NOT NULL,
    name character varying(10) NOT NULL
);


ALTER TABLE public."Type_Repeat" OWNER TO postgres;

--
-- Name: Type_Repeat_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Type_Repeat_id_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Type_Repeat_id_seq" OWNER TO postgres;

--
-- Name: Type_Repeat_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Type_Repeat_id_seq" OWNED BY public."Type_Repeat".id;


--
-- Name: User_Category_Subscribe; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."User_Category_Subscribe" (
    id_category integer NOT NULL,
    id_user integer NOT NULL
);


ALTER TABLE public."User_Category_Subscribe" OWNER TO postgres;

--
-- Name: Users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Users" (
    mail character varying(50) NOT NULL,
    password character varying(256) NOT NULL,
    id integer NOT NULL
);


ALTER TABLE public."Users" OWNER TO postgres;

--
-- Name: Users_Groups; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Users_Groups" (
    id_group integer NOT NULL,
    id_user integer NOT NULL
);


ALTER TABLE public."Users_Groups" OWNER TO postgres;

--
-- Name: Users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Users_id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Users_id_seq" OWNER TO postgres;

--
-- Name: Users_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Users_id_seq" OWNED BY public."Users".id;


--
-- Name: Category id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Category" ALTER COLUMN id SET DEFAULT nextval('public."Category_id_seq"'::regclass);


--
-- Name: Days id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Days" ALTER COLUMN id SET DEFAULT nextval('public."Days_id_seq"'::regclass);


--
-- Name: Group id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group" ALTER COLUMN id SET DEFAULT nextval('public."Group_id_seq"'::regclass);


--
-- Name: Month id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Month" ALTER COLUMN id SET DEFAULT nextval('public."Month_id_seq"'::regclass);


--
-- Name: Type_Repeat id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Type_Repeat" ALTER COLUMN id SET DEFAULT nextval('public."Type_Repeat_id_seq"'::regclass);


--
-- Name: Users id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Users" ALTER COLUMN id SET DEFAULT nextval('public."Users_id_seq"'::regclass);


--
-- Name: Admins admins_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Admins"
    ADD CONSTRAINT admins_pk PRIMARY KEY (id_category, id_user);


--
-- Name: Category category_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Category"
    ADD CONSTRAINT category_pk PRIMARY KEY (id);


--
-- Name: Days days_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Days"
    ADD CONSTRAINT days_pk PRIMARY KEY (id);


--
-- Name: Group_Days group_days_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group_Days"
    ADD CONSTRAINT group_days_pk PRIMARY KEY (id_group);


--
-- Name: Group group_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group"
    ADD CONSTRAINT group_pk PRIMARY KEY (id);


--
-- Name: Month month_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Month"
    ADD CONSTRAINT month_pk PRIMARY KEY (id);


--
-- Name: Once_Month_Number once_month_number_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Once_Month_Number"
    ADD CONSTRAINT once_month_number_pk PRIMARY KEY (id_group);


--
-- Name: Once_Year_Number_Month once_year_number_month_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Once_Year_Number_Month"
    ADD CONSTRAINT once_year_number_month_pk PRIMARY KEY (id_group);


--
-- Name: Repeat_first_day repeat_first_day_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Repeat_first_day"
    ADD CONSTRAINT repeat_first_day_pk PRIMARY KEY (id_group);


--
-- Name: Type_Repeat type_repeat_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Type_Repeat"
    ADD CONSTRAINT type_repeat_pk PRIMARY KEY (id);


--
-- Name: User_Category_Subscribe user_category_subscribe_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User_Category_Subscribe"
    ADD CONSTRAINT user_category_subscribe_pk PRIMARY KEY (id_category, id_user);


--
-- Name: Users_Groups users_groups_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Users_Groups"
    ADD CONSTRAINT users_groups_pk PRIMARY KEY (id_group, id_user);


--
-- Name: Users users_pk; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Users"
    ADD CONSTRAINT users_pk PRIMARY KEY (id);


--
-- Name: category_code_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX category_code_uindex ON public."Category" USING btree (code);


--
-- Name: category_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX category_id_uindex ON public."Category" USING btree (id);


--
-- Name: days_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX days_id_uindex ON public."Days" USING btree (id);


--
-- Name: days_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX days_name_uindex ON public."Days" USING btree (name);


--
-- Name: group_days_id_group_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX group_days_id_group_uindex ON public."Group_Days" USING btree (id_group);


--
-- Name: group_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX group_id_uindex ON public."Group" USING btree (id);


--
-- Name: month_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX month_id_uindex ON public."Month" USING btree (id);


--
-- Name: month_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX month_name_uindex ON public."Month" USING btree (name);


--
-- Name: once_month_number_id_group_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX once_month_number_id_group_uindex ON public."Once_Month_Number" USING btree (id_group);


--
-- Name: once_year_number_month_id_group_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX once_year_number_month_id_group_uindex ON public."Once_Year_Number_Month" USING btree (id_group);


--
-- Name: repeat_first_day_id_group_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX repeat_first_day_id_group_uindex ON public."Repeat_first_day" USING btree (id_group);


--
-- Name: type_repeat_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX type_repeat_id_uindex ON public."Type_Repeat" USING btree (id);


--
-- Name: type_repeat_name_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX type_repeat_name_uindex ON public."Type_Repeat" USING btree (name);


--
-- Name: users_id_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX users_id_uindex ON public."Users" USING btree (id);


--
-- Name: users_mail_uindex; Type: INDEX; Schema: public; Owner: postgres
--

CREATE UNIQUE INDEX users_mail_uindex ON public."Users" USING btree (mail);


--
-- Name: Admins admins_category_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Admins"
    ADD CONSTRAINT admins_category_id_fk FOREIGN KEY (id_category) REFERENCES public."Category"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Admins admins_users_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Admins"
    ADD CONSTRAINT admins_users_id_fk FOREIGN KEY (id_user) REFERENCES public."Users"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Category category_category_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Category"
    ADD CONSTRAINT category_category_id_fk FOREIGN KEY (dad_id) REFERENCES public."Category"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Category category_users_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Category"
    ADD CONSTRAINT category_users_id_fk FOREIGN KEY (owner_id) REFERENCES public."Users"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Group group_category_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group"
    ADD CONSTRAINT group_category_id_fk FOREIGN KEY (id_category) REFERENCES public."Category"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Group_Days group_days_days_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group_Days"
    ADD CONSTRAINT group_days_days_id_fk FOREIGN KEY (id_day) REFERENCES public."Days"(id);


--
-- Name: Group_Days group_days_group_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group_Days"
    ADD CONSTRAINT group_days_group_id_fk FOREIGN KEY (id_group) REFERENCES public."Group"(id);


--
-- Name: Group group_type_repeat_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Group"
    ADD CONSTRAINT group_type_repeat_id_fk FOREIGN KEY (type) REFERENCES public."Type_Repeat"(id) ON UPDATE CASCADE ON DELETE RESTRICT;


--
-- Name: Once_Month_Number once_month_number_group_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Once_Month_Number"
    ADD CONSTRAINT once_month_number_group_id_fk FOREIGN KEY (id_group) REFERENCES public."Group"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Once_Year_Number_Month once_year_number_month_group_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Once_Year_Number_Month"
    ADD CONSTRAINT once_year_number_month_group_id_fk FOREIGN KEY (id_group) REFERENCES public."Group"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Once_Year_Number_Month once_year_number_month_month_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Once_Year_Number_Month"
    ADD CONSTRAINT once_year_number_month_month_id_fk FOREIGN KEY (id_month) REFERENCES public."Month"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Repeat_first_day repeat_first_day_days_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Repeat_first_day"
    ADD CONSTRAINT repeat_first_day_days_id_fk FOREIGN KEY (id_day) REFERENCES public."Days"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Repeat_first_day repeat_first_day_group_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Repeat_first_day"
    ADD CONSTRAINT repeat_first_day_group_id_fk FOREIGN KEY (id_group) REFERENCES public."Group"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: User_Category_Subscribe user_category_subscribe_category_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User_Category_Subscribe"
    ADD CONSTRAINT user_category_subscribe_category_id_fk FOREIGN KEY (id_category) REFERENCES public."Category"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: User_Category_Subscribe user_category_subscribe_users_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User_Category_Subscribe"
    ADD CONSTRAINT user_category_subscribe_users_id_fk FOREIGN KEY (id_user) REFERENCES public."Users"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Users_Groups users_groups_group_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Users_Groups"
    ADD CONSTRAINT users_groups_group_id_fk FOREIGN KEY (id_group) REFERENCES public."Group"(id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Users_Groups users_groups_users_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Users_Groups"
    ADD CONSTRAINT users_groups_users_id_fk FOREIGN KEY (id_user) REFERENCES public."Users"(id) ON UPDATE CASCADE ON DELETE SET DEFAULT;


--
-- PostgreSQL database dump complete
--

