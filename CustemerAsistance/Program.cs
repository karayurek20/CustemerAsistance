using System;

namespace CustemerAsistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Custemer custemer = new Custemer();
            custemer.FirsName = "Mehmet Can";
            custemer.LastName = "KARAYÜREK";
            custemer.Age = 23;
            custemer.Id = custemer.FirsName.Substring(0, 3) + custemer.Age;
            Custemer[] custemers = new Custemer[] { custemer };

            foreach (var cust in custemers)
            {
                Console.WriteLine("Müşteri Adı : "+cust.FirsName);
                Console.WriteLine("Müşteri Soyadı : " + cust.LastName);
                Console.WriteLine("Müşteri Yaşı : " + cust.Age );
                Console.WriteLine("Müşterinin Id'si : " + cust.Id);
            }

            CustemerMenager menager = new CustemerMenager();
            menager.Add(custemer);
            

        }
    }
}
