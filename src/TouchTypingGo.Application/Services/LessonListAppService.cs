using System;
using System.Collections.Generic;
using System.Linq;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Application.ViewModels;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services
{
    public class LessonListAppService : ILessonListAppService
    {
        private readonly ILessonResultRepository _lessonResultRepository;
        private readonly ILessonPresentationRepository _lessonPresentationRepository;

        public LessonListAppService(ILessonResultRepository lessonResultRepository, ILessonPresentationRepository lessonPresentationRepository)
        {
            _lessonResultRepository = lessonResultRepository;
            _lessonPresentationRepository = lessonPresentationRepository;
        }

        public Dictionary<string, List<PreviewLessonViewModel>> GroupByCategory(IEnumerable<PreviewLessonViewModel> lessonPreviews)
        {
            var byCategory = lessonPreviews.GroupBy(
                x => x.Category,
                x => x,
                (key, g) => new { Category = key, lesson = g.ToList() });

            return byCategory.ToDictionary(t => t.Category, t => t.lesson);
        }

        public Dictionary<string, List<PreviewLessonViewModel>> PreviewLessonViewModels()
        {
            var lessonPresentations = _lessonPresentationRepository.GetAll();
            var lessonResults = _lessonResultRepository.GetAll();

            var lessonPrw = (from lessonPresentation in lessonPresentations
                             let last = lessonResults.Where(
                                 x => x.LessonPresentationId == lessonPresentation.Id).OrderByDescending(
                                     x => x.DateCreated).LastOrDefault()
                             select new PreviewLessonViewModel
                             {
                                 Id = lessonPresentation.Id,
                                 Name = lessonPresentation.Name,
                                 Time = last?.Time,
                                 Wpm = last?.Wpm,
                                 Errors = last?.Errors,
                                 CoutResolute = lessonResults.Count(x => x.LessonPresentationId == lessonPresentation.Id),
                                 Started = lessonResults.Any(x => x.LessonPresentationId == lessonPresentation.Id),
                                 PreviewText = lessonPresentation.Text.Length > 20
                                    ? lessonPresentation.Text.Substring(0, 20) : lessonPresentation.Text,
                                 Category = lessonPresentation.Category
                             }).ToList();

            return GroupByCategory(lessonPrw);
        }

        public AppViewModel GetById(Guid id)
        {
            var lessonPresentation = _lessonPresentationRepository.GetById(id);
            var lessonResults = _lessonResultRepository.Find(l => l.LessonPresentationId == id);
            var rest = lessonResults.Where(x => x.LessonPresentationId == id);
            var minTime = rest.Any() ? rest.Min(x => x.Time) : null;
            var minErrors = rest.Any() ? rest.Min(x => x.Errors) : null;

            var preview = new AppViewModel
            {
                Id = id,
                Name = lessonPresentation.Name,
                Category = lessonPresentation.Category,
                Started = rest.Any(),
                Text = lessonPresentation.Text,
                MinTime = minTime,
                MinErrors = minErrors
            };

            return preview;
        }

        public void CompleteLesson(AppViewModel appViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
