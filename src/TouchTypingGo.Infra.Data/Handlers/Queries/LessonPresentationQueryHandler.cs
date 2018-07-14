using System.Collections.Generic;
using System.Linq;
using TouchTypingGo.Application.Cqrs.Query.Models;
using TouchTypingGo.Application.Cqrs.Query.Models.LessonPresentation;
using TouchTypingGo.Application.Cqrs.Query.Queries;
using TouchTypingGo.Application.Cqrs.Query.Queries.LessonPresentation;
using TouchTypingGo.Domain.Core.Cqrs.Query;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Handlers.Queries
{
    public class LessonPresentationQueryHandler :
        IQueryHandler<GetLessonPresentationsIndex, IReadOnlyList<LessonPresentationIndex>>,
        IQueryHandler<GetLessonPresentationApp, LessonPresentationApp>
    {
        private readonly TouchTypingGoContext _context;

        public LessonPresentationQueryHandler(TouchTypingGoContext context)
        {
            _context = context;
        }

        public IReadOnlyList<LessonPresentationIndex> Handle(GetLessonPresentationsIndex query)
        {
            return _context.LessonPresentations.Select(x => new LessonPresentationIndex
            {
                Id = x.Id,
                Category = x.Category,
                FontSize = x.FontSize,
                Name = x.Name,
                PrecisionReference = x.PrecisionReference,
                SpeedReference = x.SpeedReference,
                Text = x.Text,
                TimeReference = x.TimeReference,
                UserId = x.UserId
            }).ToList();
        }

        public LessonPresentationApp Handle(GetLessonPresentationApp query)
        {
            var lesson = _context.LessonPresentations.Find(query.Id);
            return new LessonPresentationApp
            {
                Id = lesson.Id,
                PrecisionReference = lesson.PrecisionReference,
                SpeedReference = lesson.SpeedReference,
                TimeReference = lesson.TimeReference,
                Name = lesson.Name,
                Text = lesson.Text,
                Category = lesson.Category
            };
        }
    }
}
