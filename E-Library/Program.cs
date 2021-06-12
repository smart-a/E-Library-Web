using E_Library.Admin;
using E_Library.Admin.Dashboard;
using E_Library.Dashboard;
using E_Library.Helper;
using E_Library.Login;
using E_Library.Register;
using Wisej.Web;

namespace E_Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            LandingPage window = new LandingPage();
            window.Show();
        }

        //
        // You can use the entry method below
        // to receive the parameters from the URL in the args collection.
        //
        //static void Main(NameValueCollection args)
        //{
        //}

        static void Login()
        {
            Application.Browser.LocalStorage.GetValue("e_library", (string token) =>
            {
                if (token != null)
                {
                    var user = Auth.ValidateUser(JwtToken.DecodeToken(token));
                    if (user != null)
                    {
                        Application.Navigate("/Dashboard");
                        return;
                    }
                }
            });
            LoginPage window = new LoginPage();
            window.Show();
        }

        static void Register()
        {
            RegisterPage window = new RegisterPage();
            window.Show();
        }

        static void Dashboard()
        {
            Application.Browser.LocalStorage.GetValue("e_library", (string token) =>
            {
                if (token != null)
                {
                    var user = Auth.ValidateUser(JwtToken.DecodeToken(token));
                    if (user != null)
                    {
                        UserDashboard window = new UserDashboard(user);
                        window.Show();
                        return;
                    }
                }
                Application.Navigate("/");
            });

        }

        static void Admin()
        {
            Application.Browser.LocalStorage.GetValue("e_library_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        Application.Navigate("/Admin/Dashboard");
                        return;
                    }
                }
            });
            AdminLogin window = new AdminLogin();
            window.Show();
        }

        static void AdminDashboard()
        {
            Application.Browser.LocalStorage.GetValue("e_library_admin", (string token) =>
            {
                if (token != null)
                {
                    var admin = Auth.ValidateAdmin(JwtToken.DecodeAdminToken(token));
                    if (admin != null)
                    {
                        AdminDashboard window = new AdminDashboard();
                        window.Show();
                        return;
                    }
                }
                Application.Navigate("/Admin");
            });
        }
    }
}