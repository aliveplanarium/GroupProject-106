namespace GroupProject_106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //��������� ������ � ����������
            string expr = " (sin(x) * cos(x))";
            CheckForSyntax check = new CheckForSyntax(expr);

            //��������� ��������� �� �������� ���������
            if (check.ExpressionDiagnostic()) {

            //���� ��� �� , ������ , �����������
            
            }
        }
    }
}