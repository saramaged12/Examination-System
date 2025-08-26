using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public class MCQ_Question : Question
	{
		
		public override string Header => "MCQ Question";


		public MCQ_Question()
		{
			AnswerList = new Answer[3];
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

			//ANSWERS of question
			Console.WriteLine("Enter The Answers of Question: ");
			for (int i = 0; i < 3; i++)
			{
				AnswerList[i] = new Answer
				{
					Id = i + 1,

				};


				Console.WriteLine($"Enter The Answer Number {i + 1} Text: ");
				AnswerList[i].Text = Console.ReadLine();
			}

			//Right Answer

			int RightAnswerId;
			do
			{
				Console.WriteLine("Enter The Right Answer ID: ");
			} while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || marks < 1 || RightAnswerId > 3);
			CorrectAnswer.Id = RightAnswerId;
			CorrectAnswer.Text = AnswerList[RightAnswerId - 1].Text;

			Console.Clear();
		}
	}
}
