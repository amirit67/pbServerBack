//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Paye.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TrustVote", Schema = "dbo")]
    public partial class TrustVote
    {
        [Key]
        public long Id { get; set; }
        public Nullable<long> VoterUserId { get; set; }
        public Nullable<long> VoteReciverUserId { get; set; }
        public Nullable<bool> State { get; set; }
        public Nullable<System.DateTime> ModeifidDate { get; set; }
    }
}
