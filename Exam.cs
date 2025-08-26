using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public abstract class Exam
	{
		
		public int Time { get; set;}

		public int NoOfQuestions { get; set; }

		public Question[] ListOfQuestions { get; set; }

		public Exam(int time, int noOfQuestions)
		{
			Time = time;
			NoOfQuestions = noOfQuestions;
		}

		public abstract void ShowExam();	

		public abstract void CreateQuestions();

	}
}
