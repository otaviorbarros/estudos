
namespace Praticas_Heranca.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void WithDraw(double amount)
        {
            Balance -= amount;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }
    }
}
