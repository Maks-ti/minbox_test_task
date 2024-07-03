
-- стиль постгрёвый (как привык)

create table product 
(
	id serial,
	"name" varchar not null,
	code varchar not null,
	constraint product_pk primary key (id),
	constraint product_unique unique (code)
);

create table category
(
	id serial,
	"name" varchar not null,
	constraint category_pk primary key (id),
	constraint category_unique unique ("name")
);

create table product_to_category
(
	product_id int not null,
	category_id int not null,
	constraint product_to_category__product_fk foreign key (product_id) references product (id),
	constraint product_to_category__category_fk foreign key (category_id) references category (id)
);
