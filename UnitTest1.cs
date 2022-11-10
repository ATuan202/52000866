using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Xml.Linq;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Toan";
            s.Age = 30;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score_7_should_be_B()
        {
            Student s = new Student();
            s.Id = 52000866;
            s.Name = "Tuan";
            s.Age = 20;
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);

        }
        [TestMethod]
        public void Score_5_should_be_C()
        {
            Student s = new Student();
            s.Id = 52000866;
            s.Name = "Tuan";
            s.Age = 20;
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);

        }
        [TestMethod]
        public void Score_4_should_be_D()
        {
            Student s = new Student();
            s.Id = 52000866;
            s.Name = "Tuan";
            s.Age = 20;
            s.Score = 4;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);

        }

        [TestMethod]
        public void addFirstStudent_ShouldAccess_AndReturn_True()
        {
            StudentService s = new StudentService();
            Student s1 = new Student() { Id = 1, Name = "Tuan", Age =20 , Score = 10 };
            bool status = s.addStudent(s1);
            Assert.IsTrue(status);

            int size = s.size();
            Assert.AreEqual(1, size);

        }

        [TestMethod]
        public void addStudent_ShouldNotAccess_AndReturn_False()
        {
            StudentService s = new StudentService();
            Student s1 = new Student() { Id = 1, Name = "Tuan", Age = 20, Score = 10 };
            Student s2 = new Student() { Id = 1, Name = "Tuan", Age = 20, Score = 10 };
            bool status = s.addStudent(s1);
            bool status1 = s.addStudent(s2);
            Assert.IsFalse(status1);


        }
        [TestMethod]
        public void addStudent_ShouldAccess_AndReturn_True()
        {
            StudentService s = new StudentService();
            Student s1 = new Student() { Id = 1, Name = "Tuan", Age = 20, Score = 10 };
            int size = s.size();
            bool status = s.addStudent(s1);
            Assert.IsTrue(status);

            
            int size1 = s.size();
            Assert.AreEqual(size1-1, size);

        }
        [TestMethod]
        public void addStudent_ShouldNotAccess_AndReturn_False()
        {
            StudentService s = new StudentService();
            Student s1 = new Student() { Id = 1, Name = "Tuan", Age = 20, Score = 10 };
            Student s2 = new Student() { Id = 1, Name = "Tuan", Age = 20, Score = 10 };
            bool status = s.addStudent(s1);
            bool status1 = s.addStudent(s2);
            Assert.IsFalse(status1);


        }






    }
}