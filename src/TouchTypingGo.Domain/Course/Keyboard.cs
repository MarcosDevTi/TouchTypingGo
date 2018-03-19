using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.Entities;

namespace TouchTypingGo.Domain.Course
{
    public class Keyboard : Entity<Keyboard>
    {
        public Keyboard(string name, int lcid)
        {
            Name = name;
            Lcid = lcid;
        }

        protected Keyboard() { }

        public string Name { get; private set; }
        public int Lcid { get; private set; }
        public string ValHtml { get; private set; }
        public string KeyboardContent { get; private set; }
        public bool Active { get; private set; }

        public override bool IsValid()
        {
            return true;
        }

        public static class KeyboardFactory
        {
            public static Keyboard NewKeyboardFactory(
                string name,
                int lcid,
                string valHtml,
                string keyboradContent,
                bool active) =>
                            new Keyboard
                            {
                                Name = name,
                                Lcid = lcid,
                                ValHtml = valHtml,
                                KeyboardContent = keyboradContent,
                                Active = active
                            };
        }
    }
}
