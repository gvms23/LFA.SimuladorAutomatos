using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimuladorAutomatos
{
    public partial class frmExercicio2 : Form
    {

        //declarando variáveis globais
        string stringEntrada = string.Empty;
        int quantidadeCaracteresEntrada = 0;
        char[] charEntrada = null;
        string estadoAtual = "q0";
        int i = 0;
        int contagemQuantasVezesNoQ2 = 0;


        public frmExercicio2()
        {
            InitializeComponent();
        }

        //zerando e limpando tudo o que foi executado.
        public void zerarRotina()
        {
            estadoAtual = "q0";

            //limpando o estado q0
            pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
            lblQ0.BackColor = Color.White;

            //limpando o estado q1
            pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
            lblQ1.BackColor = Color.White;

            //limpando o estado q2
            pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
            lblQ2.BackColor = Color.White;

            //o log só deverá ser limpo se o log tiver conteúdo.
            if (txtLog.TextLength > 1)
            {
                DialogResult dr = MessageBox.Show("Deseja limpar o log?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    txtLog.Text = string.Empty;
                }
            }

        }

        private void frmExercicio2_Load(object sender, EventArgs e)
        {
            // Criando um tooltip para informar o usuário sobre cada controle do form.
            ToolTip toolTip1 = new ToolTip();

            // Configurando o delay do tooltip
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;

            // Forçando ele ser mostrado sempre
            toolTip1.ShowAlways = true;

            // Configurando para cada um dos controles.
            toolTip1.SetToolTip(this.chkPassoApasso, "Pressione F2 para marcar ou desmarcar essa opção.");
            toolTip1.SetToolTip(this.btnSolucao, "Pressione Enter para executar o botão.");
            toolTip1.SetToolTip(this.txtEntrada, "Digite apenas 0s e 1s nesse campo.");
            toolTip1.SetToolTip(this.gpbResultado, "O estado atual ficará amarelo caso o checkbox de acompanhar passo a passo esteja checado.");
            toolTip1.SetToolTip(this.txtLog, "Log de todas as mudanças de estado.");
            toolTip1.SetToolTip(this.lblSobre, "Opa, sou eu mesmo rs. :D");
            toolTip1.SetToolTip(this.pcbLinkedin, "Quer visualizar meu perfil no Linkedin? :D");

            
        }

        private void btnSolucao_Click(object sender, EventArgs e)
        {
            //se estiver vazio retorna com erro
            if (txtEntrada.Text == string.Empty)
            {
                DialogResult dr = MessageBox.Show("A entrada não pode estar vazia, Deseja gerar 5 números aleatórios?", "Entrada Inválida", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Yes)
                {
                    Random randNum = new Random();

                    for (int i = 0; i < 5; i++)
                    {
                        txtEntrada.Text += randNum.Next(2);
                    }
                }

                else
                {
                    return;
                }
            }

            //executa a limpeza sempre que precisar
            zerarRotina();

            //desabilito o botão
            btnSolucao.Enabled = false;

            //recebe entrada
            stringEntrada = txtEntrada.Text;

            //recebe a quantidade de entrada
            quantidadeCaracteresEntrada = stringEntrada.Length;

            //converte string em caractere
            charEntrada = stringEntrada.ToCharArray();

            // header do log
            txtLog.Text += "--------------------------------------------" + Environment.NewLine;
            txtLog.Text += "Simulador de Autômatos" + Environment.NewLine;
            txtLog.Text += "Desenvolvimento: Gabriel Vicente" + Environment.NewLine;
            txtLog.Text += "LOG gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine + Environment.NewLine;
            txtLog.Text += "Lógica: L (M) = {w ∈ {0,1} | w termina em 00}" + Environment.NewLine;
            txtLog.Text += "Caracteres de Entrada:" + Environment.NewLine + stringEntrada + Environment.NewLine + Environment.NewLine;


            #region mudarEstados

            for (i = 0; i < quantidadeCaracteresEntrada; i++)
            {
                
                if (estadoAtual == "q0")
                {

                    if (charEntrada[i] == '1')
                    {
                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        //limpando o estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ0.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q0 | Entrada: 1 | Ação: Permaneço no q1." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q0 | Entrada: 1 | Ação: Permaneço no q1.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q0";
                    }

                    else if (charEntrada[i] == '0')
                    {
                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        //limpando o estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ0.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q0 | Entrada: 0 | Ação: Vou para q1." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q0 | Entrada: 0 | Ação: Vou para q1.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q1";
                    }


                }

                else if (estadoAtual == "q1")
                {

                    if (charEntrada[i] == '0')
                    {
                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //limpando o estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        //mudando layout do estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ1.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q1 | Entrada: 0 | Ação: Vou para q2." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q1 | Entrada: 0 | Ação: Vou para q2.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q2";
                    }

                    else if (charEntrada[i] == '1')
                    {
                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //limpando o estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        //mudando layout do estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ1.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q1 | Entrada: 1 | Ação: Volto para q0." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q1 | Entrada: 1 | Ação: Volto para q0.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q0";

                    }
                }

                else if (estadoAtual == "q2")
                {

                    if (charEntrada[i] == '0')
                    {
                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //mudando layout do estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ2.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q2 | Entrada: 0 | Ação: Permaneço em q2." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q2 | Entrada: 0 | Ação: Permaneço em q2.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q2";
                    }

                    else if (charEntrada[i] == '1')
                    {
                        contagemQuantasVezesNoQ2++;
                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        //mudando layout do estado q2
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.yellow_circle;
                        lblQ2.BackColor = Color.Yellow;

                        txtLog.Text += "Estado: q2 | Entrada: 1 | Ação: Volto para q0." + Environment.NewLine;

                        if (chkPassoApasso.Checked == true)
                        {
                            MessageBox.Show("Estado: q2 | Entrada: 1 | Ação: Volto para q0.", "Passo a Passo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        estadoAtual = "q0";
                    }


                }

                //se for o ultimo
                if (i == quantidadeCaracteresEntrada - 1)
                {
                    if (estadoAtual == "q2" && charEntrada[i] == '0')
                    {

                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        txtLog.Text += "Terminou no estado q2 e com entrada 00, parabéns!" + Environment.NewLine;
                        MessageBox.Show("Terminou no q2 e com a entrada 00, parabéns!", "Entrada Aceita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {

                        //limpando o estado q0
                        pcbEstadoQ0.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ0.BackColor = Color.White;

                        //limpando o estado q1
                        pcbEstadoQ1.Image = SimuladorAutomatos.Properties.Resources.white_circle;
                        lblQ1.BackColor = Color.White;

                        //limpando o estado q1
                        pcbEstadoQ2.Image = SimuladorAutomatos.Properties.Resources.duplo_circulo_;
                        lblQ2.BackColor = Color.White;

                        txtLog.Text += "Rejeitado, não terminou no q2 e com a entrada 00" + Environment.NewLine;
                        MessageBox.Show("Rejeitado, não terminou no q2 e com a entrada 00", "Entrada Rejeitada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            } //termina o laço for

            #endregion mudarEstados

            // botão volta a ser habilitado
            btnSolucao.Enabled = true;

            //texto de entrada fica vazio, se precisar está no log
            txtEntrada.Text = string.Empty;
        }

        //só aceita zero e um no textbox
        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };

            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        //se apertar enter ou F5 para apertar no botão e F2 para o checkbox
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter || keyData == Keys.F5)
            {
                btnSolucao.PerformClick();
            }

            if (keyData == Keys.F2)
            {
                if (chkPassoApasso.Checked == true)
                {
                    chkPassoApasso.Checked = false;
                }

                else
                {
                    chkPassoApasso.Checked = true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void voltarParaOExercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreFormExercicio1();
        }

        public void abreFormExercicio1()
        {
            //abre o outro form
            //função para abrir outro form em um novo thread
            //expressão lambda "=>"
            var novoThread = new Thread(() =>
            {
                Application.Run(new frmExercicio1());
            });

            //inicia o novo thread
            novoThread.Start();

            //fecho esse form atual com o dispose
            this.Dispose();
        }

        private void pcbLinkedin_Click(object sender, EventArgs e)
        {

            string msg = ("Quer visualizar meu perfil no Linkedin? \n\nClique em \"Sim\" para visitar a seguinte URL:\nhttps://www.linkedin.com/in/gvms23/");

            if (MessageBox.Show(msg, "Ajuda", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://www.linkedin.com/in/gvms23");
            }
        }
    }
}
