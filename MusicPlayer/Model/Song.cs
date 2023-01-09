//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicPlayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SONG()
        {
            this.LASTESTs = new HashSet<LASTEST>();
            this.USERS = new HashSet<USER>();
        }
    
        public int SONGID { get; set; }
        public string SONGNAME { get; set; }
        public string SINGERNAME { get; set; }
        public string SONGURL { get; set; }
        public string DOWNLOADURL { get; set; }
        public string IMAGEURL { get; set; }
        public string SAVEPATH { get; set; }
        public Nullable<double> DURATION { get; set; }
        public Nullable<double> POSITION { get; set; }
    
        public virtual FEATUREDSONG FEATUREDSONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LASTEST> LASTESTs { get; set; }
        public virtual NEWSONG NEWSONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USERS { get; set; }
    }
}
