using System;

namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        // test

        public int MyProperty { get; set; }

        public int MyProperty1 { get; set; }
    }
}