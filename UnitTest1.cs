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
            AdditionToIndex add = new AdditionToIndex();
            CustomList<T>[] population = new CustomList<int> { };


            //Act
            add();
            int expected = 9;
            population<int> = T[5];
            int population.add = T[0];

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test Method]
        public void Add_AddAnotherIndexToArray_ArrayCountIncreases()
        {

            //Arrange
            CustomList<T>[] population = new CustomList<int> { };
            int[] test = new int(population.Count +1);
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
        public void Remove_TakeElementWithinArrayAway_ElementIsRemovedAndStoredWithinNewVariable()
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
