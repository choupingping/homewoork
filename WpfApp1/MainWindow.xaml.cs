using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp1
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

        private void TextBox1_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
                   
        }

        private void TextBox2_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
                string i = "a, a, a, b , , .b c. c a. a,d,d a c, c, b, b   c\r\n";
             
                int aaa = i.Count(f => f == 'a');
                Console.WriteLine(aaa);                          
                string axx =aaa.ToString();
                System.Console.WriteLine(axx);
               

                int bbb = i.Count(f => f == 'b');
                Console.WriteLine(bbb);
                string bxx = bbb.ToString();
                System.Console.WriteLine(bxx);

                int ccc = i.Count(f => f == 'c');
                Console.WriteLine(ccc);
                string cxx = ccc.ToString();
                System.Console.WriteLine(cxx);

                int ddd = i.Count(f => f == 'a');
                Console.WriteLine(ddd);
                string dxx = ddd.ToString();
                System.Console.WriteLine(dxx);


            MessageBox.Show("a = "+ axx +Environment.NewLine +"b = "+bxx + Environment.NewLine +"c = "+cxx + Environment.NewLine +"d = "+dxx);




            //TextBox2.Text.Count(f => f == 'a');

        }

         

           




        

        
    }
    }

