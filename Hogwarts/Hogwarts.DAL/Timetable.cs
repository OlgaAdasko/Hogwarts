//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hogwarts.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timetable
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        public int Room { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public System.DateTime StartTime { get; set; }
        public int Grade { get; set; }
    
        public virtual Houses Houses { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
