create database HOSTEL

use hostel

create table account(
	id int IDENTITY PRIMARY KEY NOT NULL,
	accounttype varchar(10) NOT NULL,
	fullname varchar(255) UNIQUE NOT NULL,
	position varchar(255) NOT NULL,
	username varchar(255) NOT NULL,
	password varchar(255) NOT NULL
)

drop table account

insert into account(accounttype, fullname, position, username, password) values('ADMIN', 'Jerome Villaruel', 'OJT', 'jerome123', '123')
insert into account(accounttype, fullname, position, username, password) values('USER', 'Ruby Gene S. Resus', 'Employee', 'bygene20', '123')
select * from account