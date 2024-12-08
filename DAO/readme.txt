Реализовать класс для работы с базой данных
EntityFramework, CodeFirst, SQLite

Создать классы для таблиц:

Users
	UserId
	Username

Transactions
	TransactionId
	UserId
	Amount //Сумма транзакции
	TransactionDate //Дата и время транзакции
	CategoryId //Идентификатор категории расхода
	Description //Описание транзакции

Categories
	CategoryId
	Name //Название категории

Budgets
	UserId
	CategoryId
	TotalBudget //Бюджет по категории