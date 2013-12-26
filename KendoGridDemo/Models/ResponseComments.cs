using System;

namespace KendoGridDemo.Models
{
    [Serializable]
    public class ResponseComments
    {
        public Decimal ID { get; set; }

        public string CmtText { get; set; }

        public DateTime DateEntered { get; set; }

        public int Status { get; set; }

    }
}

