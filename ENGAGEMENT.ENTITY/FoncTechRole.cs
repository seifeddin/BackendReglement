//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENGAGEMENT.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoncTechRole
    {
        public int IdTechRole { get; set; }
        public Nullable<int> IdFoncRole { get; set; }
        public int Id { get; set; }
    
        public virtual RoleFonctionnel RoleFonctionnel { get; set; }
        public virtual RoleTechnique RoleTechnique { get; set; }
    }
}
