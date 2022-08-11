using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Calculadora
{
    [Activity(Label = "Calculadora Grupal", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Btn 1 clic, suma
            Button BtnSuma = FindViewById<Button>(Resource.Id.button1);
            BtnSuma.Click += Btn_Sumar;

            //Btn 2 clic, resta
            Button BtnResta = FindViewById<Button>(Resource.Id.button2);
            BtnResta.Click += Btn_Restar;

            //Btn 3 clic, multiplicar
            Button BtnMutipli = FindViewById<Button>(Resource.Id.button3);
            BtnMutipli.Click += Btn_Multiplicar;

            //Btn 4 clic, suma
            Button BtnDividir = FindViewById<Button>(Resource.Id.button4);
            BtnDividir.Click += Btn_Dividir;

            //ID para imagen
            var iv = FindViewById<ImageView>(Resource.Id.imageView1);
            iv?.SetImageResource(Resource.Drawable.operaciones);
        }

        //Handles clics
        private void Btn_Sumar(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView respuesta = FindViewById<TextView>(Resource.Id.textView1);

            respuesta.Text = (int.Parse(input1.Text) + int.Parse(input2.Text)).ToString();
        }

        private void Btn_Restar(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView respuesta = FindViewById<TextView>(Resource.Id.textView1);

            respuesta.Text = (int.Parse(input1.Text) - int.Parse(input2.Text)).ToString();
        }

        private void Btn_Multiplicar(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView respuesta = FindViewById<TextView>(Resource.Id.textView1);

            respuesta.Text = (int.Parse(input1.Text) * int.Parse(input2.Text)).ToString();
        }

        private void Btn_Dividir(object sender, System.EventArgs e)
        {
            EditText input1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText input2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView respuesta = FindViewById<TextView>(Resource.Id.textView1);
            if(input2.Text == "0")
            {
                respuesta.Text = "El denominador no puede ser 0";
            }
            else
            {
            respuesta.Text = (int.Parse(input1.Text) / int.Parse(input2.Text)).ToString();
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}