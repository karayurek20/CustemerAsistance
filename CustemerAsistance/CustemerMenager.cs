using System;
using System.Collections.Generic;
using System.Text;

namespace CustemerAsistance
{
    class CustemerMenager
    {
        public void Add(Custemer custemer)
        {
            if (custemer.FirsName!=null&&custemer.LastName!=null&&custemer.Age!=null&&custemer.Id!=null)
            {
                Console.WriteLine("Müşteriniz eklendi " );
            }
            else
            {
                Console.WriteLine("Müşteri eklenemedi!! Girilmeyen değeriniz var!!");
            }
            
        }
        public void Remove(Custemer custemer)
        {
            Console.WriteLine("Müşteriniz silindi "+custemer.Id);
        }
    }
}
