﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TouchTypingGo.Domain.Core.AutoMapper;
using TouchTypingGo.Domain.Course;
using TouchTypingGo.Domain.Course.Commands.LessonResult;

namespace TouchTypingGo.Application.ViewModels
{
    public class LessonResultViewModel : IMapTo<LessonResult>, IMapFrom<LessonResult>, IHaveCustomMappings
    {
        public int Try { get; set; }
        public int Wpm { get; set; }
        public int Time { get; set; }
        public int Errors { get; set; }
        public bool EhAuthenticated { get; set; }
        public string ErrorKey { get; set; }
        public bool Active { get; set; }
        public Guid LessonPresentationId { get; set; }
        public virtual LessonPresentationViewModel LessonPresentation { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<LessonResultViewModel, AddLessonResultCommand>()
                .ConstructUsing(l => new AddLessonResultCommand(
                    l.Try, l.Wpm, l.Time, l.Errors, l.EhAuthenticated, l.ErrorKey, l.Active, l.LessonPresentationId, Guid.NewGuid()));
        }
    }
}