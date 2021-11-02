using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusinessLayer.ComboBoxItem;

namespace LoanCalculator
{
    public partial class FrmHome : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void PnPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmHome()
        {
            InitializeComponent();
        }

        private void LoadComboBox() {
                      
            ComboBoxItem MonthlyAmount = new ComboBoxItem {
                Text = "Select a Month",
                Value = null
            };

            CbxMonthlyDues.Items.Add(MonthlyAmount);

            int[] Month = new int[19];

            Month[0]=12;
            MonthlyAmount.Text = Convert.ToString($"{Month[0]} Month");
            MonthlyAmount.Value = 1;
            CbxMonthlyDues.Items.Add(MonthlyAmount);

            for (int i = 1; i < 19; i++)
            {
                Month[i] = Month[i-1] + 6;
                MonthlyAmount.Text = Convert.ToString($"{Month[i]} Month");
                MonthlyAmount.Value = i;
                CbxMonthlyDues.Items.Add(MonthlyAmount);
            }

            ComboBoxItem LoanType = new ComboBoxItem{
                Text = "Select a Type",
                Value = null
            };
            ComboBoxItem LoanPersonal = new ComboBoxItem
            {
                Text = "Personal Loan",
                Value = 1
            };
            ComboBoxItem AutoLoan = new ComboBoxItem { 
            
            Text = "Auto Loan",
            Value = 2
            };

            ComboBoxItem MortgageLoan = new ComboBoxItem
            {
                Text = "Mortgage Loan",
                Value = 3
            };

            CbxTypeofLoan.Items.Add(LoanType);
            CbxTypeofLoan.Items.Add(LoanPersonal);
            CbxTypeofLoan.Items.Add(AutoLoan);
            CbxTypeofLoan.Items.Add(MortgageLoan);

        }
    }
}
