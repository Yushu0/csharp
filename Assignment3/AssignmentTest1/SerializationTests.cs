using Assignment_Skeleton.problemdomain;
using Assignment_Skeleton.utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest1
{
    public class SerializationTests
    {
        private List<User> users = new List<User>();
        private readonly string testFileName = "test_users.bin";

        [SetUp]
        public void Setup()
        {
            users.Append(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.Append(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.Append(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.Append(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));

            TestLogManager.Log("SerializationTests  Setup success");
        }

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
            TestLogManager.Log("SerializationTests  TearDown() success");
        }

        //Tests the object was serialized.
        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            TestLogManager.Log("SerializationTests  TestSerialization() SerializeUsers success");
            Assert.IsTrue(File.Exists(testFileName));
            TestLogManager.Log("SerializationTests  TestSerialization() File.Exists(testFileName) success");
        }

        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            List<User> deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            Assert.AreEqual(users.Count, deserializedUsers.Count);
            for (int i = 0; i < users.Count; i++)
            {
                Assert.AreEqual(users[i].Id, deserializedUsers[i].Id);
                Assert.AreEqual(users[i].Name, deserializedUsers[i].Name);
                Assert.AreEqual(users[i].Email, deserializedUsers[i].Email);
                Assert.AreEqual(users[i].Password, deserializedUsers[i].Password);
                TestLogManager.Log("SerializationTests  TestDeSerialization() success: " + users[i].ToString() + " 、 " + deserializedUsers[i].ToString());
            }

            TestLogManager.Log("SerializationTests  TestDeSerialization() success");
        }

    }
}
