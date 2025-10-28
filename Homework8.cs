namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);


        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }
    public static void TotalCredits(Customer[] customer_list)
    {
        double total = 0;
        foreach (Customer c in customer_list)
        {
            total += c.customerCredit;
        }
        Console.WriteLine("Q1:The total credits: " + total);
    }
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int sumAge = 0;
        int count = 0;
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Amarillo")
            {
                sumAge += c.customerAge;
                count++;
            }
        }
        if (count > 0)
        {
            double averageAge = (double)sumAge / count;
            Console.WriteLine("Q2:The average age of customers in Amarillo: " + averageAge);
        }
        else
        {
            Console.WriteLine("Q2:No customers from Amarillo.");
        }
    }
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Q3:The ages of customers in Canyon:");
        foreach (Customer c in customer_list)
        {
            if (c.customerCity == "Canyon")
            {
                if (c.customerAge > 30)
                {
                    Console.WriteLine(c.customerName);
                }
            }
        }
    }

}
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
