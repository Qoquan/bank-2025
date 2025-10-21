using Loic_Boulanger.Domaine;
using LoïcBoulanger2.Domain;

var owner = new Person("Alice", "Durand");
var account = new CurrentAccount("12345", owner, 500); // Découvert de 500 €

account.Deposit(1000);
account.Withdraw(1200);  // OK → solde = -200
account.Withdraw(400);   // REFUSÉ → dépasserait le découvert