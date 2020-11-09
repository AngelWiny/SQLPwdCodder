using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLPwdCodder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         private void btnCode_Clicked(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;
                txtResult.Text = new PwdCodder().CodePassword(txtpwd.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message + "\n\n" + ex.InnerException?.Message;
            }
        }

        private void btnDecode_Clicked(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = string.Empty;
                txtResult.Text = new PwdCodder().DecodePassword(txtpwd.Text);
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message + "\n\n" + ex.InnerException?.Message;
            }
        }

       
    }
}
