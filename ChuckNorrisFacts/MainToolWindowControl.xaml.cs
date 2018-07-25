namespace ChuckNorrisFacts
{
    using System.Diagnostics.CodeAnalysis;
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

            for (int i = 0; i < 10; i++)
            {
                this.FactsRichTextBox.Document.Blocks.Add(new Paragraph(new Run("Paragraph " + i)));
            }
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "MainToolWindow");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
      string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
      "QQQQQ");
        }

        private void Button_Fact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}