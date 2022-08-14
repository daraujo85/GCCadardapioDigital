using Squirrel.Domain.Entities.Base;

namespace Squirrel.Domain.Entities.Products
{
    public class ExtraProduct : EntityBase
    {
        public ExtraProduct() { }

        public ExtraProduct(string extrasTitle,
                            int limitChoicesHowMany,
                            bool required,
                            bool available,
                            string description,
                            List<ExtraOptions> extraOptions)
        {
            ExtrasTitle = extrasTitle;
            LimitChoicesHowMany = limitChoicesHowMany;
            Required = required;
            Available = available;
            Description = description;
            ExtraOptions = extraOptions;
        }


        public string ExtrasTitle { get; private set; }
        public int LimitChoicesHowMany { get; private set; } = 0;
        public bool Required { get; private set; }
        public bool Available { get; private set; }
        public string Description { get; private set; }
        public List<ExtraOptions> ExtraOptions { get; private set; }


        public void Update(ExtraProduct extraProduct)
        {
            ArgumentNullException.ThrowIfNull(nameof(extraProduct));

            ExtrasTitle = extraProduct.ExtrasTitle;
            LimitChoicesHowMany = extraProduct.LimitChoicesHowMany;
            Required = extraProduct.Required;
            Available = extraProduct.Available;
            Description = extraProduct.Description;
            ExtraOptions = extraProduct.ExtraOptions;
        }

        public void ChangeExtrasTitle(string extrasTitle)
        {
            ArgumentNullException.ThrowIfNull(nameof(extrasTitle));
            ExtrasTitle = extrasTitle;
        }

        public void ChangeLimitChoices(int limitChoices)
        {
            LimitChoicesHowMany = limitChoices;
        }

        public void ChangeRequired(bool required)
        {
            Required = required;
        }

        public void ChangeAvailable(bool available)
        {
            Available = available;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public void AddExtraOption(ExtraOptions extraOptions)
        {
            ExtraOptions ??= new List<ExtraOptions>();
            ExtraOptions.Add(extraOptions);
        }

        public void RemoveExtraOption(Guid id)
        {
            if (!ExtraOptions.Any()) return;

            var index = ExtraOptions.FindIndex(x => x.Id == id);
            ExtraOptions.RemoveAt(index);
        }
    }
}
