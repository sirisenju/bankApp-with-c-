

public class accountBalance 
{
    public int pin;
    private int balance = 500000; 

    public accountBalance(int pin){
        this.pin = pin;
    }
    public int getBalance{
        get{return balance;}
    }

    public void Balance(){
        Console.WriteLine("***********************************");
        Console.WriteLine("Processing.......");
        Console.WriteLine($"Your account balance is: {getBalance} naira only.");
        Console.WriteLine("Thank you for banking with us!");
    }
}