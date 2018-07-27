namespace ChuckNorrisFacts
{
	using System;
	using System.Collections.Generic;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Documents;

	public partial class MainToolWindowControl : UserControl
	{

		public MainToolWindowControl()
		{
			this.InitializeComponent();
			LoadAndAddFacts(5);
		}

		private void Button_Fact_Click(object sender, RoutedEventArgs e)
		{
			LoadAndAddFacts();
			FactsScrollViewer.ScrollToTop();
		}


		private async void LoadAndAddFacts(int factCount = 1)
		{
			try
			{
				RefreshButton.IsEnabled = false;
				List<Fact> facts = await FactService.GetRandomFacts(factCount);
				RefreshButton.IsEnabled = true;

				facts.ForEach(fact =>
				{
					var blocks = FactsRichTextBox.Document.Blocks;
					if (blocks.Count == 0)
					{
						blocks.Add(new Paragraph(new Run(fact.Joke)));
					}
					else
					{
						blocks.InsertBefore(
							blocks.FirstBlock,
							new Paragraph(new Run(fact.Joke))
						);
					}
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.ToString(), 
					"Error", 
					MessageBoxButton.OK, 
					MessageBoxImage.Error
				);
			}
		}
	}
}