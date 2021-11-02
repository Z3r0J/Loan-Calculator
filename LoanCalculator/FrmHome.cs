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
using BusinessLayer;

namespace LoanCalculator
{
    public partial class FrmHome : Form
    {

        public bool IsCalculate { get; set; } = false;
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

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            LoanCalc();
        }
        public FrmHome()
        {
            InitializeComponent();
        }

        private void LoanCalc() {
            try
            {

                ComboBoxItem SelectedMonthly = CbxMonthlyDues.SelectedItem as ComboBoxItem;
                ComboBoxItem SelectedLoanType = CbxTypeofLoan.SelectedItem as ComboBoxItem;

                if (SelectedMonthly.Value == null)
                {
                    string Message = "Please, Select a Monthly Amount";
                    FrmNotify Warning = new FrmNotify(Message);
                    Warning.Show();
                }
                else if (SelectedLoanType.Value == null)
                {
                    string Message = "Please, Select a Loan Type";
                    FrmNotify Warning = new FrmNotify(Message);
                    Warning.Show();
                }
                else if (string.IsNullOrEmpty(TxtLoanAmount.Text))
                {
                    string Message = "Please, Insert a Loan Amount";
                    FrmNotify Warning = new FrmNotify(Message);
                    Warning.Show();
                }
                else
                {
                    LoanCalc loan = new LoanCalc();
                    double Amount = Convert.ToDouble(TxtLoanAmount.Text);
                    int MonthlyDues = (int)SelectedMonthly.Value;
                    int TypeLoan = (int)SelectedLoanType.Value;
                    txtInterestRate.Text = InterestRate((int?)SelectedLoanType.Value);

                    lblTotalDues.Visible = true;
                    TxtAmountDues.Visible = true;
                    TxtAmountDues.Text = loan.LoanOperation(Amount,MonthlyDues,TypeLoan).ToString("#.##");
                    IsCalculate = true;

                }
            }
            catch (Exception)
            {

                throw;
            }

        
        }

        private void LoadComboBox() {
                      
            ComboBoxItem MonthlyAmount = new ComboBoxItem {
                Text = "Select a Month",
                Value = null
            };
            CbxMonthlyDues.Items.Add(MonthlyAmount);

            int[] Month = new int[19];

            ComboBoxItem[] MonthlyArray = new ComboBoxItem[19];

            Month[0] = 12;
            MonthlyArray[0] = new ComboBoxItem();

            MonthlyArray[0].Text= Convert.ToString($"{Month[0]} Month");
            MonthlyArray[0].Value = 12;
            CbxMonthlyDues.Items.Add(MonthlyArray[0]);
            for (int i = 1; i < 19; i++)
            {
                MonthlyArray[i] = new ComboBoxItem();
                Month[i] = Month[i-1] + 6;
                MonthlyArray[i].Text = Convert.ToString($"{Month[i]} Month");
                MonthlyArray[i].Value = Month[i - 1] + 6;
                CbxMonthlyDues.Items.Add(MonthlyArray[i]);
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

        private string InterestRate(int? TypeLoan) {

            string Rate;
            switch (TypeLoan)
            {
                case (int)LoanEnum.Personal:
                    Rate = "22%";
                    LblInterestRate.Visible = true;
                    txtInterestRate.Visible = true;
                    break;
                case (int)LoanEnum.Auto:
                    Rate = "12%";
                    LblInterestRate.Visible = true;
                    txtInterestRate.Visible = true;
                    break;
                case (int)LoanEnum.Mortgage:
                    Rate = "8%";
                    LblInterestRate.Visible = true;
                    txtInterestRate.Visible = true;
                    break;
                default:
                    Rate = "None";
                    LblInterestRate.Visible = true;
                    txtInterestRate.Visible = true;
                    break;
            }

            return Rate;
        }

        private void CbxMonthlyDues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCalculate)
            {
                LoanCalc();
            }
        }

        private void CbxTypeofLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCalculate)
            {
                LoanCalc();
            }
        }
    }
}
