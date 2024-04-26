class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        var company = new Company { Type = "Банк", Name = null };
        var city = new City { Name = "Санкт-Петербург" };
        var department = GetCurrentDepartment(company, city);
    }

    static Department GetCurrentDepartment(Company company, City city)
    {
        if (company.Type == "Банк" && city.Name == "Санкт-Петербург") 
        {
            Console.WriteLine($"У банка {company?.Name ?? "Неизвестная компания"} есть отделение в Санкт-Петербурге.");
        }
        Department department = new Department {Company = company, City = city };
        return department;
    }
}