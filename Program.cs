using System.Diagnostics;

namespace Examination_System
{
	internal class Program
	{
		static void Main(string[] args)
		{
			 Subject subject = new Subject(1,"C#");
			subject.CreateExam();
			

			Console.Clear();

			char Char;
			do
			{
				Console.WriteLine("Do You Want To Start Exam (Y | N) ");

			} while (!(char.TryParse(Console.ReadLine(), out Char) && (Char == 'y' || Char == 'n')));

			if (Char == 'y')
			{
				Console.Clear();

				Stopwatch sw = new Stopwatch();

				sw.Start();

				subject.SubjectExam.ShowExam();

				sw.Stop();

				Console.WriteLine($"Time Taken = {sw.Elapsed}");
			}

			Console.WriteLine("Thank You");
		}
	}
}
