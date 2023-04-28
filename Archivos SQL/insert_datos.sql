BULK INSERT
	series
FROM 
	'C:\csv\series.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from series


BULK INSERT 
	subseries
FROM 
	'C:\csv\subseries.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from subseries

INSERT INTO cargos(nombre_cargo) values ('Subjefe'), ('Secretaria'), ('Operador')
select*from cargos

BULK INSERT 
	unidades_productoras
FROM 
	'C:\csv\unidades.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from unidades_productoras
