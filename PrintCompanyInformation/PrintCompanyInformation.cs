using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. 
             * The manager has first name, last name, age and a phone number. 
             * Write a program that reads the information about a company 
             * and its manager and prints it back on the console.*/
            Console.WriteLine("Please enter a Company Name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Please enter a Company Address:");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Please enter a Company Phone Number:");
            string companyPhone = Console.ReadLine();
            Console.WriteLine("Please enter a Company Fax Number:");
            string companyFax = Console.ReadLine();
            Console.WriteLine("Please enter a Company Website:");
            string companyWebsite = Console.ReadLine();
            Console.WriteLine("Please enter a Manager Firstname:");
            string companyManagerFname = Console.ReadLine();
            Console.WriteLine("Please enter a Manager Lastname:");
            string companyManagerLname = Console.ReadLine();
            Console.WriteLine("Please enter a Manager Age:");
            string companyManagerAge = Console.ReadLine();
            Console.WriteLine("Please enter a Manager Phone Number:");
            string companyManagerPhone = Console.ReadLine();

            //Here is the start of print info on the console
            Console.WriteLine("Company: {0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Phone: {0}", companyPhone);
            Console.WriteLine("Fax: {0}", companyFax);
            Console.WriteLine("Website: {0}", companyWebsite);
            Console.WriteLine("Manager: {0} {1}", companyManagerFname, companyManagerLname);
            Console.WriteLine("Manager Age: {0}", companyManagerAge);
            Console.WriteLine("Manager Phone: {0}", companyManagerPhone);
        }
    }
}
