using StateDesignPatternDemo;
public class Program
{
    static void Main(string[] args)
    {
        ATMMachine aTMMachine = new ATMMachine();
        Console.WriteLine("ATM Machine Current state : "+ aTMMachine.aTMState.GetType().Name);
        Console.WriteLine();
        aTMMachine.EnterPin();
        aTMMachine.WithdrawMoney();
        aTMMachine.EjectDebitCard();
        aTMMachine.InsertDebitCard();
        Console.WriteLine();

        Console.WriteLine("ATM Machine Current state : "+ aTMMachine.aTMState.GetType().Name);
        Console.WriteLine();
        aTMMachine.EnterPin();
        aTMMachine.WithdrawMoney();
        aTMMachine.InsertDebitCard();
        aTMMachine.EjectDebitCard();

        Console.WriteLine();
        Console.WriteLine("ATM Machine Current state : "+ aTMMachine.aTMState.GetType().Name);

    }
}