using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using BubbleSort.Logic;

namespace BubbleSort
{
	public partial class FrmBubbleSort : Form
	{
		// create BubbleSort and SortInputChecker instance
		readonly BubbleSorting m_bubbleSort = new BubbleSorting();
		readonly SortInputChecker m_sortInputChecker = new SortInputChecker();

		public FrmBubbleSort()
		{
			InitializeComponent();

			// create an array of textbox controls
			m_txbBubbleSortItemArray = new[] { m_txbBubbleSortItem1, m_txbBubbleSortItem2, m_txbBubbleSortItem3, m_txbBubbleSortItem4 };
		}

		void m_btnSort_Click( object sender, EventArgs e )
		{
			// creat a string array to store the texbox inpnt value
			string[] szSortInputArray = m_txbBubbleSortItemArray.Select( x => x.Text ).ToArray();

			// check if the input array values are valid floats
			bool isValid = m_sortInputChecker.IsValidFloat( szSortInputArray, out float[] sortArray, out List<int> errorSortArrayIndex );

			if( !isValid ) {
				string errorFields = string.Join( "、", errorSortArrayIndex.Select( s => s.ToString() ) );
				MessageBox.Show( $"Invalid input in column {errorFields}. Please enter a numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

				foreach( int nIndex in errorSortArrayIndex ) {
					m_txbBubbleSortItemArray[ nIndex - 1 ].Text = String.Empty;
				}
				return;
			}

			// if the input is valid, run the bubble sort 
			m_bubbleSort.Sort( ref sortArray );

			// sort values to the texbox controls
			for( int i = 0; i < sortArray.Length; i++ ) {
				m_txbBubbleSortItemArray[ i ].Text = sortArray[ i ].ToString();
			}
		}

		TextBox[] m_txbBubbleSortItemArray;
	}
}