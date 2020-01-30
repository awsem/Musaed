using Musaed.Lecturer.Dialogs;
using Musaed.Lecturer.Services;
using Musaed.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musaed.Lecturer.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Course _selectedCourse;

        private ObservableCollection<Course> _courses;

        public Course SelectedCourse
        {
            get { return _selectedCourse; }
            set
            {
                if (value == _selectedCourse)
                {
                    return;
                }
                _selectedCourse = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }


        public MainViewModel()
        {
            #region MyRegion


            /*
            Courses = new ObservableCollection<Course>()
            {
                new Course()
                {
                    Name = "Operating Systems",
                    Description = "Study of Linux and Windows Operating Sytems",
                    Assignments = new[]
                    {
                        new Assignment(){ Title = "Assignment 1" , Description = "Question 1", DueDate = DateTime.Now},
                        new Assignment(){ Title = "Assignment 2" , Description = "Question 1 & 2", DueDate = DateTime.Now}
                    },
                    Quizzes = new []
                    {
                        new Quiz(){ Title = "Quiz 1",Description = "Chapter 1",OnDate = DateTime.Now},
                        new Quiz(){ Title = "Quiz 2",Description = "Chapter 1 & 2",OnDate = DateTime.Now}
                    }
                },
                new Course()
                {
                    Name = "Networking",
                    Description = "Study of Linux and Windows Networking",
                       Assignments = new[]
                    {
                        new Assignment(){ Title = "Assignment 1" , Description = "Question 1", DueDate = DateTime.Now},
                        new Assignment(){ Title = "Assignment 2" , Description = "Question 1 & 2", DueDate = DateTime.Now}
                    },
                    Quizzes = new []
                    {
                        new Quiz(){ Title = "Quiz 1",Description = "Chapter 1",OnDate = DateTime.Now},
                        new Quiz(){ Title = "Quiz 2",Description = "Chapter 3",OnDate = DateTime.Now},
                        new Quiz(){ Title = "Quiz 3",Description = "Chapter 6",OnDate = DateTime.Now}
                    }
                },
                new Course()
                {
                    Name = "Digital Systems Design",
                    Description = "Study of Digital Systems Design",
                       Assignments = new[]
                    {
                        new Assignment(){ Title = "Assignment 1" , Description = "Question 1", DueDate = DateTime.Now},
                        new Assignment(){ Title = "Assignment 2" , Description = "Question 1 & 2", DueDate = DateTime.Now},
                        new Assignment(){ Title = "Assignment 3" , Description = "Question 3 & 4", DueDate = DateTime.Now}
                    },
                    Quizzes = new []
                    {
                        new Quiz(){ Title = "Quiz 1",Description = "Chapter 1",OnDate = DateTime.Now},
                        new Quiz(){ Title = "Quiz 2",Description = "Chapter 1 & 2",OnDate = DateTime.Now}
                    }
                }
            };

                */
            #endregion
        
            Courses = new ObservableCollection<Course>();

        }

       
        public async Task NewCourse()
        {
            await new NewCourseDialog().ShowAsync();
        }

    }

}
