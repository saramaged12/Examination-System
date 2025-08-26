using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public class PracticalExam : Exam
	{
		public PracticalExam(int time, int noOfQuestions) : base(time, noOfQuestions)
		{
		}

		public override void CreateQuestions()
		{
			ListOfQuestions = new MCQ_Question[NoOfQuestions];
			for (int i = 0; i < ListOfQuestions.Length; i++)
			{
					ListOfQuestions[i] = new MCQ_Question();
					ListOfQuestions[i].AddQuestion();
				    Console.Clear();
			}
		}

		public override void ShowExam()
		{
			
			foreach (var question in ListOfQuestions)
			{
				// Question

				Console.WriteLine(question);
				// Answers

				for (int i = 0; i < question?.AnswerList?.Length; i++)
					Console.WriteLine(question.AnswerList[i]);
				Console.WriteLine("-------------------------");

				//User Answer
				int UserAnswerId;

				
					do
					{
						Console.WriteLine("Please Enter Answer Id");

					} while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId is 1 or 2 or 3)));
				
			
				Console.WriteLine("-------------------------");
				
			}
			Console.Clear();
			
			for(var q = 0; q <ListOfQuestions.Length; q++)
			{
				
				Console.WriteLine($"Right Answer of Question{q+1} : {ListOfQuestions[q].CorrectAnswer.Text}");
			}
			
			
		}
	}
}
