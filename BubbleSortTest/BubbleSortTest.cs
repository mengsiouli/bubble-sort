using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleSortTest
{
	#region SortInputChecker_UT

	[TestClass]
	public class SortInputCheckerTest
	{
		readonly SortInputChecker m_checker = new SortInputChecker();

		[DataRow( new string[] { "-3.5E+38", " -1", "0", "1" } )]
		[DataRow( new string[] { "-1", "0", "1", "3.5E+38" } )]
		[DataRow( new string[] { "b", "s", "J", "K" } )]
		[DataRow( new string[] { "^", "*", "/", "" } )]

		[TestMethod]
		public void IsValidFloat_WhenArrayContainsInvalidFormat_ShouldReturnFalse( string[] szSortInputArray )
		{
			// act
			bool isValid = m_checker.IsValidFloat( szSortInputArray, out _, out _ );

			// assert
			Assert.IsFalse( isValid );
		}

		[DataRow( new string[] { "-3.4E+38", " -1", "0", "1" } )]
		[DataRow( new string[] { "-1", "0", "1", "3.4E+38" } )]
		[DataRow( new string[] { "22684", "-5816", "348498", "-1784" } )]
		[DataRow( new string[] { "3.878", "-4.464", "7.898", "6.666" } )]

		[TestMethod]
		public void IsValidFloat_WhenArrayIsAllValidFormat_ShouldReturnTrue( string[] szSortInputArray )
		{
			// act
			bool isValid = m_checker.IsValidFloat( szSortInputArray, out _, out _ );

			// assert
			Assert.IsTrue( isValid );
		}
	}
	#endregion

	#region BubbleSorting_UT

	[TestClass]
	public class BubbleSortingTest
	{
		readonly BubbleSorting m_sorter = new BubbleSorting();

		[DataRow( new float[] { 3, 333, 33, 0.3f }, new float[] { 0.3f, 3, 33, 333 } )]
		[DataRow( new float[] { -17, -7.5f, -6.6f, -97 }, new float[] { -97, -17, -7.5f, -6.6f } )]
		[DataRow( new float[] { -8, 0, 7, -9 }, new float[] { -9, -8, 0, 7 } )]

		[TestMethod]
		public void Sort_WhenArrayIsUnsorted_ShouldOrderElementsAscending( float[] sortArray, float[] bubbleSortExpectedArray )
		{
			// act
			m_sorter.Sort( ref sortArray );

			// assert
			CollectionAssert.AreEqual( bubbleSortExpectedArray, sortArray );
		}

		[DataRow( 61f, 78f, 78f, 61f )]
		[DataRow( 6.21f, 7.6558f, 7.6558f, 6.21f )]

		[TestMethod]
		public void SwapValue_WhenInputsAreTwoDifferentFloats_ShouldBeExchanged( float inputA, float inputB, float expectedA, float expectedB )
		{
			// act
			m_sorter.SwapValue( ref inputA, ref inputB );

			// assert
			Assert.AreEqual( expectedA, inputA, 0.00001f, "Value A was not swapped correctly." );
			Assert.AreEqual( expectedB, inputB, 0.00001f, "Value B was not swapped correctly." );
		}
	}

	#endregion
}
