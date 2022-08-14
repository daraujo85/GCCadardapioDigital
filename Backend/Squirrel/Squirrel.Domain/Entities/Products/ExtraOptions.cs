using Squirrel.Domain.Entities.Base;

namespace Squirrel.Domain.Entities.Products
{
    public class ExtraOptions : EntityBase
    {
        public ExtraOptions() { }

        public ExtraOptions(string name,
                            decimal price,
                            string description,
                            bool available)
        {
            Name = name;
            Price = price;
            Description = description;
            Available = available;
        }


        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public bool Available { get; private set; }


        public void Update(ExtraOptions extraOptions)
        {
            ArgumentNullException.ThrowIfNull(nameof(extraOptions));

            Name = extraOptions.Name;
            Price = extraOptions.Price;
            Description = extraOptions.Description;
            Available = extraOptions.Available;
        }

        public void ChangeName(string name)
        {
            ArgumentNullException.ThrowIfNull(nameof(name));
            Name = name;
        }

        public void ChangePrice(decimal price)
        {
            Price = price;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public void ChangeAvailable(bool available)
        {
            Available = available;
        }
    }
}
