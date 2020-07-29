using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Windows.Forms;

namespace CompiladorCShap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CompilarButton_Click(object sender, EventArgs e)
        {
            CompilerParameters Parametros = new CompilerParameters();
            CodeDomProvider DominioCodigo = CodeDomProvider.CreateProvider("CSharp");
            string Salida = "Out.exe";

            Parametros.GenerateExecutable = true;
            Parametros.OutputAssembly = Salida;
            CompilerResults Resultado = DominioCodigo.CompileAssemblyFromSource(Parametros, CodigoTextBox.Text);

            ResultadoTextBox.Text = string.Empty;

            if (Resultado.Errors.Count == 0)
            {
                ResultadoTextBox.Text = "El codigo fue compilado de manera exitosa";
                ResultadoTextBox.BackColor = Color.Green;
            }
            else
            {
                foreach (CompilerError Contador in Resultado.Errors)
                    ResultadoTextBox.Text = ResultadoTextBox.Text + "Error en la linea " + Contador.Line + "\n" + Contador.ErrorText;

                ResultadoTextBox.BackColor = Color.Red;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CodigoInicio();
            PosicionarCursor();
        }

        void CodigoInicio()
        {
            string AbrirLlave = "{", CerrarLlave = "}";

            CodigoTextBox.Text = string.Format(
                "using System;\r\n\r\n" +
                "namespace CompiladorCShap \r\n{0} \r\n" +
                "\tclass Program \r\n\t{0}\r\n" +
                "\t\tstatic void Main(string[] args)\r\n\t\t{0}\r\n\t\t\t\r\n" +
                "\t\t{1}\r\n\t{1}\r\n{1}"

            , AbrirLlave, CerrarLlave);
        }

        void PosicionarCursor()
        {
            CodigoTextBox.Focus();
            CodigoTextBox.SelectionStart = CodigoTextBox.Text.Length - 12;
        }

        private void CodigoTextBox_TextChanged(object sender, EventArgs e)
        {
            ResultadoTextBox.BackColor = Color.White;
            ResultadoTextBox.Text = string.Empty;
        }
    }
}
