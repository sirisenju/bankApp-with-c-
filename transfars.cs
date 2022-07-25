using System.Collections.Generic;
public class transfars{
    ulong receiverAccountNum;
    int pin;
    int ammount;
    byte bankChoice;
    
    public transfars(int ammount, ulong receiverAccountNum){
        this.ammount = ammount;
        this.receiverAccountNum = receiverAccountNum;
    }
    public void transfar(){
        Dictionary<int, String> bankOption = new Dictionary<int, string>();
        bankOption.Add(1, "FirstBank");
        bankOption.Add(2, "EcoBank");
        bankOption.Add(3, "UnionBank");
        bankOption.Add(4, "AccessBank");
        bankOption.Add(5, "UBA");
        bankOption.Add(6, "ZenithBank");

        
        Console.WriteLine("Select recipiant bank:");
        while (true)
        {
            try
            {
                Console.WriteLine("1. FirstBank\n2. EcoBank\n3. UnionBank\n4. AccessBank\n5. UBA\n6. ZenithBank");
                bankChoice = Convert.ToByte(Console.ReadLine());
                if (bankChoice > 7)
                {
                    Console.WriteLine("Account option selected not found!\nTry again!");
                }
                else
                {
                    break;
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }

        Console.WriteLine("Enter pin: ");
        pin = Convert.ToInt32(Console.ReadLine());
        if (pin != 1942)
        {
            Console.WriteLine("Invalid pin. Transaction treminated");
        } 
        else
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Transaction successfull!");
            Console.WriteLine($"Ammount: {ammount} naira successfully transfared to {receiverAccountNum} of {bankOption[bankChoice]}");
        }
    }
}