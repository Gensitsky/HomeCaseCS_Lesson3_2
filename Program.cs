/*Описать структуру Client содержащую поля: код
клиента; ФИО; адрес; телефон; количество заказов
осуществленных клиентом; общая сумма заказов
клиента.*/
using System;

namespace HomeCaseCS_Lesson3_2
{
    struct Client
    {
        private int clientId;
        private string clientName;
        private string clientLocate;
        private string clientPhone;
        private int clientOrders;
        private double clientAccumulate;

        public Client(int id,string name,string locate,string phone,
            int orders,double accumulate)
        {
            clientId = id;
            clientName = name;
            clientLocate = locate;
            clientPhone = phone;
            clientOrders = orders;
            clientAccumulate = accumulate;
        }
        public void PrintClient()
        {
            Console.WriteLine($"Id: {clientId}");
            Console.WriteLine($"Name: {clientName}");
            Console.WriteLine($"Locate: {clientLocate}");
            Console.WriteLine($"Phone: {clientPhone}");
            Console.WriteLine($"Orders: {clientOrders}");
            Console.WriteLine($"Accumulate: {clientAccumulate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(111, "Vadim Gensitsky", "Nikolaev",
                "+380505841810", 10, 10000);
            Client client2 = new Client(222, "Vlad Tkachenko", "Kiev",
                "+380505480860", 20, 20000);

            client1.PrintClient();
            Console.WriteLine();
            client2.PrintClient();

            Console.ReadKey();
        }
    }
}
