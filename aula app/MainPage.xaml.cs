namespace aula_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Email = CampoEmail.Text;
            string Senha = CampoSenha.Text;

            if (Email == "dedexcoding@gmail.com" && Senha == "123456")
            {
                DisplayAlert("Login", "Login realizado com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Login", "Email ou senha incorretos.", "Tentar novamente");
            }
        }
    }
}
