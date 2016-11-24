namespace HelpDeskApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketResponses")]
    public partial class TicketRespons
    {
        [Key]
        public int TicketResponseId { get; set; }

        public string QuestionText { get; set; }

        public string Response { get; set; }

        public virtual TicketRespons TicketResponses1 { get; set; }

        public virtual TicketRespons TicketRespons1 { get; set; }
    }
}
