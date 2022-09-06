﻿// Grade book using an array to store test grades.
using System;

namespace GradeBook
{
    public class GradeBook
    {
        private int[] grades; // array of student grades

        // auto-implemented property CourseName
        public string CourseName { get; set; }

        // two-parameter constructor initializes  
        // auto-implemented property CourseName and grades array
        public GradeBook(string name, int[] gradesArray)
        {
            CourseName = name; // set CourseName to name
            grades = gradesArray; // initialize grades array
        } // end two-parameter GradeBook constructor

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // auto-implemented property CourseName gets the name of course
            Console.WriteLine("Welcome to the grade book for\n{0}!\n",
               CourseName);
        } // end method DisplayMessage

        // perform various operations on the data
        public void ProcessGrades()
        {
            // output grades array
            OutputGrades();

            // call method GetAverage to calculate the average grade      
            Console.WriteLine("\nClass average is {0:F}", GetAverage());

            // call methods GetMinimum and GetMaximum
            Console.WriteLine("Lowest grade is {0}\nHighest grade is {1}\n",
               GetMinimum(), GetMaximum());

            // call OutputBarChart to display grade distribution chart
            OutputBarChart();
        } // end method ProcessGrades

        // find minimum grade
        public int GetMinimum()
        {
            int lowGrade = grades[0]; // assume grades[ 0 ] is smallest

            // loop through grades array
            foreach (int grade in grades)
            {
                // if grade lower than lowGrade, assign it to lowGrade
                if (grade < lowGrade)
                    lowGrade = grade; // new lowest grade
            } // end for

            return lowGrade; // return lowest grade
        } // end method GetMinimum

        // find maximum grade
        public int GetMaximum()
        {
            int highGrade = grades[0]; // assume grades[ 0 ] is largest

            // loop through grades array
            foreach (int grade in grades)
            {
                // if grade greater than highGrade, assign it to highGrade
                if (grade > highGrade)
                    highGrade = grade; // new highest grade
            } // end for

            return highGrade; // return highest grade
        } // end method GetMaximum

        // determine average grade for test
        public double GetAverage()
        {
            int total = 0; // initialize total

            // sum grades for one student
            foreach (int grade in grades)
                total += grade;

            // return average of grades
            return (double)total / grades.Length;
        } // end method GetAverage

        // output bar chart displaying grade distribution
        public void OutputBarChart()
        {
            Console.WriteLine("Grade distribution:");

            // stores frequency of grades in each range of 10 grades
            int[] frequency = new int[11];

            // for each grade, increment the appropriate frequency 
            foreach (int grade in grades)
                ++frequency[grade / 10];

            // for each grade frequency, display bar in chart
            for (int count = 0; count < frequency.Length; ++count)
            {
                // output bar label ( "00-09: ", ..., "90-99: ", "100: " )
                if (count == 10)
                    Console.Write("  100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ",
                       count * 10, count * 10 + 9);

                // display bar of asterisks
                for (int stars = 0; stars < frequency[count]; ++stars)
                    Console.Write("*");

                Console.WriteLine(); // start a new line of output
            } // end outer for
        } // end method OutputBarChart

        // output the contents of the grades array
        public void OutputGrades()
        {
            Console.WriteLine("The grades are:\n");

            // output each student's grade
            for (int student = 0; student < grades.Length; ++student)
                Console.WriteLine("Student {0,2}: {1,3}",
                   student + 1, grades[student]);
        } // end method OutputGrades
    } // end class GradeBook

}