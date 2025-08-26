# Examination System

A C# console application designed to manage and conduct exams, built with a strong focus on Object-Oriented principles.

---

## 🚀 Key Features

- **Question Modeling:**  
  Supports both Multiple Choice (`MCQ`) and True/False (`TF`) questions, inheriting from a base `Question` class with properties for header, body, mark, and answers.

- **Flexible Exam Types:**  
  The application supports two distinct exam formats:
  - **Final Exam:** A comprehensive test including both `MCQ` and `TF` questions.
  - **Practical Exam:** A focused test containing only `MCQ` questions.

- **Answer Management:**  
  A dedicated `Answer` class to handle answer options, correct answer validation, and result evaluation.

- **Extensible Exam Structure:**  
  A base `Exam` class defines common attributes (time, number of questions). Subclasses (`FinalExam`, `PracticalExam`) provide specific implementations for how the exam is displayed and graded.

- **Subject Association:**  
  Each exam is logically linked to a `Subject`, allowing for organized exam creation and management per subject.

- **Clear Result Display:**  
  - **Practical Exam:** Provides immediate feedback by showing correct answers after completion.
  - **Final Exam:** Delivers a summary including all questions, user answers, and the final grade.

---

## 🛠️ Tech Stack

- **Language:** C#
- **Core Concepts:** Object-Oriented Programming (Inheritance, Polymorphism), SOLID Principles.

---

## 🏛️ Project Structure

- `` `Program.cs` ``: Entry point of the application.
- `` `Exam.cs` ``: Base class for exams.
- `` `FinalExam.cs` ``: Implementation for final exams.
- `` `PracticalExam.cs` ``: Implementation for practical exams.
- `` `Question.cs` ``: Base class for questions.
- `` `MCQ_Question.cs` ``: MCQ question implementation.
- `` `TF_Question.cs` ``: True/False question implementation.
- `` `Answer.cs` ``: Handles answers and evaluation logic.

---

## 📊 Class Diagram

![Class Diagram](https://github.com/saramaged12/Examination-System/blob/master/ExaminationSystem%20Class%20Diagram.drawio.png?raw=true)

---

## 🏁 Getting Started


  **Clone the repository:**
    ```sh
    git clone  https://github.com/saramaged12/Examination-System.git
    ```



