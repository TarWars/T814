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
    
    public partial class Item
    {
        public Item()
        {
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int IdItem { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> HP { get; set; }
        public Nullable<int> AttackDamage { get; set; }
        public Nullable<int> AbilityDamage { get; set; }
        public Nullable<int> AttackSpeed { get; set; }
        public Nullable<int> Armor { get; set; }
        public Nullable<int> MagicResist { get; set; }
        public Nullable<int> Critical { get; set; }
        public Nullable<int> ArmorPenetration { get; set; }
        public Nullable<int> MagicPenetration { get; set; }
        public Nullable<int> Heal { get; set; }
    
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
