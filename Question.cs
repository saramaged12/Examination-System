using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public abstract class Question
	{
		public abstract string Header { get; }

		public int Marks { get; set; }

		public string Body { get; set; }

		public Answer[] AnswerList { get; set; }

		public Answer StudentAnswer { get; set; }

		public Answer CorrectAnswer { get; set; }

		public Question()
		{
			StudentAnswer = new Answer();
			CorrectAnswer = new Answer();
		}
		public abstract void AddQuestion();

		public override string? ToString()
		{
			return $"{Header} \t Marks:{Marks} \n --------------- \n{Body}";
		}
	}
}
