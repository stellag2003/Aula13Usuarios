namespace Aula13Usuarios
{
    public partial class Form1 : Form
    {
        List <Pessoa> Listapessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaInterface()
        {
            listView1.Clear();
            for(int i = 0; i < Listapessoas.Count; i++)
            {
                listView1.Items.Add(Listapessoas[i].nome);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa( nome, idade, rua, cidade );

            Listapessoas.Add(pessoa);
            atualizaInterface();

        }
    }
}