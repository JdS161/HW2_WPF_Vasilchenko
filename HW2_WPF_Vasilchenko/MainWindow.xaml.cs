using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace HW2_WPF_Vasilchenko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        Student[] students = new Student[]
        {
        new Student("Michael", "Scott", 12, 6 ),
        new Student("John", "Kirby", 12, 6),
        new Student("Helen", "Brown", 13, 7),
        new Student("Derek", "Dundy", 13, 7),
        new Student("Elon", "Doe", 18, 11),
        new Student("Zackary","Thomas", 9, 3),
        new Student("Joseph", "Rainolds", 7, 1),
        new Student("Kelly", "Black", 14, 8),
        new Student("Cary", "Evans", 15, 9),
        new Student("Michelle", "Tackerty", 10, 4)
        };
        public MainWindow()
        {
            InitializeComponent();
            
            studentList.ItemsSource = students;
            combo_sortBy.ItemsSource = new string[] { "First Name", "Last Name", "Grade", "Age" };
            combo_sortDir.ItemsSource = Enum.GetNames<ListSortDirection>();

            //combo_sortBy.SelectionChanged += SelectionChanged;
            //combo_sortDir.SelectionChanged += SelectionChanged;

            combo_sortBy.SelectionChanged += SelectionChanged;
            combo_sortDir.SelectionChanged += SelectionChanged;
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(studentList.ItemsSource);

            studentList.Items.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));

        }


        public void SortList()
        {
            var SortProperty = combo_sortBy.SelectedItem.ToString();
            var SortDirection = combo_sortDir.SelectedItem.ToString() == "Ascending" ? ListSortDirection.Ascending : ListSortDirection.Descending;



            studentList.Items.SortDescriptions[0] = new SortDescription(SortProperty, SortDirection);
        } 
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SortList();
        }

        //private void SelectionChanged (object sender, SelectionChangedEventArgs e)
        //{
        //    SortList();
        //}


        private void DeleteStudent()
        {
                studentList.Items.Remove(studentList.SelectedIndex);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeleteStudent();
        }


        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    myDataList = LoadListViewData();
        //    LeftListView.ItemsSource = myDataList;
        //}

        //privateArrayList LoadListViewData()
        //{
        //    ArrayList itemsList = newArrayList();
        //    itemsList.Add("Coffie");
        //    itemsList.Add("Tea");
        //    itemsList.Add("Orange Juice");
        //    itemsList.Add("Milk");
        //    itemsList.Add("Mango Shake");
        //    itemsList.Add("Iced Tea");
        //    itemsList.Add("Soda");
        //    itemsList.Add("Water");
        //    return itemsList;
        //}
    }
}
