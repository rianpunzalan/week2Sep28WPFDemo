using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace week2Sep28WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // we will place the code here, what we want to execute when the button is pressed
            Student student = new Student();
            student.stud_name=txtbxStudName.Text;
            student.stud_id = int.Parse(txtbxStudID.Text);//textbox always returns string, so we have to parse it into integer
            student.stud_addr = txtbxStudAddr.Text;
            student.stud_regdate = int.Parse(cboRegDate.Text);
            printInfo(student);//
        }

        private void printInfo(Student student)
        {
            string toPrint = "The name of the student: " + student.stud_name + "\n" +
                "The ID of the student: " + student.stud_id.ToString() + "\n" +
                "The address of the student: " + student.stud_addr + "\n" +
                "The registration year: " + student.stud_regdate.ToString();
            MessageBox.Show(toPrint);
            //messagebox only accepts text. so we have to use ToString();
        }

        
    }
}
