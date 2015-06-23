using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_API.Models
{

    public class clientes
    {
        [Key]
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public bool moroso { get; set; }

    }

    public class prestamos
    {
        [Key]
        public int id { get; set; }
        public string cliente { get; set; }
        public double monto { get; set; }
        public double interes { get; set; }
        public int cuotas { get; set; }
        public double saldo { get; set; }
        public double total { get; set; }
        public bool recargo { get; set; }
        public DateTime fecha { get; set; }
        public int dia_pago { get; set; }

        public ICollection<prestamos_cuotas> prestamos_cuotas { get; set; }

    }

    public class prestamos_cuotas
    {
        [Key]
        public int id { get; set; }
        public int id_prestamos { get; set; }
        public DateTime fecha_pactada { get; set; }
        [NotMapped]
        public DateTime fecha_pago { get; set; }
        public double monto { get; set; }
        public double saldo { get; set; }
        public int num_cuota { get; set; }
        public bool pago { get; set; }

        [ForeignKey("id_prestamos")]
        public prestamos prestamos { get; set; }
    }
}
