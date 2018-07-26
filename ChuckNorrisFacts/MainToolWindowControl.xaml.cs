namespace ChuckNorrisFacts
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Threading.Tasks;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Documents;

	/// <summary>
	/// Interaction logic for MainToolWindowControl.
	/// </summary>
	public partial class MainToolWindowControl : UserControl
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MainToolWindowControl"/> class.
		/// </summary>
		public MainToolWindowControl()
		{
			this.InitializeComponent();
			LoadAndAddFacts(5);
		}

		private void Button_Fact_Click(object sender, RoutedEventArgs e)
		{
			LoadAndAddFacts();
		}


		private void LoadAndAddFacts(int factCount = 1)
		{
			try
			{
				Facts facts = Task.Run(() => FactService.GetRandomFacts(factCount)).Result;

				facts.ForEach(fact =>
				{
					var blocks = FactsRichTextBox.Document.Blocks;
					if (blocks.Count == 0)
					{
						blocks.Add(new Paragraph(new Run(fact.Value.Joke)));
					}
					else
					{
						blocks.InsertBefore(
							blocks.FirstBlock,
							new Paragraph(new Run(fact.Value.Joke))
						);
					}
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}