using System.Collections.Generic;

namespace BubbleSort
{
	public partial class SortInputChecker
	{
		// validate whether szInput is an integer within the allowed range
		public bool IsValidFloat( string[] szSortInputArray, out float[] sortArray, out List<int> errorSortIndex )
		{
			// initialize output
			sortArray = new float[ szSortInputArray.Length ];
			errorSortIndex = new List<int>();

			// validate each input array is an float within the allowed range
			for( int i = 0; i < szSortInputArray.Length; i++ ) {
				bool isValid = float.TryParse( szSortInputArray[ i ], out sortArray[ i ] );
				if( !isValid ) {
					errorSortIndex.Add( i+1 );
				}
			}
			return errorSortIndex.Count == 0;
		}
	}
}