using System;

namespace AddressBookSystem
{
    class Program
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public int zipCode;
        public int phoneNumber;
        public string emailId;


        static void Main(string[] args)
        {
            Program p = new Program();
            p.setFname();
            p.setLname();
            p.setAdd();
            p.setCity();
            p.setState();
            p.setZip();
            p.setPhoneNumber();
            p.setEmail();

            p.display();
        }

        void display()
        {
            Console.WriteLine("FirstName  =" + getFname());
            Console.WriteLine("Last Name : " + getLname());
            Console.WriteLine("Address :" + getAdd());
            Console.WriteLine("CIty :" + getCity());
            Console.WriteLine("State :" + getState());
            Console.WriteLine("ZipCode :" + getZip());
            Console.WriteLine("Phone Number : " + getPhoneNumber());
            Console.WriteLine("Email Id : " + getEmail());
        }
        string getFname()
        {
            return firstName;

        }
        public void setFname()
        {
            Console.WriteLine("Please enter the First name");
            firstName = Console.ReadLine();
        }
        string getLname()
        {
            return lastName;
        }
        public void setLname()
        {
            Console.WriteLine("Please enter the last name");
            lastName = Console.ReadLine();
        }
        string getAdd()
        {
            return address;
        }
        public void setAdd()
        {
            Console.WriteLine("Please enter the Address :");
            address = Console.ReadLine();
        }
        string getCity()
        {
            return city;
        }
        public void setCity()
        {
            Console.WriteLine("Please enter the City :");
            city = Console.ReadLine();
        }
        string getState()
        {
            return state;
        }
        public void setState()
        {
            Console.WriteLine("Please enter the State :");
            state = Console.ReadLine();
        }
        int getZip()
        {
            return zipCode;
        }
        public void setZip()
        {
            Console.WriteLine("Please enter the ZipCode :");
            try
            {

                zipCode = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        int getPhoneNumber()
        {
            return phoneNumber;
        }
        public void setPhoneNumber()
        {
            Console.WriteLine("Please enter the PhoneNumber : ");
            try
            {
                phoneNumber = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        string getEmail()
        {
            return emailId;
        }
        public void setEmail()
        {
            Console.WriteLine("Please enter the Email Id :");
            emailId = Console.ReadLine();
        }
    }
}
