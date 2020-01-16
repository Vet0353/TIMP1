using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Education edu = new School(new DStudent());
            edu.Learn();
            edu = new Baccalaureate(new CStudent());
            edu.Learn();
            edu = new Magistracy(new AStudent());
            edu.Learn();
            Console.ReadKey();
        }
    }
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public abstract void PassExams();
        public abstract void GetDocument();
    }

    interface IStudent
    {
        void Method();
        string Result();
    }
    public class AStudent : IStudent
    {
        public void Method()
        {
            Console.WriteLine("Выполняем все задания вовремя, и стремимся к новым знаниям");
        }

        public string Result()
        {
            return " с отличием";
        }
    }

    public class CStudent : IStudent
    {
        public void Method()
        {
            Console.WriteLine("Выполняем не все задания, иногда не вовремя");
        }

        public string Result()
        {
            return "";
        }
    }

    public class DStudent : IStudent
    {
        public void Method()
        {
            Console.WriteLine("Игнорируем задания, расчитываем на чудо, молимся");
        }

        public string Result()
        {
            return " с одними тройками";
        }
    }

    class School : Education
    {
        IStudent Student { get; set; }
        public School(IStudent student)
        {
            Student = student;
        }
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем уроки");
            Student.Method();
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании" + Student.Result());
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаём выпускные экзамены");
        }
    }

    class Baccalaureate : Education
    {
        IStudent Student { get; set; }
        public Baccalaureate(IStudent student)
        {
            Student = student;
        }
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ на бакалавриат");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
            Console.WriteLine("Выполняем лабораторные работы");
            Student.Method();
        }

        public override void PassExams()
        {
            Console.WriteLine("Защищаем ВКР бакалавра");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом бакалавра" + Student.Result());
        }
    }

    
    class Magistracy : Education
    {
        IStudent Student { get; set; }
        public Magistracy(IStudent student)
        {
            Student = student;
        }
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ на магистратуру");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
            Console.WriteLine("Выполняем научную работу");
            Student.Method();
        }

        public override void PassExams()
        {
            Console.WriteLine("Защищаем ВКР магистра");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом магистра" + Student.Result());
        }
    }
}
