# Ntier Architecture (Katmanlý mimari)

## DAL (Data Access Layer) => veriye ulaþým katmaný.
	Packages: 
		Microsoft.EntityFrameworkCore.SqlServer
		Microsoft.EntityFrameworkCore.Tools
	- Entities
		 - Category
		 - Product
	- Seeder
	- Context

## BLL (Business Logic Layer) => Ýþ mantýðý katmaný.
	### internal Services
		- CategoryService
		- ProductService


## UI (User Interface) => Arayüz (sunum) katmaný.
	### Console
		- CategoryConsoleSpec
		- ProductConsoleSpec
	

------------------------------------------
