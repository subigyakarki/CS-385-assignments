/*
Program: Reading Material App
Made by Subi
Date : 10/04/2025

PresentationGUI.cs
Displays details for Books, Magazines, and Online materials based on user selection using inheritance and interfaces.
 */
using ReadingMaterialNamespace; //Base class namespace
using IPrintableNamespace; //Interface namespace
using BookNamespace;       //Book subclass namespace
using MagazineNamespace;   //Magazine subclass namespace
using OnlineNamespace;     //Online subclass namespace

namespace PresentationGUI
{
    //Main GUI form for displaying reading materials
    public partial class PresentationGUI : Form
    {
        //Constructor
        public PresentationGUI()
        {
            InitializeComponent();  //Initialize GUI components
        }


        //Show details button click
        private void bttnShowDetail_Click(object sender, EventArgs e)
        {
            //Displays Information
            if (radBook.Checked) //book selected
            {
                Book book = new Book("Jane Eyre", "Charlotte Bronte", 1847, "Harper & Brothers of New York");
                txtBxTitle.Text = book.Title;
                txtBxAuthor.Text = book.Author;
                txtBxYear.Text = book.YearPublished.ToString();
                txtBxExtra.Text = "Published by " + book.Publisher;
                txtBxPrint.Text = book.GetPrintInfo();
            }
            else if (radMagazine.Checked) //magazine selected
            {
                Magazine magazine = new Magazine("Vogue France ", "Emmanuelle Alt", 2021, "Paris Bookstore");
                txtBxTitle.Text = magazine.Title;
                txtBxAuthor.Text = magazine.Author;
                txtBxYear.Text = magazine.YearPublished.ToString();
                txtBxExtra.Text = " Available in " + magazine.StoreName;
                txtBxPrint.Text = magazine.GetPrintInfo();
            }
            else //online selected
            {
                Online online = new Online("OnePiece", "Eiichiro Oda", 1997, "https://onepiece.com");
                txtBxTitle.Text = online.Title;
                txtBxAuthor.Text = online.Author;
                txtBxYear.Text = online.YearPublished.ToString();
                txtBxExtra.Text =  online.WebsiteURL;
                txtBxPrint.Text = "Online content — no hard copy.";
            }
           

        }
    }
}
