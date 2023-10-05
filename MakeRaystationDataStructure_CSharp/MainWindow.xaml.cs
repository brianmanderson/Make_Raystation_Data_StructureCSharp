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
using System.Text.Json;
using DataBaseStructure.Base;
using System.IO;

namespace MakeRaystationDataStructure_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string file_name = @"C:\Users\markb\Modular_Projects\PatientDB_Deceased.json";
            string jsonString = File.ReadAllText(file_name);
            PatientDatabase database = JsonSerializer.Deserialize<PatientDatabase>(jsonString);
            int x = 5;
        }
    }
}
