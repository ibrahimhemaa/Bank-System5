CREATE TABLE Bank
(
  Name VARCHAR(30) NOT NULL,
  code NUMERIC(20) NOT NULL,
  Address VARCHAR(30) NOT NULL,
  PRIMARY KEY (code)
);

CREATE TABLE Branch
(
  Branch_number NUMERIC(15) NOT NULL,
  Address VARCHAR(45) NOT NULL,
  code NUMERIC(20) NOT NULL,
  PRIMARY KEY (Branch_number),
  FOREIGN KEY (code) REFERENCES Bank(code)
);

CREATE TABLE account
(
  balance NUMERIC(15) NOT NULL,
  Account_nuumber NUMERIC(15) NOT NULL,
  account_type VARCHAR(35) NOT NULL,
  Branch_number NUMERIC(15) NOT NULL,
  PRIMARY KEY (Account_nuumber),
  FOREIGN KEY (Branch_number) REFERENCES Branch(Branch_number)
);

CREATE TABLE employyee
(
  Name VARCHAR(40) NOT NULL,
  id NUMERIC(16) NOT NULL,
  Branch_number NUMERIC(15) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (Branch_number) REFERENCES Branch(Branch_number)
);

CREATE TABLE loan
(
  loan_type VARCHAR(30) NOT NULL,
  loan_number NUMERIC(15) NOT NULL,
  loan_amount NUMERIC(15) NOT NULL,
  Branch_number NUMERIC(15) NOT NULL,
  id NUMERIC(16) NOT NULL,
  PRIMARY KEY (loan_number),
  FOREIGN KEY (Branch_number) REFERENCES Branch(Branch_number),
  FOREIGN KEY (id) REFERENCES employyee(id)
);

CREATE TABLE customer
(
  FristName VARCHAR(15) NOT NULL,
  LastName VARCHAR(15) NOT NULL,
  Phone NUMERIC(11) NOT NULL,
  Address VARCHAR(45) NOT NULL,
  SSN NUMERIC(15) NOT NULL,
  id NUMERIC(16) NOT NULL,
  PRIMARY KEY (SSN),
  FOREIGN KEY (id) REFERENCES employyee(id)
);

CREATE TABLE take_by
(
  status VARCHAR(15) NOT NULL,
  loan_number NUMERIC(15) NOT NULL,
  SSN NUMERIC(15) NOT NULL,
  PRIMARY KEY (loan_number, SSN),
  FOREIGN KEY (loan_number) REFERENCES loan(loan_number),
  FOREIGN KEY (SSN) REFERENCES customer(SSN)
);

CREATE TABLE hold_by
(
  Account_nuumber NUMERIC(15) NOT NULL,
  SSN NUMERIC(15) NOT NULL,
  PRIMARY KEY (Account_nuumber, SSN),
  FOREIGN KEY (Account_nuumber) REFERENCES account(Account_nuumber),
  FOREIGN KEY (SSN) REFERENCES customer(SSN)
);