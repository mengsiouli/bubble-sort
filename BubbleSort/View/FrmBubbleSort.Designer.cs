namespace BubbleSort
{
	partial class FrmBubbleSort
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_txbBubbleSortItem1 = new System.Windows.Forms.TextBox();
			this.m_lblBubbleSortInput = new System.Windows.Forms.Label();
			this.m_btnSort = new System.Windows.Forms.Button();
			this.m_txbBubbleSortItem2 = new System.Windows.Forms.TextBox();
			this.m_txbBubbleSortItem3 = new System.Windows.Forms.TextBox();
			this.m_txbBubbleSortItem4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_txbBubbleSortItem1
			// 
			this.m_txbBubbleSortItem1.Font = new System.Drawing.Font( "微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_txbBubbleSortItem1.Location = new System.Drawing.Point( 41, 96 );
			this.m_txbBubbleSortItem1.Multiline = true;
			this.m_txbBubbleSortItem1.Name = "m_txbBubbleSortItem1";
			this.m_txbBubbleSortItem1.Size = new System.Drawing.Size( 100, 56 );
			this.m_txbBubbleSortItem1.TabIndex = 0;
			// 
			// m_lblBubbleSortInput
			// 
			this.m_lblBubbleSortInput.AutoSize = true;
			this.m_lblBubbleSortInput.Font = new System.Drawing.Font( "微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_lblBubbleSortInput.Location = new System.Drawing.Point( 34, 34 );
			this.m_lblBubbleSortInput.Name = "m_lblBubbleSortInput";
			this.m_lblBubbleSortInput.Size = new System.Drawing.Size( 431, 40 );
			this.m_lblBubbleSortInput.TabIndex = 5;
			this.m_lblBubbleSortInput.Text = "Please Input Four Numbers:";
			// 
			// m_btnSort
			// 
			this.m_btnSort.Font = new System.Drawing.Font( "微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_btnSort.Location = new System.Drawing.Point( 580, 96 );
			this.m_btnSort.Name = "m_btnSort";
			this.m_btnSort.Size = new System.Drawing.Size( 129, 56 );
			this.m_btnSort.TabIndex = 4;
			this.m_btnSort.Text = "Sort";
			this.m_btnSort.UseVisualStyleBackColor = true;
			this.m_btnSort.Click += new System.EventHandler( this.m_btnSort_Click );
			// 
			// m_txbBubbleSortItem2
			// 
			this.m_txbBubbleSortItem2.Font = new System.Drawing.Font( "微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_txbBubbleSortItem2.Location = new System.Drawing.Point( 173, 96 );
			this.m_txbBubbleSortItem2.Multiline = true;
			this.m_txbBubbleSortItem2.Name = "m_txbBubbleSortItem2";
			this.m_txbBubbleSortItem2.Size = new System.Drawing.Size( 100, 56 );
			this.m_txbBubbleSortItem2.TabIndex = 1;
			// 
			// m_txbBubbleSortItem3
			// 
			this.m_txbBubbleSortItem3.Font = new System.Drawing.Font( "微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_txbBubbleSortItem3.Location = new System.Drawing.Point( 305, 96 );
			this.m_txbBubbleSortItem3.Multiline = true;
			this.m_txbBubbleSortItem3.Name = "m_txbBubbleSortItem3";
			this.m_txbBubbleSortItem3.Size = new System.Drawing.Size( 100, 56 );
			this.m_txbBubbleSortItem3.TabIndex = 2;
			// 
			// m_txbBubbleSortItem4
			// 
			this.m_txbBubbleSortItem4.Font = new System.Drawing.Font( "微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 136 ) ) );
			this.m_txbBubbleSortItem4.Location = new System.Drawing.Point( 437, 96 );
			this.m_txbBubbleSortItem4.Multiline = true;
			this.m_txbBubbleSortItem4.Name = "m_txbBubbleSortItem4";
			this.m_txbBubbleSortItem4.Size = new System.Drawing.Size( 100, 56 );
			this.m_txbBubbleSortItem4.TabIndex = 3;
			// 
			// FrmBubbleSort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 13F, 24F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 744, 190 );
			this.Controls.Add( this.m_txbBubbleSortItem4 );
			this.Controls.Add( this.m_txbBubbleSortItem3 );
			this.Controls.Add( this.m_txbBubbleSortItem2 );
			this.Controls.Add( this.m_btnSort );
			this.Controls.Add( this.m_lblBubbleSortInput );
			this.Controls.Add( this.m_txbBubbleSortItem1 );
			this.Name = "FrmBubbleSort";
			this.Text = "BubbleSort";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox m_txbBubbleSortItem1;
		private System.Windows.Forms.Label m_lblBubbleSortInput;
		private System.Windows.Forms.Button m_btnSort;
		private System.Windows.Forms.TextBox m_txbBubbleSortItem2;
		private System.Windows.Forms.TextBox m_txbBubbleSortItem3;
		private System.Windows.Forms.TextBox m_txbBubbleSortItem4;
	}
}

