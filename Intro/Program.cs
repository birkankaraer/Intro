using Intro.Business;
using Intro.Dataaccess.concretes;
using Intro.Entities;

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name);
}
Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123456789022";
customer1.FirstName = "Birkan";
customer1.LastName = "karaer";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "123456789022";
customer2.FirstName = "Fatih";
customer2.LastName = "kücükdingin";
customer2.CustomerNumber = "123456";

CoorpotareCustomer customer3 = new CoorpotareCustomer();
customer3.Id = 3;
customer3.Name = "BudunAI";
customer3.CustomerNumber = "123456";
customer3.TaxNumber = "12345678";

CoorpotareCustomer customer4 = new CoorpotareCustomer();
customer4.Id = 4;
customer4.Name = "BudunAI";
customer4.CustomerNumber = "123456";
customer4.TaxNumber = "12345678";

BaseCustomer[] baseCustomers = { customer1, customer2 , customer3, customer4};
foreach (BaseCustomer customer in baseCustomers)
{
    Console.WriteLine(customer.CustomerNumber);
}

