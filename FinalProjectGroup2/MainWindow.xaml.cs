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

namespace FinalProjectGroup2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindData();
        }
        public void BindData()
        {
            mediaData.ItemsSource = Library.media;
            memberData. ItemsSource = Library.member;
        }
        private void lentButton_Click(object sender, RoutedEventArgs e)
        {

            List<string> alreadyLentBook = new List<string>();
            List<string> lentBook = new List<string>();
            if ((mediaData.SelectedItems != null) && memberData.SelectedItem != null)
            {
                foreach (Media media in mediaData.SelectedItems)
                {
                    if (!media.CurrentStatus)
                    {
                        media.CurrentBorrowMember = ((LibraryMember)memberData.SelectedItem).Name;
                        media.CurrentStatus = true;
                        lentBook.Add(media.Title);
                    }
                    else
                        alreadyLentBook.Add(media.Title);

                }

                if (lentBook.Count != 0)
                    MessageBox.Show(string.Join(",",lentBook) + " is lent by "+ ((LibraryMember)memberData.SelectedItem).Name);

                if (alreadyLentBook.Count != 0)
                    MessageBox.Show(string.Join(",", alreadyLentBook) + " is already lent ");


                UpdateGridView();
            }
            else if ((memberData.SelectedValue != null) && (mediaData.SelectedValue != null))
            {
                LibraryMember lMember = (LibraryMember)(memberData.SelectedItem);
                Media lMedia = (Media)(mediaData.SelectedItem);
                if (lMedia.CurrentBorrowMember == null)
                {
                    lMedia.CurrentBorrowMember = lMember.Name;
                    lMedia.CurrentStatus = true;
                    MessageBox.Show(lMedia.Title+" is lent by "+lMember.Name );
                    UpdateGridView();
                }
                else
                    MessageBox.Show(lMedia.Title + " is Already Lent");
            }
            else
                MessageBox.Show("Please select both Library Member and Media");

        }

        private void UpdateGridView()
        {
            mediaData.ItemsSource = null;
            mediaData.ItemsSource = Library.media;

        }


        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> lentBook = new List<string>();
            List<string> returnBook = new List<string>();
            if ((mediaData.SelectedItems != null) && memberData.SelectedItem != null)
            {
                foreach (Media media in mediaData.SelectedItems)
                {
                    if ((media.CurrentStatus) && ((LibraryMember)memberData.SelectedItem).Name == media.CurrentBorrowMember)
                    {
                        media.CurrentBorrowMember = null;
                        media.CurrentStatus = false;
                        returnBook.Add(media.Title);
                    }
                    else if ((media.CurrentStatus) && ((LibraryMember)memberData.SelectedItem).Name != media.CurrentBorrowMember)
                        lentBook.Add(media.Title);
                }
                if (returnBook.Count != 0)
                    MessageBox.Show(string.Join(",",returnBook)+ "is return by "+ ((LibraryMember)memberData.SelectedItem).Name);

                if (lentBook.Count != 0)
                    MessageBox.Show(string.Join(", ", lentBook) + " is lent by other member ");
                UpdateGridView();
            }
            else if ((memberData.SelectedValue != null) && (mediaData.SelectedValue != null))
            {
                LibraryMember lMember = (LibraryMember)(memberData.SelectedItem);
                Media lMedia = (Media)(mediaData.SelectedItem);
                if (lMedia.CurrentBorrowMember != null)
                {
                    if (lMember.Name == lMedia.CurrentBorrowMember)
                    {
                        lMedia.CurrentBorrowMember = "";
                        lMedia.CurrentStatus = false;
                        MessageBox.Show(lMedia.Title+" is return by "+lMember.Name);
                        UpdateGridView();
                    }
                    else
                        MessageBox.Show("Please select Right Person who lent " + lMedia.Title);
                        
                }
                else
                    MessageBox.Show(lMedia.Title + " is not lent");
            }
            else
                MessageBox.Show("Please select both Library Member and Media");
        }
    }
}
