using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public class FinalExam : Exam
	{
		public FinalExam(int time, int noOfQuestions) : base(time, noOfQuestions)
		{
		}

		public override void CreateQuestions()
		{
			ListOfQuestions = new Question[NoOfQuestions];
			for (int i = 0; i < ListOfQuestions.Length; i++)
			{

				int choice;
				do
				{
					Console.WriteLine("Enter 1 For MCQ or 2 For True/False Question :");
				} while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2);
				Console.Clear();

				if (choice < 1)
				{
					ListOfQuestions[i] = new MCQ_Question();
					ListOfQuestions[i].AddQuestion();	
				}

				else if (choice < 2)
				{
					ListOfQuestions[i]=new TF_Question();
					ListOfQuestions[i].AddQuestion();
				}
			}
		}
		public override void ShowExam()
		{
			int grade = 0, totalMarks = 0;
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

				if (question?.GetType() == typeof(MCQ_Question))
				{
					do
					{
						Console.WriteLine("Please Enter Answer Id");

					} while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId is 1 or 2 or 3)));
				}
				else
				{
					do
					{
						Console.WriteLine("Please Enter Answer Id (1 For True | 2 For False)");

					} while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId is 1 or 2)));
				}
				question.StudentAnswer.Id = UserAnswerId;
				question.StudentAnswer.Text = question.AnswerList[UserAnswerId - 1].Text;
				Console.WriteLine("-------------------------");
				Console.Clear();
				totalMarks += question.Marks;
			}
		

			for (int i = 0; i < ListOfQuestions.Length; i++)
			{
				
				if (ListOfQuestions[i].StudentAnswer.Id == ListOfQuestions[i].CorrectAnswer.Id)
				{
					grade += ListOfQuestions[i].Marks;
				}

				Console.WriteLine($"Question {i + 1} : {ListOfQuestions[i].Body}");
				Console.WriteLine($"Your Answer => {ListOfQuestions[i].StudentAnswer.Text}");
				Console.WriteLine($"Right Answer => {ListOfQuestions[i].CorrectAnswer.Text}");
			}

			Console.WriteLine($"Your Grade Is {grade} From {totalMarks}");

		} 
	}
}
