using System;
using System.Collections.Generic;
using System.Text;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;

namespace TouchTypingGo.Application.ViewModels
{
    public class KeyboardViewModel : IMapFrom<Keyboard>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Lcid { get; set; }
        public string ValHtml { get; set; }
        public string KeyboardContent { get; set; }
        public bool Active { get; set; }
    }
}
