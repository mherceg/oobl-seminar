//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracktor.DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReputationInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContentCommentId { get; set; }
        public bool Score { get; set; }
    
        public virtual Comment Comment { get; set; }
        public virtual User User { get; set; }
    }
}