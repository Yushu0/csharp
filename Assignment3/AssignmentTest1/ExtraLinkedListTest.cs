using Assignment_Skeleton.problemdomain;
using Assignment_Skeleton.utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest1
{
    internal class ExtraLinkedListTest
    {
        //every test , SetUp→Test→TearDown

        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
            TestLogManager.Log("ExtraLinkedList  Setup() success");
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
            TestLogManager.Log("ExtraLinkedList  TearDown() success");
        }

        [Test]
        public void ExtraExample1TestAppend()
        {
            var userList = new List<User>();
            var user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
            userList.Add(user);
            this.linkedList.Append(user);

            TestLogManager.Log("ExtraExample1TestAppend Append User success");

            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("ExtraExample1TestAppend Size() success");

            var node = Node.GetNode(this.linkedList, 0) as User;
            Assert.AreEqual(userList[0], node);
            TestLogManager.Log("ExtraExample1TestAppend AreEqual User success");
        }
        [Test]
        public void ExtraExample2TestInsert()
        {
            var userList = new List<User>();
            var user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            userList.Add(user);
            this.linkedList.Insert(user, 0);

            user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            userList.Add(user);
            this.linkedList.Insert(user, 0);

            user = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
            userList.Add(user);
            this.linkedList.Insert(user, 0);

            TestLogManager.Log("ExtraExample2TestInsert Append User success");

            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("ExtraExample2TestInsert Size() success");

            var node = Node.GetNode(this.linkedList, 0) as User;
            Assert.AreEqual(userList[3], node);
            TestLogManager.Log("ExtraExample2TestInsert AreEqual User success");
        }

        [Test]
        public void ExtraExample3TestReplace()
        {
            var userList = new List<User>();
            var user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
            userList.Add(user);
            this.linkedList.Append(user);
            TestLogManager.Log("ExtraExample3TestReplace Append User success");

            user = new User(5, "Lucy", "159638164@outlook.com", "lucy999");
            userList.RemoveAt(2);
            userList.Insert(2, user);
            this.linkedList.Replace(user, 2);
            TestLogManager.Log("ExtraExample3TestReplace Append User success");

            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("ExtraExample3TestReplace Size() success");

            var node = Node.GetNode(this.linkedList, 2) as User;
            Assert.AreEqual(userList[2], node);
            TestLogManager.Log("ExtraExample3TestReplace AreEqual User success");
        }

        [Test]
        public void ExtraExample4TestDelete()
        {
            var userList = new List<User>();
            var user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
            userList.Add(user);
            this.linkedList.Append(user);
            TestLogManager.Log("ExtraExample4TestDelete Append User success");

            this.linkedList.Delete(2);
            userList.RemoveAt(2);
            TestLogManager.Log("ExtraExample4TestDelete Delete User success");

            Assert.AreEqual(3, this.linkedList.Size());
            TestLogManager.Log("ExtraExample4TestDelete Size() success");

            var node = Node.GetNode(this.linkedList, 1) as User;
            Assert.AreEqual(userList[1], node);
            TestLogManager.Log("ExtraExample4TestDelete AreEqual User success");
        }

        [Test]
        public void ExtraExample5TestSetNode()
        {
            var userList = new List<User>();
            var user = new User(1, "Joe Blow", "jblow@gmail.com", "password");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
            userList.Add(user);
            this.linkedList.Append(user);

            user = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
            userList.Add(user);
            this.linkedList.Append(user);

            Node.SetNode(this.linkedList, user, 2);
            userList.Insert(2, user);

            TestLogManager.Log("ExtraExample5TestSetNode Append User success");

            Assert.AreEqual(5, this.linkedList.Size());
            TestLogManager.Log("ExtraExample5TestSetNode Size() success");

            var node = Node.GetNode(this.linkedList, 2) as User;
            Assert.AreEqual(userList[2], node);
            TestLogManager.Log("ExtraExample5TestSetNode AreEqual User success");
        }
    }
}
