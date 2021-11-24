using System;
using System.Windows.Forms;
using System.IO.Ports;  // necessário para ter acesso as portas
using interfaceArduinoVS2013.Clientes.Entites;
using interfaceArduinoVS2013.Clientes.DAL;
using System.Data;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace interfaceArduinoVS2013
{
    public partial class Form1 : Form
    {

        private ClienteDAL dal;
        Cliente Cliente = new Cliente();
        string RxString;
        public Form1()
        {
            dal = new ClienteDAL();
            InitializeComponent();
            timerCOM.Enabled = true;
           serialPort1.DataReceived += serialPort_DataReceived;
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            textBoxReceber.AppendText(RxString);
        }

        private void textBoxReceber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPW1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPW2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPW3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPW4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("C");
                serialPort1.Write(textBoxID.Text);
                serialPort1.Write(textBoxId2.Text);
                serialPort1.Write(textBoxId3.Text);
                serialPort1.Write(textBoxPW1.Text);
                serialPort1.Write(textBoxPW2.Text);
                serialPort1.Write(textBoxPW3.Text);
                serialPort1.Write(textBoxPW4.Text);
                serialPort1.Write(textBoxStatus.Text);

                try
                {
                    Cliente.usuario = textBoxID.Text + textBoxId2.Text + textBoxId3.Text;
                    Cliente.Pin = textBoxPW1.Text + textBoxPW2.Text + textBoxPW3.Text + textBoxPW4.Text;
                    Cliente.Ativo = textBoxStatus.Text;
                    dal.cadastrarProduto(Cliente);
                    MessageBox.Show("Cadastro realizado com sucesso!\n         Consulte seu novo ID");
                    textBoxID.Clear();
                    textBoxId2.Clear();
                    textBoxId3.Clear();
                    textBoxPW1.Clear();
                    textBoxPW2.Clear();
                    textBoxPW3.Clear();
                    textBoxPW4.Clear();
                    textBoxStatus.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dal.CarregaProdutos(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("D");
                serialPort1.Write(txtDelete.Text);
                serialPort1.Write(txtDelete2.Text);
                serialPort1.Write(txtDelete3.Text);

                try
                {
                    dal.deletarProduto(txtDelete.Text + txtDelete2.Text + txtDelete3.Text);
                    MessageBox.Show("Usuário excluído com sucesso!");
                    txtDelete.Clear();
                    txtDelete2.Clear();
                    txtDelete3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("S");
                string statusId;
                statusId = txtBoxIdStatus.Text;
                string[] subs = statusId.Split(' ');
                foreach (var sub in subs)
                {
                    serialPort1.Write($"{sub}");

                }
                serialPort1.Write(txtBoxNovoStatus.Text);

                try
                {
                    dal.updateProdutoStatus(txtBoxIdStatus.Text, txtBoxNovoStatus.Text);
                    MessageBox.Show("Status alterado com sucesso!");
                    txtBoxIdStatus.Clear();
                    txtBoxNovoStatus.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxIdSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }
        string senhaId;
        string novaSenha;
        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("P");
                senhaId = textBoxIdSenha.Text;
                string[] subs = senhaId.Split(' ');

                foreach (var sub in subs)
                {
                    serialPort1.Write($"{sub}");
                }

                novaSenha = textBoxNovaSenha.Text;
                string[] s = novaSenha.Split(' ');

                foreach (var p in s)
                {
                    serialPort1.Write($"{p}");
                }

                try
                {
                    dal.updateProdutoSenha(textBoxIdSenha.Text, textBoxNovaSenha.Text);
                    MessageBox.Show("Senha alterada com sucesso!");
                    textBoxIdSenha.Clear();
                    textBoxNovaSenha.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void txtBoxIdStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxNovoStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtExibirPorId_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnExibirPorId_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dal.exibirProdutoId(dt, txtExibirPorId.Text);
                dataGridView1.DataSource = dt;
                txtExibirPorId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dal.ProdutosAtivo(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabDelete_Click(object sender, EventArgs e)
        {

        }

        private void btConectar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelete2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelete3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSincDbToPic_Click(object sender, EventArgs e)
        {
            List<Cliente> _clientes = new List<Cliente>();
            _clientes = dal.GetClienteDB();
            try
            {
                serialPort1.Write("K");
                foreach (var s in _clientes)
                {   
                    serialPort1.Write(s.usuario);
                    serialPort1.Write(s.Pin);
                    serialPort1.Write(s.Ativo);
                    Thread.Sleep(500);
                }
                MessageBox.Show("Upload enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSincPicToDb_Click(object sender, EventArgs e)
        {
            try
            {            
                serialPort1.ReadTimeout = (3000);
                string data = serialPort1.ReadExisting();
                string[] teste = data.Split(' ');             
                foreach(var s in teste)
                {
                    MessageBox.Show(s);          
                }               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
                       
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
   
        void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {

            try
            {      
                MessageBox.Show("Chegou novo download!");
            }
            catch (Exception ex)            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
