DROP TABLE IF EXISTS User;
CREATE TABLE User (
    username TEXT PRIMARY KEY NOT NULL,
    hash TEXT NOT NULL,
    salt TEXT NOT NULL,
    balance REAL NOT NULL CHECK(balance > 0)
);

DROP TABLE IF EXISTS Diginote;
CREATE TABLE Diginote (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    owner TEXT NOT NULL,
    FOREIGN KEY (owner) REFERENCES User(username)
);

DROP TABLE IF EXISTS BuyOrder;
CREATE TABLE BuyOrder (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    user TEXT NOT NULL,
	  amount INTEGER NOT NULL,
	  date TEXT NOT NULL,
	  active INTEGER DEFAULT 1,
    FOREIGN KEY (user) REFERENCES User(username)
);

DROP TABLE IF EXISTS SellOrder;
CREATE TABLE SellOrder (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    user TEXT NOT NULL,
	  amount INTEGER NOT NULL,
	  date TEXT NOT NULL,
	  active INTEGER DEFAULT 1,
    FOREIGN KEY (user) REFERENCES User(username)
);

DROP TABLE IF EXISTS Quote;
CREATE TABLE Quote (
  value REAL NOT NULL,
  date DATE NOT NULL
);

                @"update Diginote set owner = @to where id in
                (select id from Diginote where owner = @from limit @amount)";