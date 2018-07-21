using System;
using System.Collections.Generic;
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

        public string CreateLessonWithParagraph(string texto, int numLimite)
        {
            var textoFinal = TextResize(texto);
            var finalText = textoFinal;
            var partialText = string.Empty;
            var size = 0;
            var rr = GetPageLeght(textoFinal, numLimite);
            KeyValuePair<int, string> ss;
            size = rr.Key;
            partialText = rr.Value;
            while (true)
            {
                try
                {
                    finalText = finalText[size - 1] == ' '
                        ? finalText.Remove(size - 1, 1).Insert(size - 1, "¶") : finalText;

                    ss = GetPageLeght(partialText, numLimite);
                    size = size + ss.Key;
                    partialText = ss.Value;

                    GetPageLeght(partialText, numLimite);
                }
                catch (Exception)
                {
                    break;
                }
            }
            try
            {
                finalText = finalText.Remove(size - 1, 1).Insert(size - 1, "¶");
            }
            catch (Exception)
            {
                return finalText;
            }

            return finalText;
        }

        private static KeyValuePair<int, string> GetPageLeght(string texto, int numLimite)
        {
            if (texto.Length <= numLimite)
            {
                return new KeyValuePair<int, string>(texto.Length, texto);
            }
            try
            {
                var aa = GetIndexText(texto, numLimite);
                var bbTx = texto.Substring(aa + 1, texto.Length - aa - 1);
                var cc = GetIndexText(bbTx, numLimite);
                var ddTx = bbTx.Substring(cc + 1, bbTx.Length - cc - 1);
                var ee = GetIndexText(ddTx, numLimite);
                var finalTx = ddTx.Substring(ee + 1, ddTx.Length - ee - 1);
                return new KeyValuePair<int, string>(texto.Length - finalTx.Length, finalTx);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int GetIndexText(string texto, int indice)
        {
            var txt = string.Empty;
            while (texto.Length > indice)
            {
                try
                {
                    txt = texto.Substring(indice, 1);
                }
                catch (Exception)
                {
                    // throw;
                }

                if (txt == " ")
                    break;
                else
                    indice = indice - 1;
            }
            return indice;
        }

        private static string TextResize(string texto)
        {
            while (true)
            {
                if (texto.Length < 167)
                {
                    texto = texto + " " + texto;
                }
                else
                {
                    break;
                }
            }
            return texto;
        }
    }
}
