using System;
					
public class Program
{
	public static void Main()
	{
		
		//This program calculate how many date have you been alive
		
		
		 
	Console.WriteLine(BirthDate(DateTime.Now).Subtract(yourBirthDay()).TotalDays);
		
	}
	public static DateTime BirthDate(DateTime modernTime){
	
		return modernTime;
	}
	public static DateTime yourBirthDay(){
		Console.WriteLine("The result shows how many days you have live");
		Console.WriteLine("Insert your birthday by follwing this format : year/month/date");
		String bd = Console.ReadLine();
		DateTime birthDate = DateTime.Parse(bd);
		return birthDate;
		
	}
}