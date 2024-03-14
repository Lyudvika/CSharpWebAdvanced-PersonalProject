using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace ChemJourney.Web.ModelBinders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueResult != ValueProviderResult.None && !string.IsNullOrWhiteSpace(valueResult.FirstValue))
            {
                decimal parsedValue = 0m;
                bool binderSucceed = false;

                try
                {
                    string formDecimalValue = valueResult.FirstValue;
                    formDecimalValue = formDecimalValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    formDecimalValue = formDecimalValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    parsedValue = Convert.ToDecimal(formDecimalValue);
                    binderSucceed = true;
                }
                catch (FormatException ex)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, ex, bindingContext.ModelMetadata);
                }

                if (binderSucceed)
                {
                    bindingContext.Result = ModelBindingResult.Success(parsedValue);
                }
            }

            return Task.CompletedTask;
        }
    }
}
