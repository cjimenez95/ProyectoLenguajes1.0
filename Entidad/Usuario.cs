//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Pedido = new HashSet<Pedido>();
        }
    
        public int UsuarioID { get; set; }
        public byte TipoUsuarioID { get; set; }
        public string Contraseña { get; set; }
        public string NombreUsusario { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Nullable<bool> HabilitadoS_N { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
    }
}
