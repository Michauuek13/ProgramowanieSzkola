using System;
using System.ComponentModel;

namespace CollectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCollection testCollection = new TestCollection();
            //testCollection.TestArray();
            //testCollection.TestObjectArrayCollection();
            //testCollection.ListCollection();
            TestListCollection testListCollection = new TestListCollection();
            //testListCollection.FirstTest();
            TestListOfObject testListOfObject = new TestListOfObject();
            testListOfObject.Test();
        }
    }
}
