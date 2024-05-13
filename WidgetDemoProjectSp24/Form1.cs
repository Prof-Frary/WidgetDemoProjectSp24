namespace WidgetDemoProjectSp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add(Widget.RED);
            cboColor.Items.Add(Widget.BLUE);
            cboColor.Items.Add(Widget.YELLOW);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Widget w;
            double price;
            Boolean priceValid;
            priceValid = double.TryParse(txtPrice.Text, out price);
            if (priceValid)
            {
                w = new Widget(txtWName.Text.Trim(), cboColor.SelectedItem.ToString(), txtWDescription.Text, price);
                lstOut.Items.Add(w.WidgetName);
                lstOut.Items.Add(w.Color);
                lstOut.Items.Add(w.Description);
                lstOut.Items.Add(w.Price.ToString("C"));
                lstOut.Items.Add(w.ToString());
            }
            else
            {

            }
        }
    }
}
