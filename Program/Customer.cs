namespace Zadanie_Uczelnia.Program
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Customer(int id, string name, string lastName, string accountNumber, decimal balance, string login, string password)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            AccountNumber = accountNumber;
            Balance = balance;
            Login = login;
            Password = password;
        }
    }
}