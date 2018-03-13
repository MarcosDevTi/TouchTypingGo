using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Keyboard : Entity<Keyboard>
    {
        public string Nome { get; private set; }
        public int Lcid { get; private set; }
        public string ValHtml { get; private set; }
        public string KeyboardContent { get; private set; }
        public bool Active { get; private set; }
        public override bool IsValid()
        {
            return true;
        }
    }
}
