using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    public record Student(string FirstName,string LastName,int Age)
              : Person(FirstName,LastName) ;
}
