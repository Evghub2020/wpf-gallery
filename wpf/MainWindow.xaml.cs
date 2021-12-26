using System.Windows;
using Tolik.Models;

namespace Tolik
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
        public void initdb()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                ImageFormat imgForm1 = new ImageFormat
                {
                    FormatName = "Format 1"
                };
                db.ImageFormats.Add(imgForm1);
                ImageFormat imgForm2 = new ImageFormat
                {
                    FormatName = "Format 2"
                };
                db.ImageFormats.Add(imgForm2);
                db.SaveChanges();

                Image img1 = new Image
                {
                    Name = "Name One",
                    File = "File One",
                    FormatId = 1,
                };
                db.Images.Add(img1);
                Image img2 = new Image
                {
                    Name = "Name Two",
                    FormatId = 2,
                    File = "File Two",
                };
                db.Images.Add(img2);
                db.SaveChanges();

                User user1 = new User
                {
                    Name = "Name One",
                    Login = "LoginOne",
                    Email = "EmailOne",
                    Password = "PasswordOne",
                    PicturesId = 1,
                };
                db.Users.Add(user1);
                User user2 = new User
                {
                    Name = "Name Two",
                    Login = "LoginTwo",
                    Email = "EmailTwo",
                    Password = "PasswordTwo",
                    PicturesId = 2,
                };
                db.Users.Add(user2);
                User user3 = new User
                {
                    Name = "Name Three",
                    Login = "LoginThree",
                    Email = "EmailThree",
                    Password = "PasswordThree",
                    PicturesId = 3,
                };
                db.Users.Add(user3);
                db.SaveChanges();

            }
        }
        public void button_Click(object sender, RoutedEventArgs e)
        {
            initdb();
            textBlock.Text = "База данных создана. Объекты успешно сохранены. ";
        }
    }
}
