using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms
{
    class admin
    {
        public void login()
        {
            string username, password;
            Console.WriteLine("enter username");
            username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter passeord");
            password = Convert.ToString(Console.ReadLine());
            if (username == "ram" && password == "chair")
            {
                Console.WriteLine(" your login details is correct");
            }
            else
            {
                Console.WriteLine(" your login details is incorrect");
            }
        }
    }
    class employee
    {
        public int employeeID;
        public string Name;
        public string EMail;
        public string Adress;
        public int Phonenumber;

        public void Emp(int eID, string eName, string eEMail, string eAdress, int ePhonenumber)
        {
            employeeID = eID;
            Name = eName;
            EMail = eEMail;
            Adress = eAdress;
            Phonenumber = ePhonenumber;
        }
        public void displayemp()
        {
            Console.WriteLine("Employee id {0}", employeeID);
            Console.WriteLine("Employee Name {0}", Name);
            Console.WriteLine("Email id {0}", EMail);
            Console.WriteLine("Employee Adress{0}", Adress);
            Console.WriteLine("Employee phonenumber  {0}", Phonenumber);

        }
            




            
        }

    }
    class traning : admin
    {
        public int train_id { get; set; }
        public string trian_name { get; set; }
        public string trian_type { get; set; }
        public int trian_year { get; set; }
    }
    class dept : employee
    {

        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public string dept_type { get; set; }
    }
    class payroll : dept
    {
        public int pr_id { get; set; }
        public string pr_name { get; set; }
        public int  pr_date { get; set; }
        public string pr_slipnumb { get; set; }
                     
    }
    class prerformane : employee
    {
        public int performane_id { get; set;}

        public string performane_emp_name { get; set; }
        public string performane_date { get; set; }
        public string performane_type { get; set; }
                   }
    class resignation : employee
    {
        public int resignation_emp_id { get; set; }
        public string resignation_emp_name { get; set; }

        public string resignation_emp_date { get; set; }

    }
    class Program
    {
        static void Main(string[]  args)
        {
            admin a = new admin();
            a.login();
            Console.WriteLine("enter employee details");
            employee e = new employee();

            
      

        }
        
    }
}

