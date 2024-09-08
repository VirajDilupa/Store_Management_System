
-- 01 show data in tables
select*from employees;
select*from items;
select*from record_data;
select*from message_data;

-- 02 delete data in tables

set sql_safe_updates=0;
DELETE FROM record_data;
set sql_safe_updates=1;

set sql_safe_updates=0;
DELETE FROM message_data;
set sql_safe_updates=1;

set sql_safe_updates=0;
DELETE FROM items;
set sql_safe_updates=1;

set sql_safe_updates=0;
DELETE FROM employees;
set sql_safe_updates=1;

-- 03 add data to the tables
-- insert into tablename(col1,col2) values ("data1","data1");

-- 04 remove data from the tables
set sql_safe_updates=0;
delete from tablename where colname = "coldata";
set sql_safe_updates=1;
