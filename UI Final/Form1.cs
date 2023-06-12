namespace UI_Final 

{   using System;
    using System.Data.SqlClient;
    public partial class Form1 : Form
    {
        private DataSender dataSender;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
        string data = txtAboutUs.Text;
        dataSender.InsertData(data);
        //This would take you to the About us Page
    }

        private void btnAC_Click(object sender, EventArgs e)
        {
        string data = txtAC.Text;
        dataSender.InsertData(data);
        //This would send you to Avian consulting page
    }

        private void btnOurProducts_Click(object sender, EventArgs e)
        {
        string data = txtOurProducts.Text;
        dataSender.InsertData(data);
        //This would send you to the Our products page
    }

        private void btnFI_Click(object sender, EventArgs e)
        {
        string data = txtFI.Text;
        dataSender.InsertData(data);
        //This would send you to the For Investors page
    }
    }
}
