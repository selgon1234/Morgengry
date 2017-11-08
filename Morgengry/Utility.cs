using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Amulet.Level.medium)
            {
                return 20;
            }
            else if (amulet.Quality == Amulet.Level.low)
            {
                return 12.5;
            }
            else if (amulet.Quality == Amulet.Level.high)
            {
                return 27.5;
            }
            return 0;
                
        }
        public static double GetValueOfCourse(Course course)
        {
            return 0;
        }
    }
}
