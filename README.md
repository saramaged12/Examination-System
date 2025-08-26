# Examination System

## Description

The **Examination System** is a C# console application designed to manage and conduct exams for different subjects. 
The system is built using object-oriented principles, featuring a flexible structure to support various exam and question types.

### Key Features

- **Question Modeling:**  
  Each question has a header, body, mark, and is associated with a list of possible answers. The system supports both Multiple Choice Questions (MCQ) and True/False (TF) questions, using a base `Question` class with specialized subclasses for each type.

- **Exam Types:**  
  The application supports two types of exams:
  - **Final Exam:** Includes both MCQ and True/False questions.
  - **Practical Exam:** Includes only MCQ questions.

- **Answer Management:**  
  Answers are represented by a dedicated class containing an answer ID and answer text. Each question maintains an array of possible answers and the correct answer.

- **Exam Structure:**  
  A base `Exam` class defines common attributes such as exam time, number of questions, and a method to display the exam. This method is implemented differently for each exam type.

- **Subject Association:**  
  Each exam is linked to a subject, represented by a `Subject` class containing a subject ID, name, and its associated exam. The system allows for the creation of exams for each subject.

- **Result Display:**  
  - **Practical Exam:** Shows the correct answers after the exam is completed.
  - **Final Exam:** Displays all questions, answers, and the final grade.

- **User Interaction:**  
  The main program allows users to create a subject and generate an exam for it, following the requirements for each exam type.

## Project Structure

- `Program.cs` - Entry point of the application
- `Exam.cs` - Base class for exams
- `FinalExam.cs` - Implementation for final exams
- `PracticalExam.cs` - Implementation for practical exams
- `Question.cs` - Base class for questions
- `MCQ Question.cs` - MCQ question implementation
- `TF Question.cs` - True/False question implementation
- `Answer.cs` - Handles answers and evaluation logic

## Getting Started

1. **Clone the repository:**

   git clone : https://github.com/saramaged12/Examination-System.git
   
   
