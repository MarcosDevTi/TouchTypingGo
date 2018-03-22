using System;
using System.Linq;
using TouchTypingGo.Application.Interfaces;
using TouchTypingGo.Domain.Course.Repository;

namespace TouchTypingGo.Application.Services.Helper
{
    public class HelperService : IHelperService
    {
        private readonly ICourseRepository _courseRepository;

        public HelperService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;

        }
        private static readonly Random Random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public string NewCode()
        {
            var go = true;
            var code = string.Empty;
            while (go)
            {
                code = RandomString(4);
                if (!_courseRepository.Find(c => c.Code == code).Any())
                    go = false;
            }
            return code;
        }
    }
}
