CREATE TABLE account
(
	id INT NOT NULL IDENTITY(1,1),
	position INT NOT NULL,
	fullname NVARCHAR(255) NOT NULL,
	username NVARCHAR(255) NOT NULL,
	password NVARCHAR(255) NOT NULL,
	create_date DATE NOT NULL,
	PRIMARY KEY (id),
	CONSTRAINT CHK_POSITION CHECK (position IN (0, 1))
);

CREATE TABLE customer
(
	id INT NOT NULL IDENTITY(1,1),
	fullname NVARCHAR(255) NOT NULL,
	phone_number NVARCHAR(255) NOT NULL,
	address NVARCHAR(255) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE import
(
	id INT NOT NULL IDENTITY(1,1),
	create_date DATE NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE bill
(
	id INT NOT NULL IDENTITY(1,1),
	account_id INT NOT NULL,
	customer_id INT NOT NULL,
	amount INT NOT NULL,
	price INT NOT NULL,
	create_date DATE NOT NULL,
	PRIMARY KEY (id),
    FOREIGN KEY (account_id) REFERENCES account(id),
    FOREIGN KEY (customer_id) REFERENCES customer(id) ON DELETE CASCADE,
);

CREATE TABLE producer
(
	id INT NOT NULL IDENTITY(1,1),
	name NVARCHAR(255) NOT NULL
	PRIMARY KEY (id)
);

CREATE TABLE origin
(
	id INT NOT NULL IDENTITY(1,1),
	name NVARCHAR(255) NOT NULL
	PRIMARY KEY (id)
);

CREATE TABLE category
(
	id INT NOT NULL IDENTITY(1,1),
	name NVARCHAR(255) NOT NULL
	PRIMARY KEY (id)
);

CREATE TABLE product
(
	id INT NOT NULL IDENTITY(1,1),
	account_id INT NOT NULL,
	category_id INT NOT NULL,
	producer_id INT NOT NULL,
	import_id INT NOT NULL,
	origin_id INT NOT NULL,
	name NVARCHAR(255) NOT NULL,
	amount INT NOT NULL,
	price INT NOT NULL,
	warranty_period INT NOT NULL,
	PRIMARY KEY (id),
    FOREIGN KEY (account_id) REFERENCES account(id),
    FOREIGN KEY (category_id) REFERENCES category(id),
    FOREIGN KEY (producer_id) REFERENCES producer(id),
    FOREIGN KEY (origin_id) REFERENCES origin(id),
    FOREIGN KEY (import_id) REFERENCES import(id)
);

CREATE TABLE bill_product
(
	id INT NOT NULL IDENTITY(1,1),
	bill_id INT NOT NULL,
	product_id INT NOT NULL,
	amount INT NOT NULL,
	PRIMARY KEY (id),
    FOREIGN KEY (bill_id) REFERENCES bill(id) ON DELETE CASCADE,
	FOREIGN KEY (product_id) REFERENCES product(id)
);