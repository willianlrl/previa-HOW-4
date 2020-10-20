using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//adicionado para utilizar a referência Mysql.Data


namespace Agenda_Light
{
    public partial class Agenda : Form
    {

        //Essas 5 linhas acima são as variáveis para facilitar durante o processo de utilização do SQL.
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        string stringSql;


        public Agenda()
        {
            InitializeComponent();

            

        }


        private void addfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pooAgenda evento = new pooAgenda(); //cria uma instancia de pooAgenda (classe), chamado de evento
            
            //vincula os dados dos formulários aos atributos do objeto evento
            evento.Compromisso = txt_compromisso.Text; 
            evento.Dia = txt_dia.Text;
            evento.Hora = txt_hora.Text;
            evento.Local = txt_local.Text;
            evento.Contato = txt_contato.Text;


            try
            {
                conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Agenda Light\AgendaDB.mdf;Integrated Security=True"); //conexao recebe a string de conexao ao banco de dados
                stringSql = "INSERT INTO agendaTB(COMPROMISSO, DATA, HORA, LOCAL, CONTATO) VALUES (@COMPROMISSO, @DATA, @HORA, @LOCAL, @CONTATO)";  //STRING SQL PARA INSERIR O REGISTRO NO BANCO DE DADOS
                comando = new SqlCommand(stringSql, conexao);
                comando.Parameters.AddWithValue("@COMPROMISSO", evento.Compromisso); //adiciona o valor digitado no campo compromisso como propriedade compromisso no objeto evento
                comando.Parameters.AddWithValue("@DATA", evento.Dia);//adiciona o valor digitado no campo data como propriedade dia no objeto evento
                comando.Parameters.AddWithValue("@HORA", evento.Hora);//adiciona o valor digitado no campo hora como propriedade hora no objeto evento
                comando.Parameters.AddWithValue("@LOCAL", evento.Local);//adiciona o valor digitado no campo local como propriedade local no objeto evento
                comando.Parameters.AddWithValue("@CONTATO", evento.Contato);//adiciona o valor digitado no campo contato como propriedade contato no objeto evento

                conexao.Open();  //abre a conexao com o banco de dados

                comando.ExecuteNonQuery(); //O método ExecuteNonQuery é utilizado para executar instruções SQL que não retornam dados, como Insert, Update, Delete, e Set.
            }

            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message); //exibir a mensagem de exceção

            }

            finally
            {
                conexao.Close(); //fecha a conexão com o banco de dados 
                conexao = null;
                comando = null;
            }

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
