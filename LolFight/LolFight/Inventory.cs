//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LolFight
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public int IdInventory { get; set; }
        public int IdChampion { get; set; }
        public int IdItem { get; set; }
        public Nullable<int> Activated { get; set; }
    
        public virtual Champion Champion { get; set; }
        public virtual Item Item { get; set; }
    }
}
