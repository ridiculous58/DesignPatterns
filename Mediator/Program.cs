using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher engin = new Teacher(mediator);
            engin.Name = "Engin";

            mediator.Teacher = engin;

            Student derin = new Student(mediator);
            derin.Name = "Derin";

            Student salih = new Student(mediator);
            salih.Name = "Salih";

            mediator.Students = new List<Student>{derin,salih};

            engin.SendNewImageUrl("Sldier.jpg");
            engin.ReceiveQuestion("is it true ? ",salih);

            Console.ReadLine();
        }
    }

    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Teacher : CourseMember
    {
        public Teacher(Mediator mediator) : base(mediator)
        {
        }

        public string Name { get; set; }

        public void ReceiveQuestion(string question, Student student)
        {
            Console.WriteLine($"{Name} Teacher recieved a question from {student.Name},{question} ");
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine($"{Name} Teacher changed slide : {url}");
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine($"Teacher answered question {answer},{student.Name}");
        }

     
    }

    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }
        public void RecieveImage(string url)
        {
            Console.WriteLine($"{Name} recived image(url) : {url}");
        }

        public void ReceiveAnswer(string answer, Student student)
        {
            Console.WriteLine($"Student : {student.Name}  received  answer : {answer}");
        }

        public string Name { get; set; }

       
    }

    class Mediator //Gorusmeyı saglayacak platform
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)//ogrencilerin hepsine mesaj
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher.ReceiveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer,student);
        }
    }
}
