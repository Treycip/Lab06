using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Estudiante> estudiantes1 = new List<Estudiante>
            {
                new Estudiante { Nombres = "Xavier", Apellidos = "Egoavil", Edad = 18, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Sofia", Apellidos = "Arroyo", Edad = 22, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Gabriel", Apellidos = "Castañeda", Edad = 21, Seccion = "Seccion A" },
                new Estudiante { Nombres = "Jose", Apellidos = "Castillo", Edad = 20, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Fernando", Apellidos = "Espinoza", Edad = 23, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Saul", Apellidos = "Nolorbe", Edad = 24, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Pablo", Apellidos = "Gonzales", Edad = 25, Seccion = "Seccion B" },
                new Estudiante { Nombres = "Brenda", Apellidos = "Perez", Edad = 26, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Lizeth", Apellidos = "Aysa", Edad = 20, Seccion = "Seccion C" },
                new Estudiante { Nombres = "Claudia", Apellidos = "Surco", Edad = 18, Seccion ="Seccion C" },
                new Estudiante { Nombres = "Julian", Apellidos ="Ponce", Edad=24, Seccion="Seccion C"},
                new Estudiante { Nombres ="Jefferson", Apellidos="Palomino", Edad=19, Seccion="Seccion C"},
                new Estudiante { Nombres ="Hugo", Apellidos="Arguedas", Edad=23, Seccion="Seccion D"},
                new Estudiante { Nombres ="Mathias", Apellidos="Choque", Edad=22, Seccion="Seccion D"},
                new Estudiante { Nombres ="Dora", Apellidos="Centeno", Edad=21, Seccion="Seccion D"},
                new Estudiante { Nombres ="Patrick", Apellidos="Ore", Edad=19, Seccion="Seccion D"},
                new Estudiante { Nombres ="Martha", Apellidos="Gomez", Edad=25, Seccion="Seccion D"},
                new Estudiante { Nombres ="Blanca", Apellidos="Castro", Edad=24, Seccion="Seccion D"},
            };

            // Agrupar los estudiantes por sección usando LINQ
            // El método GroupBy crea un nuevo grupo para cada sección única en la lista de estudiantes

            var groupedStudents = estudiantes1.GroupBy(e => e.Seccion);

            // Asignar los grupos de estudiantes al ListView
            // ListView mostrará automáticamente los estudiantes agrupados por sección

            lvEstudiantes1.ItemsSource = groupedStudents;
        }
    }
}
