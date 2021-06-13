using System;
class Employee // base class
{
//variables
private string name;
private int empNum;
  
//properties
public string Name
{

get
{
return name;
}
set
{
name = value;
}
}
  
public int EmpNum
{

get
{
return empNum;
}
set
{
empNum = value;
}
}

//constructor
public Employee(string name,int empNum)
{
this.name = name;
this.empNum = empNum;

}

public string tostring()
{
return "\nEmployee Number : "+empNum +" Name : "+name;
}
}
class ProductionWorker : Employee // derived class
{
private int shift;
private double hourlyPayRate;
  
//properties
public int Shift
{
   get
   {
       return shift;
   }
   set
   {
       shift = value;
   }
}
public double HourlyPayRate
{
   get
   {
       return hourlyPayRate;
   }
   set
   {
       hourlyPayRate = value;
   }
}

//passing parameters to base class Employee from derived class ProductionWorker
public ProductionWorker(string name,int empNum,int shift,double hourlyPayRate): base(name,empNum)
{
this.shift = shift;
this.hourlyPayRate = hourlyPayRate;
}


    public new string tostring() => base.tostring() + "\nShift : " + shift + " Hourly Pay Rate : $" + hourlyPayRate;
}

  
public class Program
{
   public static void Main()
   {
   Console.WriteLine("Enter the name of Employee : ");
string name = Console.ReadLine();
Console.WriteLine("Enter the Employee number : ");
int empNum = Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine("Enter the shift : ");
int shift = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the hourly Pay rate : ");
double hpr = Convert.ToDouble(Console.ReadLine());
  
ProductionWorker pc = new ProductionWorker(name,empNum,shift,hpr);
  
  
Console.WriteLine("Employee Number : "+pc.EmpNum);
Console.WriteLine("Employee Name : "+pc.Name);
Console.WriteLine("Employee Shift : "+pc.Shift);
Console.WriteLine("Employee Hourly Pay rate : $"+pc.HourlyPayRate);
  
  
  
   }
}