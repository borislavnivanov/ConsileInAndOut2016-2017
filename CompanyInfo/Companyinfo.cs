using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName, companyAddress, companyPhone, fax, webSite, manName, manFamName, manPhone;
        byte manAge;

        companyName = Console.ReadLine();
        companyAddress = Console.ReadLine();
        companyPhone = Console.ReadLine();
        fax = Console.ReadLine();
        webSite = Console.ReadLine();
        manName = Console.ReadLine();
        manFamName = Console.ReadLine();
        manAge = byte.Parse(Console.ReadLine());
        manPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhone);
        if (fax == String.Empty)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + fax);
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manName, manFamName, manAge, manPhone);
    }
}
    