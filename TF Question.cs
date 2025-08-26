using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public class TF_Question : Question
	{

		public override string Header => "True/False Question";

		public TF_Question()
		{
			AnswerList = new Answer[2];
			AnswerList[0] = new Answer(1, "True");
			AnswerList[1] = new Answer(2, "False");
		}


		public override void AddQuestion()
		{
			//HEADER
			Console.WriteLine(Header);

			//BODY
			Console.WriteLine("Enter Question Body: ");
			Body = Console.ReadLine();

			//QUESTION 
			Console.WriteLine("Enter Marks of Question: ");
			int marks;
			do
			{
				Console.WriteLine("Enter The Mark Of Question");
			} while (!int.TryParse(Console.ReadLine(), out marks) || marks <= 0);
			Marks = marks;

			
			
			//Right Answer
			
			int RightAnswerId;
			do
			{
			Console.WriteLine("Enter The Right Answer ID: ");
			} while (!int.TryParse(Console.ReadLine(), out RightAnswerId ) || marks < 1 || RightAnswerId>2);
			CorrectAnswer.Id = RightAnswerId;
			CorrectAnswer.Text = AnswerList[RightAnswerId - 1].Text;

			Console.Clear();
		}
	}
}
