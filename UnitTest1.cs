using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListTest1
    {







        [TestMethod]
        public void Add_ElementIntoIndexOfArrayForList_ElementIsAddedIntoEachIndex()
        {

            //Arrange
            CustomList<T>[] population = new CustomList<int>();


            //Act
            int population = new CustomList[5];
            int expected = population.add[0] = (9);
             population.add[1] = (6);
             population.add[2] = (4);
             population.add[3] = (2);
             population.add[4] = (3);




            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test Method]
        public void Add_AddAnotherIndexToArray_ArrayCountIncreases()
        {

            //Arrange
            CustomList<T>[] population = new CustomList<int> { };
            int[] test = new int(population.Count + 1);
            for (int i = 0; i < population.Count; i++)
            {
                test[i] = population[i];
            }

            //Act
            expected = test.add(1);
            actual = test.Count;


            //Assert

            Assert.AreEqual(expected, actual);

        }

        [Test Method]
        public void Remove_TakeElementFromArray_ElementIsStoredWithinNewIndex()
        {
            //Arrange
            CustomList<T>[] population = new CustomList<int> { };
            for (int i = population.Count() - 1; i > 0; i--)
            {
                if (population.Capacity > 15)
                {
                    population.Remove(0);
                }
            }





            //Act
            expected = population.Remove(1);
            actual = Console.WriteLine(population[0]);



            //Assert
            Assert.AreEqual(expected, actual);
        }



        [Test Method]
        public void Remove_RemoveOneDuplicatedElement_OtherDuplicatesStayWithinArray
        {
            //Arrange



            //Act
           expected = population.Remove(5);
            actual = population[]
            


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test Method]
        public void Remove_TakeElementFromArray_ElementGoesToIndex0()
        {
        //Arrange





        //Act
        expected = population.Count - 1;




            //Assert
            Assert.AreEqual(expected, actual);



        }

        [Test Method]
        public void Remove_TakeElementFromArray_NumberOfIndexShouldBeReduced()
        {
        //Arrange

        CustomList<T>[] population = new CustomList<int> { };
        for (int i = population.Count() - 1; i > 0; i--)
        {
            if (population.Capacity > 10)
            {
                population.Remove(0);
            }
        }



        //Act





        //Assert
        Assert.AreEqual(expected, actual);








        }

        [Test Method]
        public void Remove_TakeElementFromEmptyArray_IndexIsStillZero()
        {
            //Arrange





            //Act





            //Assert
            Assert.AreEqual(expected, actual);










        }
    }
}






// if i add something to a populated customlist, it should go to index 0
// if i add something to customlist whose inner array is full, it should still add the item


//[TestMethod]
//public void Add_AddToEmptyList_ItemShouldGoToIndexZero()
//{
    // arrange
 //   CustomList<int> test = new CustomList<int>();
 //   int expected = 8;
 //   int actual;
    // act
 //   test.Add(8);
 //   actual = test[0];
    // assert
 //   Assert.AreEqual(expected, actual);
//}
//[TestMethod]
//public void Add_AddToEmptyList_CountShouldIncreaseToOne()
//{
    // arrange
 //   CustomList<int> test = new CustomList<int>();
 //   int expected = 1;
 //   int actual;
    // act
 //   test.Add(8);
//    actual = test.Count;
    // assert
//    Assert.AreEqual(expected, actual);
//}
