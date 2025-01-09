/*
This application is a simple console application that automates the calculation of grades for each student in a class.
The application reads the student's name, the number of exams, and each exam score.
The application calculates the average exam score and assigns a letter grade based on the average.
The application then displays the student's name, average exam score, and letter grade.
*/

Random random = new();

int[,] studentScores = {
     { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100) },
     { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100) },
     { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100) },
     { random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100) }
     };
int average = 0;
int sum = 0;

foreach (int score in studentScores)
{
    sum += score;
    average = sum / studentScores.Length;
}
