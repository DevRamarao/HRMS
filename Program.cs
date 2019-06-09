using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrms
{
    
    class employee
    {
        public int emp_id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string adress { get; set; }
        public string designation { get; set; }
    }
    
    class admin : employee
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
    
    
    class dept
    {
        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public string dept_type { get; set; }
    }
    class traning : dept
    {
        public int train_id { get; set; }
        public string trian_name { get; set; }
        public string trian_type { get; set; }
        public int trian_year { get; set; }
    }
    class payroll : dept
    {
        public int pr_id { get; set; }
        public string pr_name { get; set; }
        public int  pr_date { get; set; }
        public string pr_slipnumb { get; set; }
                     
    }
    class prerformance
    {
        public int performane_id { get; set;}

        public string performane_emp_name { get; set; }
        public string performane_date { get; set; }
        public string performane_type { get; set; }
    }
    class resignation
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
            
            Console.WriteLine("employee id " + e.emp_id);            
            Console.ReadLine();
        }
        
    }
}
