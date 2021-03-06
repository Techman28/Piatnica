CREATE TABLE ORDER_TAB
(
	ID INTEGER PRIMARY KEY,
	NUMBER VARCHAR(20)

)

CREATE TABLE EVENT_ORDER
(
	ID INTEGER PRIMARY KEY,
	NAME VARCHAR(50)
)

CREATE TABLE ORDER_ENTRY
(
	ID INTEGER PRIMARY KEY,
	ORDER_TYPE VARCHAR(50),
	ORDER_LOCATION VARCHAR(50),
	ORDER_DATE DATE,
	FROM_TIME TIME,
	TO_TIME TIME,
	CARGO VARCHAR(50),
	COMMENTS VARCHAR(100),
	ORDER_STATUS INTEGER,
	ORDER_ID INTEGER,
	FOREIGN KEY (ORDER_ID) REFERENCES ORDER_TAB(ID)
)

CREATE TABLE ORDER_STATE
(
	ID INTEGER PRIMARY KEY,
	Order_state VARCHAR(50),
	Order_date DATE,
	Order_id INTEGER,
	FOREIGN KEY (Order_id) REFERENCES ORDER_TAB(ID)
)

CREATE TABLE LOCATION_HISTORY
(
	ID INTEGER PRIMARY KEY,
	LONGITUDE DECIMAL(10,2),
	LONGITUDEL DECIMAL(10,2),
	LOCATION_DATE DATE,
	Order_id INTEGER,
	FOREIGN KEY (Order_id) REFERENCES ORDER_TAB(ID)
)

CREATE TABLE EVENT_HISTORY
(
	ID INTEGER PRIMARY KEY,
	EVENT_DATE DATE,
	EVENT_ID INTEGER,
	ORDER_ENTRY_ID INTEGER,
	FOREIGN KEY (EVENT_ID) REFERENCES EVENT_ORDER(ID),
	FOREIGN KEY (ORDER_ENTRY_ID) REFERENCES ORDER_ENTRY(ID)
	
)

CREATE TABLE DISTANCE_HISTORY
(
	ID INTEGER PRIMARY KEY,
	EVENT_DATE DATE,
	DISTANCE DECIMAL(10,2),
	DISTANCE_DATE DATE,
	EVENT_ID INTEGER,
	ORDER_ID INTEGER,
	FOREIGN KEY (EVENT_ID) REFERENCES EVENT_ORDER(ID),
	FOREIGN KEY (ORDER_ID) REFERENCES ORDER_TAB(ID)
)



CREATE TABLE ORDER_DELAY
(
	ID INTEGER PRIMARY KEY,
	DELAY_ORDER INTEGER,
	ORDER_DATE DATE,
	ORDER_ENTRY INTEGER,
	FOREIGN KEY (ORDER_ENTRY) REFERENCES ORDER_ENTRY(ID)

)


