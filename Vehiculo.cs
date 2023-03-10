//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullProgram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.LegajosVehiculares = new HashSet<LegajosVehiculare>();
        }
    
        public int Id { get; set; }
        public string ChapaPatente { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public int IdTipoMovil { get; set; }
        public int IdMarca { get; set; }
        public string Documentacion { get; set; }
        public string Titular { get; set; }
        public Nullable<int> AñoModelo { get; set; }
        public string Regimen { get; set; }
        public string Acta { get; set; }
        public string Titulo { get; set; }
        public string Cedula { get; set; }
        public int IdModelo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LegajosVehiculare> LegajosVehiculares { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public virtual TipoMovil TipoMovil { get; set; }
    }
}
