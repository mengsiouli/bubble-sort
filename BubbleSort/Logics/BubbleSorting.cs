namespace BubbleSort
{
	public partial class BubbleSorting
	{
		// swap neighboring value
		public void SwapValue( ref float SwapA, ref float SwapB )
		{
			float temp = SwapA;
			SwapA = SwapB;
			SwapB = temp;
		}

		public float[] Sort( ref float[] sortArray )
		{
			for( int i = 0; i < sortArray.Length - 1; i++ ) {
				for( int j = 0; j < sortArray.Length - i - 1; j++ ) {
					if( sortArray[ j ] > sortArray[ j + 1 ] ) {
						SwapValue( ref sortArray[ j ], ref sortArray[ j + 1 ] );
					}
				}
			}
			return sortArray;
		}
	}
}