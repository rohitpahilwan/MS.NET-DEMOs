using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public partial class Customer
    {
        public string email {  get; set; }  

        public string contactNumber {  get; set; }  

        public string location {  get; set; }

        public override string ToString()
        {

            return "name -> " + name + " email => " + email+" contactnumber -> "+contactNumber+" Location -> "+location+" age -> "+age;
        }
    }
}
