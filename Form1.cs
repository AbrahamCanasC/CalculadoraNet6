namespace CalculadoraNet6
{
    public partial class Calculadora : Form
    {


        //Variables globales
        double Auxiliar1;
        double Auxiliar2;
        string Operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Clase_suma Objsuma = new Clases.Clase_suma(); //Creamos la instancia para la clase_suma.
        Clases.Clase_Resta Objresta = new Clases.Clase_Resta(); //Creamos la instancia para la clase_Resta.
        Clases.Clase_multiplicacion Objmultiplicacion = new Clases.Clase_multiplicacion(); //Creamos la instancia para la clase_multiplicacion.
        Clases.Clase_division Objdivision = new Clases.Clase_division(); //Creamos la instancia para la clase_division.
        Clases.Clase_Porcentaje Objporcentaje = new Clases.Clase_Porcentaje(); //Creamos la instancia para la clase_division.
        Clases.Clase_Cambio_Signo Objcambio = new Clases.Clase_Cambio_Signo();
        Clases.Clase_Elevar2 Objelevar2 = new Clases.Clase_Elevar2();
        Clases.Clase_Raiz2 Objraiz2 = new Clases.Clase_Raiz2();


        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {
            //Debe de estar, de lo contrario no cargará nada a la pantalla y marcará error.
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar y limpiamos la pantalla. 
            Operador = "+";
            Auxiliar1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }
        private void Resta_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar y limpiamos la pantalla. 
            Operador = "-";
            Auxiliar1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar y limpiamos la pantalla. 
            Operador = "*";
            Auxiliar1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }


        private void Division_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar y limpiamos la pantalla. 
            Operador = "/";
            Auxiliar1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar. 
            double Operacion_Porcentaje;
            Auxiliar1 = double.Parse(Pantalla.Text);
            Operacion_Porcentaje = Objporcentaje.Porcentaje((Auxiliar1));
            Pantalla.Text = Operacion_Porcentaje.ToString();

        }

        private void Positivo_Negativo_Click(object sender, EventArgs e)
        {
            //Asignamos el símbolo a la variable, tomamos el valor en pantalla hacia la variable auxiliar. 
            double Operacion_Cambio_Signo;
            Auxiliar1 = double.Parse(Pantalla.Text);
            Operacion_Cambio_Signo = Objcambio.Cambio_Signo((Auxiliar1));
            Pantalla.Text = Operacion_Cambio_Signo.ToString();
        }

        private void Raiz_Cuadrada_Click(object sender, EventArgs e)
        {
            double Operacion_Raiz;
            Auxiliar1 = double.Parse(Pantalla.Text);
            Operacion_Raiz = Objraiz2.Raiz((Auxiliar1));
            Pantalla.Text = Operacion_Raiz.ToString();
        }

        private void Cuadrado_Click(object sender, EventArgs e)
        { 
            double Operacion_Elevar;
            Auxiliar1 = double.Parse(Pantalla.Text);
            Operacion_Elevar = Objelevar2.Elevar((Auxiliar1));
            Pantalla.Text = Operacion_Elevar.ToString();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            Auxiliar2 = double.Parse(Pantalla.Text);
            double Operacion_Suma;
            double Operacion_Resta;
            double Operacion_Multiplicacion;
            double Operacion_Division;

            switch(Operador){
                case "+":
                    Operacion_Suma = Objsuma.Sumas((Auxiliar1),(Auxiliar2));
                    Pantalla.Text = Operacion_Suma.ToString();
                    break;

                case "-":
                    Operacion_Resta = Objresta.Restas((Auxiliar1), (Auxiliar2));
                    Pantalla.Text = Operacion_Resta.ToString();
                    break;

                case "*":
                    Operacion_Multiplicacion = Objmultiplicacion.Multiplicacion((Auxiliar1), (Auxiliar2));
                    Pantalla.Text = Operacion_Multiplicacion.ToString();
                    break;

                case "/":
                    Operacion_Division = Objdivision.Division((Auxiliar1), (Auxiliar2));
                    Pantalla.Text = Operacion_Division.ToString();
                    break;


            }



        }


        private void Limpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void Punto_Decimal_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

 

        private void Uno_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1"; //Asignamos valor 1 al botòn.
        }

        private void Dos_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2"; //Asignamos valor 2 al botòn.
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3"; //Asignamos valor 3 al botòn.
        }

        private void Cuatro_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4"; //Asignamos valor 4 al botòn.
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5"; //Asignamos valor 5 al botòn.
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6"; //Asignamos valor 6 al botòn.
        }

        private void Siete_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7"; //Asignamos valor 7 al botòn.
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8"; //Asignamos valor 8 al botòn.
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9"; //Asignamos valor 9 al botòn.
        }

        private void Cero_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0"; //Asignamos valor 0 al botòn.
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}