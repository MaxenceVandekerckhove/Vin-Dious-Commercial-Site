CREATE DATABASE projet_stive;

USE projet_stive;

CREATE TABLE supplier(
   supplier_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   address VARCHAR(50) NOT NULL,
   zipcode INT NOT NULL,
   city VARCHAR(50) NOT NULL,
   email VARCHAR(50) NOT NULL,
   PRIMARY KEY(supplier_id)
);

INSERT INTO supplier (name, address, zipcode, city, email)
   VALUES 
   ('Le gout du vin', '10 rue des Artisans', 21800, 'Quetigny', 'commercialparis@le-gout-du-vin.fr'),
   ('Les grappes', '15 Rue du Sentier', 75002, 'Paris', 'commercialfrance@lesgrappes.fr')
;

CREATE TABLE product_category(
   category_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(100) NOT NULL,
   PRIMARY KEY(category_id)
);

INSERT INTO product_category (name, description)
   VALUES 
   ('Rouge', 'Venez gouter nos meilleurs vins rouges'),
   ('Rosé', 'Venez gouter nos meilleurs rosé')
;

CREATE TABLE product_brand(
   brand_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(100) NOT NULL,
   PRIMARY KEY(brand_id)
);

INSERT INTO product_brand (name, description)
   VALUES 
   ('Roche Mazet', 'Avec Roche Mazet Signature, l"histoire du Pays d"Oc se raconte au fil des cépages'),
   ('Cellier des Dauphins', 'Cellier des Dauphins, ses vins solaires issus du savoir-faire de l"Union des Vignerons des Côtes du Rhône')
;

CREATE TABLE role(
   role_id INT AUTO_INCREMENT,
   code VARCHAR(50) NOT NULL,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(50) NOT NULL,
   PRIMARY KEY(role_id)
);

INSERT INTO role (code, name, description)
   VALUES 
   ('Admin', 'Administrateurs', 'Users possedant tout les droits'),
   ('Users', 'Users', 'Users ayant acces au site mais ne possedant pas tout les droits' )
;

CREATE TABLE orders_status(
   status_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   PRIMARY KEY(status_id)
);

INSERT INTO orders_status (name)
   VALUES 
   ('En préparation'),
   ('Expédié'),
   ('En livraison'),
   ('Livré')
;

CREATE TABLE product(
   product_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   description VARCHAR(50) NOT NULL,
   price DECIMAL(15,2) NOT NULL,
   image VARCHAR(200) NOT NULL,
   creation_date DATE NOT NULL,
   quantity INT NOT NULL,
   supplier_id INT NOT NULL,
   category_id INT NOT NULL,
   brand_id INT NOT NULL,
   PRIMARY KEY(product_id),
   FOREIGN KEY(supplier_id) REFERENCES supplier(supplier_id),
   FOREIGN KEY(category_id) REFERENCES product_category(category_id),
   FOREIGN KEY(brand_id) REFERENCES product_brand(brand_id)
);

INSERT INTO product (name, description, price, image, creation_date, quantity, supplier_id, category_id, brand_id)
   VALUES 
   ('Cellier des Dauphins Réserve 2018', 'Cellier des Dauphins Réserve 2018 Côtes du Rhône - Vin rouge de la Vallée du Rhône', 6.11, "", "2021-11-24", 10, 1, 1, 2),
   ('Clairement Rosé 2019', 'Clairement Rosé de Roche Mazet 2019 Pays d’Oc - Vin rosé de Languedoc', 7.49, "", "2021-11-26", 14, 2, 2, 1)
;

CREATE TABLE web_user(
   user_id INT AUTO_INCREMENT,
   email VARCHAR(50) NOT NULL,
   phone VARCHAR(10) NOT NULL,
   password VARCHAR(50) NOT NULL,
   firstname VARCHAR(50) NOT NULL,
   lastname VARCHAR(50) NOT NULL,
   role_id INT NOT NULL,
   PRIMARY KEY(user_id),
   FOREIGN KEY(role_id) REFERENCES role(role_id)
);

INSERT INTO web_user (email, phone, password, firstname, lastname, role_id)
   VALUES 
   ('admin@vindious.fr', '0909645489', 'vindiousadminaccess', 'Admin', 'Access', 1),
   ('jacques.bernard@gmail.com', '0653908541', 'bernard123456', 'Jacques', 'Bernard', 2)
;

CREATE TABLE orders(
   orders_id INT AUTO_INCREMENT,
   price DECIMAL(15,2) NOT NULL,
   order_date DATETIME NOT NULL,
   quantity INT NOT NULL,
   status_id INT NOT NULL,
   user_id INT NOT NULL,
   PRIMARY KEY(orders_id),
   FOREIGN KEY(status_id) REFERENCES orders_status(status_id),
   FOREIGN KEY(user_id) REFERENCES web_user(user_id)
);

INSERT INTO orders (price, order_date, quantity, status_id, user_id)
   VALUES 
   (12.22, '2021-11-26 10:45:12', 2, 1, 2),
   (7.49, '2021-11-24 12:58:04', 1, 3, 1)
;

CREATE TABLE orders_inventory(
   inventory_id INT AUTO_INCREMENT,
   supplier_id INT,
   product_id INT,
   quantity INT,
   status_id INT NOT NULL,
   PRIMARY KEY(inventory_id),
   FOREIGN KEY(supplier_id) REFERENCES supplier(supplier_id),
   FOREIGN KEY(product_id) REFERENCES product(product_id),
   FOREIGN KEY(status_id) REFERENCES orders_status(status_id)
);

INSERT INTO orders_inventory (supplier_id, product_id, quantity, status_id)
   VALUES 
   (1, 1, 8, 2),
   (2, 2, 4, 4)
;

CREATE TABLE discount(
   discount_id INT AUTO_INCREMENT,
   name VARCHAR(50) NOT NULL,
   discount_percent DECIMAL(15,2) NOT NULL,
   active BOOLEAN NOT NULL,
   product_id INT NOT NULL,
   PRIMARY KEY(discount_id),
   FOREIGN KEY(product_id) REFERENCES product(product_id)
);

INSERT INTO discount (name, discount_percent, active, product_id)
   VALUES 
   ('Remboursement', 10, 0, 1),
   ('Good Deals', 25, 1, 2)
;

CREATE TABLE customer_address(
   address_id INT AUTO_INCREMENT,
   city VARCHAR(50) NOT NULL,
   zipcode INT NOT NULL,
   address VARCHAR(50) NOT NULL,
   firstname VARCHAR(50) NOT NULL,
   lastname VARCHAR(50) NOT NULL,
   user_id INT NOT NULL,
   PRIMARY KEY(address_id),
   FOREIGN KEY(user_id) REFERENCES web_user(user_id)
);

INSERT INTO customer_address (city, zipcode, address, firstname, lastname, user_id)
   VALUES 
   ('Valenciennes', 59300, '36 rue Jean Bernier', 'Jacques', 'Bernard', 2),
   ('Lille', 59800, '8 Bd Louis XIV', 'Oliver', 'Campbell', 1)
;

CREATE TABLE orders_detail(
   product_id INT AUTO_INCREMENT,
   orders_id INT,
   price DECIMAL(15,2) NOT NULL,
   quantity INT NOT NULL,
   PRIMARY KEY(product_id, orders_id),
   FOREIGN KEY(product_id) REFERENCES product(product_id),
   FOREIGN KEY(orders_id) REFERENCES orders(orders_id)
);

INSERT INTO orders_detail (orders_id, price, quantity)
   VALUES 
   (1, 12.22, 2),
   (2, 7.49, 1)
;