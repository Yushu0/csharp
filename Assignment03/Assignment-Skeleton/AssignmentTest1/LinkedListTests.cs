using Assignment_Skeleton.utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest1
{
    public class LinkedListTests
    {
        //every test , SetUp→Test→TearDown

        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
            TestLogManager.Log("LinkedListTests  Setup() success");
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
            TestLogManager.Log("LinkedListTests  TearDown() success");
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            TestLogManager.Log("TestIsEmpty success");

            Assert.AreEqual(0, this.linkedList.Size());
            TestLogManager.Log("TestIsEmpty success, Size(): " + this.linkedList.Size().ToString());
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestAppendNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestAppendNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestAppendNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestAppendNode d success");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("TestAppendNode IsEmpty() success: " + this.linkedList.IsEmpty().ToString());


            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("TestAppendNode Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            TestLogManager.Log("TestAppendNode Retrieve(0) success: a 、 " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            TestLogManager.Log("TestAppendNode Retrieve(1) success: b 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(2));
            TestLogManager.Log("TestAppendNode Retrieve(2) success: c 、 " + this.linkedList.Retrieve(2).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
            TestLogManager.Log("TestAppendNode Retrieve(3) success: d 、  " + this.linkedList.Retrieve(3).ToString());
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            TestLogManager.Log("testPrependNodes a success");

            this.linkedList.Prepend("b");
            TestLogManager.Log("testPrependNodes b success");

            this.linkedList.Prepend("c");
            TestLogManager.Log("testPrependNodes c success");

            this.linkedList.Prepend("d");
            TestLogManager.Log("testPrependNodes d success");
            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("testPrependNodes IsEmpty() success: " + this.linkedList.IsEmpty().ToString());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("testPrependNodes Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("d", this.linkedList.Retrieve(0));
            TestLogManager.Log("testPrependNodes Retrieve(0) success: d 、  " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("c", this.linkedList.Retrieve(1));
            TestLogManager.Log("testPrependNodes Retrieve(1) success: c 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the third node value is c
            Assert.AreEqual("b", this.linkedList.Retrieve(2));
            TestLogManager.Log("testPrependNodes Retrieve(2) success: b 、 " + this.linkedList.Retrieve(2).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("a", this.linkedList.Retrieve(3));
            TestLogManager.Log("testPrependNodes Retrieve(3) success: a 、 " + this.linkedList.Retrieve(3).ToString());
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestInsertNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestInsertNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestInsertNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestInsertNode d success");

            this.linkedList.Insert("e", 2);
            TestLogManager.Log("TestInsertNode Insert(\"e\", 2) success");

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("TestInsertNode IsEmpty() success: " + this.linkedList.IsEmpty().ToString());

            // Test the size is 4
            Assert.AreEqual(5, this.linkedList.Size());
            TestLogManager.Log("TestInsertNode Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            TestLogManager.Log("TestInsertNode Retrieve(0) success: a 、 " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            TestLogManager.Log("TestInsertNode Retrieve(1) success: b 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));
            TestLogManager.Log("TestInsertNode Retrieve(2) success: e 、 " + this.linkedList.Retrieve(2).ToString());

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(3));
            TestLogManager.Log("TestInsertNode Retrieve(3) success: c 、 " + this.linkedList.Retrieve(3).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(4));
            TestLogManager.Log("TestInsertNode Retrieve(4) success: d 、 " + this.linkedList.Retrieve(4).ToString());
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestReplaceNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestReplaceNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestReplaceNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestReplaceNode d success");

            this.linkedList.Replace("e", 2);
            TestLogManager.Log("TestReplaceNode Replace(\"e\", 2) success");

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("TestReplaceNode IsEmpty() success: " + this.linkedList.IsEmpty().ToString());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());
            TestLogManager.Log("TestReplaceNode Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            TestLogManager.Log("TestReplaceNode Retrieve(3) success: a 、 " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            TestLogManager.Log("TestReplaceNode Retrieve(3) success: b 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));
            TestLogManager.Log("TestReplaceNode Retrieve(3) success: e 、 " + this.linkedList.Retrieve(2).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
            TestLogManager.Log("TestReplaceNode Retrieve(3) success: d 、 " + this.linkedList.Retrieve(3).ToString());
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestDeleteNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestDeleteNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestDeleteNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestDeleteNode d success");

            this.linkedList.Delete(2);
            TestLogManager.Log("TestDeleteNode Delete(2) success");
            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("TestDeleteNode IsEmpty() success: " + this.linkedList.IsEmpty().ToString());

            // Test the size is 4
            Assert.AreEqual(3, this.linkedList.Size());
            TestLogManager.Log("TestDeleteNode Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            TestLogManager.Log("TestDeleteNode Retrieve(0) success: e 、 " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            TestLogManager.Log("TestDeleteNode Retrieve(1) success: e 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(2));
            TestLogManager.Log("TestDeleteNode Retrieve(2) success: e 、 " + this.linkedList.Retrieve(2).ToString());
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestFindNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestFindNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestFindNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestFindNode d success");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);
            TestLogManager.Log("TestFindNode Contains(\"b\") success : " + contains.ToString());

            int index = this.linkedList.IndexOf("b");
            Assert.AreEqual(1, index);
            TestLogManager.Log("TestFindNode IndexOf(\"b\") success : " + index.ToString());

            string value = (string)this.linkedList.Retrieve(1);
            Assert.AreEqual("b", value);
            TestLogManager.Log("TestFindNode Retrieve(1) success: b 、 " + this.linkedList.Retrieve(1).ToString());
        }

        #region Extra Test Examples

        [Test]
        public void TestExtraExample1()
        {
            this.linkedList.Append("a");
            TestLogManager.Log("TestInsertNode a success");

            this.linkedList.Append("b");
            TestLogManager.Log("TestInsertNode b success");

            this.linkedList.Append("c");
            TestLogManager.Log("TestInsertNode c success");

            this.linkedList.Append("d");
            TestLogManager.Log("TestInsertNode d success");

            this.linkedList.Insert("e", 2);
            TestLogManager.Log("TestInsertNode Insert(\"e\", 2) success");

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());
            TestLogManager.Log("TestInsertNode IsEmpty() success: " + this.linkedList.IsEmpty().ToString());

            // Test the size is 4
            Assert.AreEqual(5, this.linkedList.Size());
            TestLogManager.Log("TestInsertNode Size() success: " + this.linkedList.Size().ToString());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));
            TestLogManager.Log("TestInsertNode Retrieve(0) success: a 、 " + this.linkedList.Retrieve(0).ToString());

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));
            TestLogManager.Log("TestInsertNode Retrieve(1) success: b 、 " + this.linkedList.Retrieve(1).ToString());

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));
            TestLogManager.Log("TestInsertNode Retrieve(2) success: e 、 " + this.linkedList.Retrieve(2).ToString());

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(3));
            TestLogManager.Log("TestInsertNode Retrieve(3) success: c 、 " + this.linkedList.Retrieve(3).ToString());

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(4));
            TestLogManager.Log("TestInsertNode Retrieve(4) success: d 、 " + this.linkedList.Retrieve(4).ToString());
        }



        #endregion
    }
}
