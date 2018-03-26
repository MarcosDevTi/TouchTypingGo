using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TouchTypingGo.Site.Validation
{
    public class CustomValidationMetadataProvider : IValidationMetadataProvider
    {
        Dictionary<Type, string> _errorMessageMap;

        public CustomValidationMetadataProvider()
        {
            _errorMessageMap = new Dictionary<Type, string>
            {
                { typeof(RequiredAttribute), "RequiredError" },
                { typeof(MaxLengthAttribute), "MaxLengthError" }
            };
        }
        public void CreateValidationMetadata(ValidationMetadataProviderContext context)
        {
            foreach (var attribute in context.Attributes)
            {
                if (!(attribute is ValidationAttribute validationAttribute)) continue;
                var type = attribute.GetType();
                if (_errorMessageMap.TryGetValue(type, out var key))
                {
                    validationAttribute.ErrorMessage = key;
                }
            }
        }
    }
}
