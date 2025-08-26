﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
	public class Subject
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Exam SubjectExam { get; set; }

		public Subject(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public void CreateExam()
		{
			int examType, time, numberOfQuestions;

			do
			{
				Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");

			} while (!(int.TryParse(Console.ReadLine(), out examType) && (examType is 1 or 2)));

			do
			{
				Console.WriteLine("Please Enter The Time For Exam From (30 min to 180 min)");

			} while (!(int.TryParse(Console.ReadLine(), out time) && (time >= 30 && time <= 180)));

			do
			{
				Console.WriteLine("Please Enter The Number Of Questions ");

			} while (!(int.TryParse(Console.ReadLine(), out numberOfQuestions) && (numberOfQuestions > 0)));


			if (examType == 1)
				SubjectExam = new PracticalExam(time, numberOfQuestions);
			else
				SubjectExam = new FinalExam(time, numberOfQuestions);
			Console.Clear();

			SubjectExam.CreateQuestions();


		}
	}
}
